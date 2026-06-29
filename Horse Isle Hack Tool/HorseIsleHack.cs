using Horse_Isle_Hack_Tool.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace Horse_Isle_Hack_Tool
{
    public partial class hi1HackTool : Form
    {
        private const byte PACKET_LOGIN = 0x7F;
        private const byte PACKET_CHAT = 0x14;
        private const byte PACKET_USERINFO = 0x81;


        private const byte LOGIN_SUCCESS = 0x14;
        private const byte CHAT_RESP_BRIGHT = 0x15;

        private static byte[] SecCodeSeeds = new byte[3];
        private static int SecCodeInc = 0;
        private static int SecCodeCount = 0;

        private static bool IsAdmin = false;
        private static bool IsMod = false;

        private static Socket HI1GameServer;

        public hi1HackTool()
        {
            InitializeComponent();
        }

        private void hi1HackTool_Load(object sender, EventArgs e)
        {
            String[] ItemList = Resources.item_ids.Split('\n');
            itemList.Items.AddRange(ItemList);
            itemList.SelectedIndex = 0;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            int totalToAdd = (int)count.Value;
            for (int i = 0; i < totalToAdd; i++)
                addItems.Items.Add(itemList.SelectedItem);
        }

        private void removeSelected_Click(object sender, EventArgs e)
        {
            SelectedIndexCollection itemList = addItems.SelectedIndices;
            int itemCount = itemList.Count;

            if (itemCount < 1)
            {
                return;
            }
            
            for(int i = 0; i < itemCount; i++)
            {
                int item = itemList[0];
                addItems.Items.RemoveAt(item);
            }
        }
        
        private static void sendData(Socket hi1Server, byte[] PacketData)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(PacketData, 0x00, PacketData.Length);
            ms.WriteByte(0x00);
            ms.Seek(0x00, SeekOrigin.Begin);
            hi1Server.Send(ms.ToArray());
            ms.Dispose();
        }
        private byte[] waitForResponse(Socket hi1Server)
        {
            while (hi1Server.Available < 1)
            {
                Application.DoEvents();
            }
            byte[] policyFileResponse = new byte[hi1Server.Available];
            hi1Server.Receive(policyFileResponse);
            return policyFileResponse;
        }

        private void writeString(Stream stream,string str)
        {
            byte[] stringData = Encoding.ASCII.GetBytes(str);
            stream.Write(stringData,0x00,stringData.Length);
        }
        private string sendPolicyFileRequest(Socket hi1Server)
        {
            byte[] policyFileRequest = Encoding.ASCII.GetBytes("<policy-file-request/>");
            sendData(hi1Server, policyFileRequest);
            string policyFileResponse = Encoding.ASCII.GetString(waitForResponse(hi1Server));
            return policyFileResponse;
        }

        public static byte[] generateSecCode()
        {
            var i = 0;
            SecCodeCount++;
            SecCodeSeeds[SecCodeCount % 3] = (byte)(SecCodeSeeds[SecCodeCount % 3] + SecCodeInc);
            SecCodeSeeds[SecCodeCount % 3] = (byte)(SecCodeSeeds[SecCodeCount % 3] % 92);
            i = SecCodeSeeds[0] + SecCodeSeeds[1] * SecCodeSeeds[2] - SecCodeSeeds[1];
            i = Math.Abs(i);
            i = i % 92;

            byte[] SecCode = new byte[4];
            SecCode[0] = (byte)(SecCodeSeeds[0] + 33);
            SecCode[1] = (byte)(SecCodeSeeds[1] + 33);
            SecCode[2] = (byte)(SecCodeSeeds[2] + 33);
            SecCode[3] = (byte)(i + 33);
            return SecCode;
        }
        private static void decodeUserInfoResponse(byte[] Packet)
        {
            SecCodeSeeds[0] = (byte)(Packet[1] - 33);
            SecCodeSeeds[1] = (byte)(Packet[2] - 33);
            SecCodeSeeds[2] = (byte)(Packet[3] - 33);
            SecCodeInc = Packet[4] - 33;

            if (Packet[4] == 'A')
            {
                IsAdmin = true;
                IsMod = true;
            }
            else if (Packet[4] == 'M')
            {
                IsMod = true;
            }

        }


        private string loginEncrypt(string text)
        {
            Random rng = new Random();
            string ROTPOOL = "bl7Jgk61IZdnY mfDN5zjM2XLqTCty4WSEoKR3BFVQsaUhHOAx0rPwp9uc8iGve";
            string POSPOOL = "DQc3uxiGsKZatMmOS5qYveN71zoPTk8yU0H2w9VjprBXWn l4FJd6IRbhgACfEL";
            while (text.Length < 10)
            {
                text += " ";
            }
            while (text.Length < 16)
            {
                text = " " + text;
            }
            if (text.Length > 16)
            {
                text = text.Substring(0, 16);
            }
            string crypt = "";
            int i = 0;
            while (i < text.Length)
            {
                int pos = ROTPOOL.IndexOf(text[i]);
                int rot = rng.Next(0, ROTPOOL.Length);
                pos = pos + (rot + i);
                while (pos >= ROTPOOL.Length)
                {
                    pos = pos - ROTPOOL.Length;
                }
                crypt = crypt + ROTPOOL[rot];
                crypt = crypt + POSPOOL[pos];
                i++;
            }
            return crypt;

        }
        public static bool hasUserInfoResponse(byte[] FullPacket)
        {

   
            List<byte[]> result = getAllResponses(FullPacket);

            foreach (byte[] Packet in result)
            {
                if (Packet[0] == PACKET_USERINFO)
                {
                    decodeUserInfoResponse(Packet);
                    return true;
                }
            }
            return false;

        }

        private static List<byte[]> getAllResponses(byte[] AllPacketData)
        {
            byte split = 0x00;
            List<byte[]> result = new List<byte[]>();
            int start = 0;

            for (int i = 0; i < AllPacketData.Length; i++)
            {
                if (AllPacketData[i] == split && i != 0)
                {
                    byte[] _in = new byte[i - start];
                    Array.Copy(AllPacketData, start, _in, 0, i - start);
                    result.Add(_in);
                    start = i + 1;
                }
                else if (AllPacketData[i] == split && i == 0)
                {
                    start = i + 1;
                }
                else if (AllPacketData.Length - 1 == i && i != start)
                {
                    byte[] _in = new byte[i - start + 1];
                    Array.Copy(AllPacketData, start, _in, 0, i - start + 1);
                    result.Add(_in);
                }

            }
            return result;
        }
        private byte[] generateLoginRequest(string username, string password)
        {
            MemoryStream ms = new MemoryStream();
            ms.WriteByte(0x7F);
            string versionNumber = "91";
            string encryptedUsername = loginEncrypt(username);
            string encryptedPassword = loginEncrypt(password);
            writeString(ms, versionNumber + "|" + encryptedUsername + "|" + encryptedPassword + "|\n");
            ms.Seek(0x00, SeekOrigin.Begin);
            byte[] requestData = ms.ToArray();
            ms.Dispose();
            return requestData;
        }

        private void giveMoneyRequest(Socket hi1Server, int amount)
        {
            byte[] SecCode = generateSecCode();
            byte[] idStr = Encoding.ASCII.GetBytes(amount.ToString());

            byte[] ByteArray = new byte[] { 0x18, 0x1E, SecCode[0], SecCode[1], SecCode[2], SecCode[3] };

            MemoryStream ms = new MemoryStream();
            ms.Write(ByteArray, 0x00, ByteArray.Length);
            ms.Write(idStr, 0x00, idStr.Length);
            ms.WriteByte(0x0a);
            ms.WriteByte(0x00);
            ms.Seek(0x00, SeekOrigin.Begin);

            byte[] packetData = ms.ToArray();

            connectionOuput.AppendText("Sending money request.\r\n"+BitConverter.ToString(packetData).Replace("-"," ")+"\r\n");

            hi1Server.Send(packetData);
        }

        private void giveQuest(Socket hi1Server, int questId)
        {
            byte[] SecCode = generateSecCode();
            byte[] idStr = Encoding.ASCII.GetBytes(questId.ToString());

            byte[] ByteArray = new byte[] { 0x18, 0x32, SecCode[0], SecCode[1], SecCode[2], SecCode[3] };

            MemoryStream ms = new MemoryStream();
            ms.Write(ByteArray, 0x00, ByteArray.Length);
            ms.Write(idStr, 0x00, idStr.Length);
            ms.WriteByte(0x0a);
            ms.WriteByte(0x00);
            ms.Seek(0x00, SeekOrigin.Begin);

            byte[] packetData = ms.ToArray();

            hi1Server.Send(packetData);
        }


        private void giveItemRequest(Socket hi1Server, string itemId)
        {
            byte[] SecCode = generateSecCode();
            byte[] idStr = Encoding.ASCII.GetBytes(Convert.ToInt32(itemId).ToString());
            MemoryStream ms = new MemoryStream();

            byte[] ByteArray = new byte[] { 0x18, 0x28, SecCode[0], SecCode[1], SecCode[2], SecCode[3] };

            ms.Write(ByteArray, 0x00, ByteArray.Length);
            ms.Write(idStr, 0x00, idStr.Length);
            ms.WriteByte(0x0a);
            ms.WriteByte(0x00);
            ms.Seek(0x00, SeekOrigin.Begin);

            connectionOuput.AppendText("Sending item request.\r\n");
            hi1Server.Send(ms.ToArray());
            ms.Dispose();
        }

        private void printChat()
        {
            bool do_loop = true;
            while (do_loop)
            {
                byte[] resp = waitForResponse(HI1GameServer);
                List<byte[]> result = getAllResponses(resp);

                foreach (byte[] Packet in result)
                {
                    if (Packet[0] == PACKET_CHAT)
                    {
                        if (Packet[1] == CHAT_RESP_BRIGHT)
                        {
                            if(Packet.Length - 3 <= 0)
                            {
                                do_loop = false;
                                break;
                            }
                            string ChatMsg = Encoding.UTF8.GetString(Packet).Substring(2, Packet.Length - 3);
                            connectionOuput.AppendText(ChatMsg + "\r\n");
                            do_loop = false;
                            break;
                        }
                    }
                }
            }
        }

        private void BruteForceQuestId()
        {
            int questId = 0;
            while(true)
            {
                giveQuest(HI1GameServer,questId);
                connectionOuput.AppendText(questId.ToString()+" - ");
                printChat();
                questId++;
            }
        }

        private void hackItNow_Click(object sender, EventArgs e)
        {
            // Add items
           // BruteForceQuestId();

            ObjectCollection itemList = addItems.Items;
            int itemCount = itemList.Count;

            hackProgress.Maximum = itemCount;
            hackProgress.Value = 0;

/*            if(moneyCount.Value != 0)
            {
                giveMoneyRequest(HI1GameServer, (int)moneyCount.Value);
                printChat();
            }
*/
            while (itemCount != 0)
            {
                string item = addItems.Items[0].ToString();
                string itemId = item.Split(':')[0];
                giveItemRequest(HI1GameServer, itemId);

                printChat();

                addItems.Items.RemoveAt(0);
                itemCount = addItems.Items.Count;
                hackProgress.Increment(1);
            }

            hackItNow.Enabled = true;

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string server = serverEntry.Text;
            UInt16 port = Convert.ToUInt16(portEntry.Value);
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            if (username == "")
            {
                return;
            }
            if (password == "")
            {
                return;
            }

            // Inital handshake
            Socket hi1Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            hi1Server.Connect(server, port);
            connectionOuput.AppendText("Connected to: " + hi1Server.RemoteEndPoint + "\r\n");
            connectionOuput.AppendText("Sending policy file request...\r\n");
            connectionOuput.AppendText("Server responded!\r\n");
            hi1Server.Close();

            // Now actually log in

            HI1GameServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            HI1GameServer.Connect(server, port);
            connectionOuput.AppendText("Connected to: " + HI1GameServer.RemoteEndPoint + "\r\n");
            connectionOuput.AppendText("Generating login request!\r\n");
            sendData(HI1GameServer, generateLoginRequest(username, password));

            byte[] resp = waitForResponse(HI1GameServer);
            if (resp[1] != LOGIN_SUCCESS)
            {
                connectionOuput.AppendText("Login failed!!\r\n");
                HI1GameServer.Close();
                return;
            }
            else
            {
                connectionOuput.AppendText("Login success!\r\n");
                connectionOuput.AppendText("Waiting for sec codes.\r\n");

                // Request account info.
                sendData(HI1GameServer, new byte[] { PACKET_LOGIN, 0x0a });
                while (true)
                {
                    resp = waitForResponse(HI1GameServer);
                    if (hasUserInfoResponse(resp))
                    {
                        break;
                    }
                }

                connectionOuput.AppendText("Sec Code Seed: " + BitConverter.ToString(SecCodeSeeds) + "\r\n");
                connectionOuput.AppendText("Sec Code Incrementer: " + SecCodeInc + "\r\n");

                loginButton.Enabled = false;
                hackItNow.Enabled = true;
                return;
            }

        }
    }
}
