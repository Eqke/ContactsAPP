
namespace ContactAppUI
{
    partial class AboutForm
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
            this.ContactsAppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContactsAppLabel
            // 
            this.ContactsAppLabel.AutoSize = true;
            this.ContactsAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsAppLabel.Location = new System.Drawing.Point(12, 9);
            this.ContactsAppLabel.Name = "ContactsAppLabel";
            this.ContactsAppLabel.Size = new System.Drawing.Size(149, 29);
            this.ContactsAppLabel.TabIndex = 0;
            this.ContactsAppLabel.Text = "ContactsApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(14, 38);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(43, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(14, 74);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(85, 13);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author : KoCorp.";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(14, 111);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(98, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email for feedback:";
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.Location = new System.Drawing.Point(109, 111);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(120, 13);
            this.EmailLinkLabel.TabIndex = 4;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "KrazyToinik@gmail.com";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Location = new System.Drawing.Point(14, 128);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(43, 13);
            this.GitHubLabel.TabIndex = 5;
            this.GitHubLabel.Text = "GitHub:";
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(53, 128);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(98, 13);
            this.GitHubLinkLabel.TabIndex = 6;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "Eqke/ContactsApp";
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(13, 236);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(119, 13);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "2021 Vasiliy Kozlyuk (C)";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.EmailLinkLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ContactsAppLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContactsAppLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.Label InfoLabel;
    }
}