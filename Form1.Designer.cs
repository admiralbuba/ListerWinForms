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
            this.SuspendLayout();
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(16, 372);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(310, 66);
            this.inputbox.TabIndex = 1;
            this.inputbox.Text = "";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(341, 372);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(37, 34);
            this.send.TabIndex = 2;
            this.send.Text = "→";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // chatbox
            // 
            this.chatbox.Location = new System.Drawing.Point(16, 12);
            this.chatbox.Name = "chatbox";
            this.chatbox.Size = new System.Drawing.Size(310, 340);
            this.chatbox.TabIndex = 3;
            this.chatbox.Text = "";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(688, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 23);
            this.username.TabIndex = 4;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(688, 41);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 5;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            this.login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.login_MouseClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}