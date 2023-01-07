namespace Lister
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputbox = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.chatbox = new System.Windows.Forms.RichTextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.groupName = new System.Windows.Forms.TextBox();
            this.sendToGroup = new System.Windows.Forms.Button();
            this.joinGroup = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.ListBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.privateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chats = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chats)).BeginInit();
            this.SuspendLayout();
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(234, 372);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(191, 66);
            this.inputbox.TabIndex = 1;
            this.inputbox.Text = "";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(441, 372);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(37, 34);
            this.send.TabIndex = 2;
            this.send.Text = "→";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // chatbox
            // 
            this.chatbox.Location = new System.Drawing.Point(234, 40);
            this.chatbox.Name = "chatbox";
            this.chatbox.Size = new System.Drawing.Size(191, 312);
            this.chatbox.TabIndex = 3;
            this.chatbox.Text = "";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(659, 12);
            this.username.Name = "username";
            this.username.PlaceholderText = "Enter your username";
            this.username.Size = new System.Drawing.Size(124, 23);
            this.username.TabIndex = 4;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(578, 11);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 5;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(659, 40);
            this.groupName.Name = "groupName";
            this.groupName.PlaceholderText = "Group name";
            this.groupName.Size = new System.Drawing.Size(124, 23);
            this.groupName.TabIndex = 6;
            this.groupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sendToGroup
            // 
            this.sendToGroup.Location = new System.Drawing.Point(441, 305);
            this.sendToGroup.Name = "sendToGroup";
            this.sendToGroup.Size = new System.Drawing.Size(37, 34);
            this.sendToGroup.TabIndex = 8;
            this.sendToGroup.Text = "→";
            this.sendToGroup.UseVisualStyleBackColor = true;
            this.sendToGroup.Click += new System.EventHandler(this.sendToGroup_Click);
            // 
            // joinGroup
            // 
            this.joinGroup.Location = new System.Drawing.Point(578, 40);
            this.joinGroup.Name = "joinGroup";
            this.joinGroup.Size = new System.Drawing.Size(75, 23);
            this.joinGroup.TabIndex = 9;
            this.joinGroup.Text = "create";
            this.joinGroup.UseVisualStyleBackColor = true;
            this.joinGroup.Click += new System.EventHandler(this.joinGroup_Click);
            // 
            // users
            // 
            this.users.FormattingEnabled = true;
            this.users.ItemHeight = 15;
            this.users.Items.AddRange(new object[] {
            "qwe",
            "ewq"});
            this.users.Location = new System.Drawing.Point(76, 40);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(71, 124);
            this.users.TabIndex = 10;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privateToolStripMenuItem,
            this.groupsToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(60, 450);
            this.menu.TabIndex = 13;
            this.menu.Text = "menu";
            // 
            // privateToolStripMenuItem
            // 
            this.privateToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.privateToolStripMenuItem.Name = "privateToolStripMenuItem";
            this.privateToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.privateToolStripMenuItem.Text = "Private";
            this.privateToolStripMenuItem.Click += new System.EventHandler(this.privateChats_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.Groups_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(87, 150);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(533, 105);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // chats
            // 
            this.chats.AllowUserToOrderColumns = true;
            this.chats.AutoGenerateColumns = false;
            this.chats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chats.DataSource = this.users.CustomTabOffsets;
            this.chats.ImeMode = System.Windows.Forms.ImeMode.On;
            this.chats.Location = new System.Drawing.Point(44, 184);
            this.chats.Name = "chats";
            this.chats.RowTemplate.Height = 25;
            this.chats.Size = new System.Drawing.Size(167, 168);
            this.chats.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chats);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.users);
            this.Controls.Add(this.joinGroup);
            this.Controls.Add(this.sendToGroup);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.login);
            this.Controls.Add(this.username);
            this.Controls.Add(this.chatbox);
            this.Controls.Add(this.send);
            this.Controls.Add(this.inputbox);
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.Text = "Lister";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox inputbox;
        private Button send;
        private RichTextBox chatbox;
        private TextBox username;
        private Button login;
        private TextBox groupName;
        private Button sendToGroup;
        private Button joinGroup;
        private ListBox users;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private MenuStrip menu;
        private ToolStripMenuItem privateToolStripMenuItem;
        private ToolStripMenuItem groupsToolStripMenuItem;
        private ToolStripContentPanel ContentPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView chats;
    }
}