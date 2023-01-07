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
            this.joinGroup = new System.Windows.Forms.Button();
            this.chats = new System.Windows.Forms.ListBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.SuspendLayout();
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(205, 372);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(220, 66);
            this.inputbox.TabIndex = 1;
            this.inputbox.Text = "";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(431, 372);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(37, 34);
            this.send.TabIndex = 2;
            this.send.Text = "→";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // chatbox
            // 
            this.chatbox.HideSelection = false;
            this.chatbox.Location = new System.Drawing.Point(205, 12);
            this.chatbox.Name = "chatbox";
            this.chatbox.Size = new System.Drawing.Size(220, 312);
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
            // joinGroup
            // 
            this.joinGroup.Location = new System.Drawing.Point(578, 40);
            this.joinGroup.Name = "joinGroup";
            this.joinGroup.Size = new System.Drawing.Size(75, 23);
            this.joinGroup.TabIndex = 9;
            this.joinGroup.Text = "join";
            this.joinGroup.UseVisualStyleBackColor = true;
            this.joinGroup.Click += new System.EventHandler(this.joinGroup_Click);
            // 
            // chats
            // 
            this.chats.FormattingEnabled = true;
            this.chats.ItemHeight = 15;
            this.chats.Location = new System.Drawing.Point(12, 12);
            this.chats.Name = "chats";
            this.chats.Size = new System.Drawing.Size(71, 124);
            this.chats.TabIndex = 10;
            this.chats.SelectedIndexChanged += new System.EventHandler(this.chats_SelectedIndexChanged);
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
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(87, 150);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chats);
            this.Controls.Add(this.joinGroup);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.login);
            this.Controls.Add(this.username);
            this.Controls.Add(this.chatbox);
            this.Controls.Add(this.send);
            this.Controls.Add(this.inputbox);
            this.Name = "Main";
            this.Text = "Lister";
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
        private Button joinGroup;
        private ListBox chats;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
    }
}