namespace Horse_Isle_Hack_Tool
{
    partial class hi1HackTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hackItNow = new System.Windows.Forms.Button();
            this.connectionOuput = new System.Windows.Forms.TextBox();
            this.serverEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameEntry = new System.Windows.Forms.TextBox();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addItems = new System.Windows.Forms.ListBox();
            this.itemList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.NumericUpDown();
            this.hackProgress = new System.Windows.Forms.ProgressBar();
            this.removeSelected = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.portEntry = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // hackItNow
            // 
            this.hackItNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hackItNow.Enabled = false;
            this.hackItNow.Location = new System.Drawing.Point(12, 689);
            this.hackItNow.Name = "hackItNow";
            this.hackItNow.Size = new System.Drawing.Size(907, 23);
            this.hackItNow.TabIndex = 0;
            this.hackItNow.Text = "Hack Horse Isle :3";
            this.hackItNow.UseVisualStyleBackColor = true;
            this.hackItNow.Click += new System.EventHandler(this.hackItNow_Click);
            // 
            // connectionOuput
            // 
            this.connectionOuput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionOuput.Location = new System.Drawing.Point(12, 524);
            this.connectionOuput.Multiline = true;
            this.connectionOuput.Name = "connectionOuput";
            this.connectionOuput.Size = new System.Drawing.Size(907, 125);
            this.connectionOuput.TabIndex = 1;
            // 
            // serverEntry
            // 
            this.serverEntry.Location = new System.Drawing.Point(59, 12);
            this.serverEntry.Name = "serverEntry";
            this.serverEntry.Size = new System.Drawing.Size(114, 20);
            this.serverEntry.TabIndex = 2;
            this.serverEntry.Text = "pintoip.horseisle.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // usernameEntry
            // 
            this.usernameEntry.Location = new System.Drawing.Point(388, 12);
            this.usernameEntry.Name = "usernameEntry";
            this.usernameEntry.Size = new System.Drawing.Size(133, 20);
            this.usernameEntry.TabIndex = 5;
            // 
            // passwordEntry
            // 
            this.passwordEntry.Location = new System.Drawing.Point(589, 12);
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.PasswordChar = '*';
            this.passwordEntry.Size = new System.Drawing.Size(157, 20);
            this.passwordEntry.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(758, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(ONLY sent to Horse Isle Server.)";
            // 
            // addItems
            // 
            this.addItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItems.FormattingEnabled = true;
            this.addItems.Location = new System.Drawing.Point(12, 91);
            this.addItems.Name = "addItems";
            this.addItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.addItems.Size = new System.Drawing.Size(910, 342);
            this.addItems.TabIndex = 9;
            // 
            // itemList
            // 
            this.itemList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(16, 463);
            this.itemList.MaxDropDownItems = 10;
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(796, 21);
            this.itemList.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Add items:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Item list:";
            // 
            // addItem
            // 
            this.addItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItem.Location = new System.Drawing.Point(12, 495);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(450, 23);
            this.addItem.TabIndex = 14;
            this.addItem.Text = "Add to list of items!";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(818, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Count:";
            // 
            // count
            // 
            this.count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.count.Location = new System.Drawing.Point(862, 464);
            this.count.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(61, 20);
            this.count.TabIndex = 16;
            this.count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hackProgress
            // 
            this.hackProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hackProgress.Location = new System.Drawing.Point(12, 660);
            this.hackProgress.Name = "hackProgress";
            this.hackProgress.Size = new System.Drawing.Size(907, 23);
            this.hackProgress.TabIndex = 17;
            // 
            // removeSelected
            // 
            this.removeSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSelected.Location = new System.Drawing.Point(468, 495);
            this.removeSelected.Name = "removeSelected";
            this.removeSelected.Size = new System.Drawing.Size(451, 23);
            this.removeSelected.TabIndex = 18;
            this.removeSelected.Text = "Remove selected items!";
            this.removeSelected.UseVisualStyleBackColor = true;
            this.removeSelected.Click += new System.EventHandler(this.removeSelected_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(752, 10);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(56, 23);
            this.loginButton.TabIndex = 19;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // portEntry
            // 
            this.portEntry.Location = new System.Drawing.Point(211, 13);
            this.portEntry.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portEntry.Name = "portEntry";
            this.portEntry.Size = new System.Drawing.Size(107, 20);
            this.portEntry.TabIndex = 20;
            this.portEntry.Value = new decimal(new int[] {
            443,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Port:";
            // 
            // hi1HackTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 724);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.portEntry);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.removeSelected);
            this.Controls.Add(this.hackProgress);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.addItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.usernameEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverEntry);
            this.Controls.Add(this.connectionOuput);
            this.Controls.Add(this.hackItNow);
            this.Name = "hi1HackTool";
            this.Text = "Horse Isle Hack T00L";
            this.Load += new System.EventHandler(this.hi1HackTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hackItNow;
        private System.Windows.Forms.TextBox connectionOuput;
        private System.Windows.Forms.TextBox serverEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameEntry;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox addItems;
        private System.Windows.Forms.ComboBox itemList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown count;
        private System.Windows.Forms.ProgressBar hackProgress;
        private System.Windows.Forms.Button removeSelected;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.NumericUpDown portEntry;
        private System.Windows.Forms.Label label8;
    }
}

