namespace Lister.Forms
{
    partial class GroupMembers
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
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(31, 112);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(124, 112);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 1;
            this.create.Text = "create";
            this.create.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // users
            // 
            this.users.CheckOnClick = true;
            this.users.FormattingEnabled = true;
            this.users.Items.AddRange(new object[] {
            "qwe",
            "ewq",
            "Katy",
            "Dua"});
            this.users.Location = new System.Drawing.Point(54, 12);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(120, 94);
            this.users.TabIndex = 2;
            // 
            // GroupMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(251, 165);
            this.Controls.Add(this.users);
            this.Controls.Add(this.create);
            this.Controls.Add(this.cancel);
            this.Name = "GroupMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GroupMembers";
            this.ResumeLayout(false);

        }

        #endregion

        private Button cancel;
        private Button create;
        private CheckedListBox users;
    }
}