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
            this.joinGroup = new System.Windows.Forms.Button();
            this.chats = new System.Windows.Forms.ListBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.saved = new System.Windows.Forms.Button();
            this.allChatsLabel = new System.Windows.Forms.Label();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.connectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.connect = new System.Windows.Forms.Button();
            this.statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(236, 222);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(220, 66);
            this.inputbox.TabIndex = 1;
            this.inputbox.Text = "";
            this.inputbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputbox_KeyPress);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(186, 253);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(35, 35);
            this.send.TabIndex = 2;
            this.send.Text = "→";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // chatbox
            // 
            this.chatbox.HideSelection = false;
            this.chatbox.Location = new System.Drawing.Point(236, 35);
            this.chatbox.Name = "chatbox";
            this.chatbox.ReadOnly = true;
            this.chatbox.Size = new System.Drawing.Size(220, 158);
            this.chatbox.TabIndex = 3;
            this.chatbox.Text = "";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(12, 35);
            this.username.Name = "username";
            this.username.PlaceholderText = "Enter your username";
            this.username.Size = new System.Drawing.Size(120, 23);
            this.username.TabIndex = 4;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(12, 64);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(120, 23);
            this.login.TabIndex = 5;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // joinGroup
            // 
            this.joinGroup.Location = new System.Drawing.Point(12, 124);
            this.joinGroup.Name = "joinGroup";
            this.joinGroup.Size = new System.Drawing.Size(120, 23);
            this.joinGroup.TabIndex = 9;
            this.joinGroup.Text = "new group";
            this.joinGroup.UseVisualStyleBackColor = true;
            this.joinGroup.Click += new System.EventHandler(this.joinGroup_Click);
            // 
            // chats
            // 
            this.chats.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chats.ItemHeight = 17;
            this.chats.Location = new System.Drawing.Point(150, 58);
            this.chats.Name = "chats";
            this.chats.Size = new System.Drawing.Size(71, 89);
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
            // saved
            // 
            this.saved.AutoSize = true;
            this.saved.Location = new System.Drawing.Point(12, 93);
            this.saved.Name = "saved";
            this.saved.Size = new System.Drawing.Size(120, 25);
            this.saved.TabIndex = 11;
            this.saved.Text = "service messages";
            this.saved.UseVisualStyleBackColor = true;
            this.saved.Click += new System.EventHandler(this.saved_Click);
            // 
            // allChatsLabel
            // 
            this.allChatsLabel.Location = new System.Drawing.Point(150, 33);
            this.allChatsLabel.Name = "allChatsLabel";
            this.allChatsLabel.Size = new System.Drawing.Size(71, 25);
            this.allChatsLabel.TabIndex = 12;
            this.allChatsLabel.Text = "all chats";
            this.allChatsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatus,
            this.statusImage});
            this.statusbar.Location = new System.Drawing.Point(0, 291);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(474, 22);
            this.statusbar.TabIndex = 14;
            // 
            // connectionStatus
            // 
            this.connectionStatus.ActiveLinkColor = System.Drawing.Color.White;
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // statusImage
            // 
            this.statusImage.Name = "statusImage";
            this.statusImage.Size = new System.Drawing.Size(0, 17);
            // 
            // connect
            // 
            this.connect.BackgroundImage = global::Lister.Properties.Resources.wswitch;
            this.connect.Location = new System.Drawing.Point(12, 253);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(35, 35);
            this.connect.TabIndex = 15;
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 313);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.allChatsLabel);
            this.Controls.Add(this.saved);
            this.Controls.Add(this.chats);
            this.Controls.Add(this.joinGroup);
            this.Controls.Add(this.login);
            this.Controls.Add(this.username);
            this.Controls.Add(this.chatbox);
            this.Controls.Add(this.send);
            this.Controls.Add(this.inputbox);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lister";
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox inputbox;
        private Button send;
        private RichTextBox chatbox;
        private TextBox username;
        private Button login;
        private Button joinGroup;
        private ListBox chats;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private Button saved;
        private Label allChatsLabel;
        private StatusStrip statusbar;
        private ToolStripStatusLabel connectionStatus;
        private Button connect;
        private ToolStripStatusLabel statusImage;
    }
}