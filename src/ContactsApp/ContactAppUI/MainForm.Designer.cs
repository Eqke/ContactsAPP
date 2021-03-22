

using System.Reflection;

namespace ContactAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contactUIPanel = new System.Windows.Forms.Panel();
            this.operationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.editContactButton = new System.Windows.Forms.Button();
            this.deleteContactButton = new System.Windows.Forms.Button();
            this.addContactButton = new System.Windows.Forms.Button();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vkIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.vkIDLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.TodayPictureBox = new System.Windows.Forms.PictureBox();
            this.TodayBirthdayLabel = new System.Windows.Forms.Label();
            this.contactUIPanel.SuspendLayout();
            this.operationLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contactUIPanel
            // 
            this.contactUIPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contactUIPanel.Controls.Add(this.operationLayoutPanel);
            this.contactUIPanel.Controls.Add(this.contactsListBox);
            this.contactUIPanel.Controls.Add(this.findTextBox);
            this.contactUIPanel.Controls.Add(this.findLabel);
            this.contactUIPanel.Location = new System.Drawing.Point(0, 31);
            this.contactUIPanel.Name = "contactUIPanel";
            this.contactUIPanel.Size = new System.Drawing.Size(222, 431);
            this.contactUIPanel.TabIndex = 1;
            // 
            // operationLayoutPanel
            // 
            this.operationLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationLayoutPanel.ColumnCount = 3;
            this.operationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.operationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.operationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.operationLayoutPanel.Controls.Add(this.editContactButton, 1, 0);
            this.operationLayoutPanel.Controls.Add(this.deleteContactButton, 2, 0);
            this.operationLayoutPanel.Controls.Add(this.addContactButton, 0, 0);
            this.operationLayoutPanel.Location = new System.Drawing.Point(6, 393);
            this.operationLayoutPanel.Name = "operationLayoutPanel";
            this.operationLayoutPanel.RowCount = 1;
            this.operationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.operationLayoutPanel.Size = new System.Drawing.Size(92, 35);
            this.operationLayoutPanel.TabIndex = 2;
            // 
            // editContactButton
            // 
            this.editContactButton.FlatAppearance.BorderSize = 0;
            this.editContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.editContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.editContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editContactButton.Image = global::ContactAppUI.Properties.Resources.edit;
            this.editContactButton.Location = new System.Drawing.Point(33, 3);
            this.editContactButton.Name = "editContactButton";
            this.editContactButton.Size = new System.Drawing.Size(24, 24);
            this.editContactButton.TabIndex = 4;
            this.editContactButton.UseVisualStyleBackColor = true;
            this.editContactButton.Click += new System.EventHandler(this.editContactButton_Click);
            // 
            // deleteContactButton
            // 
            this.deleteContactButton.FlatAppearance.BorderSize = 0;
            this.deleteContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.deleteContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.deleteContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteContactButton.Image = global::ContactAppUI.Properties.Resources.delete;
            this.deleteContactButton.Location = new System.Drawing.Point(63, 3);
            this.deleteContactButton.Name = "deleteContactButton";
            this.deleteContactButton.Size = new System.Drawing.Size(24, 24);
            this.deleteContactButton.TabIndex = 5;
            this.deleteContactButton.UseVisualStyleBackColor = true;
            this.deleteContactButton.Click += new System.EventHandler(this.deleteContactButton_Click);
            // 
            // addContactButton
            // 
            this.addContactButton.BackColor = System.Drawing.SystemColors.Control;
            this.addContactButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addContactButton.FlatAppearance.BorderSize = 0;
            this.addContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.addContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addContactButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addContactButton.Image = global::ContactAppUI.Properties.Resources.AddContact;
            this.addContactButton.Location = new System.Drawing.Point(3, 3);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(24, 24);
            this.addContactButton.TabIndex = 3;
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // contactsListBox
            // 
            this.contactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.Location = new System.Drawing.Point(6, 35);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.ScrollAlwaysVisible = true;
            this.contactsListBox.Size = new System.Drawing.Size(202, 355);
            this.contactsListBox.TabIndex = 2;
            this.contactsListBox.SelectedIndexChanged += new System.EventHandler(this.contactsListBox_SelectedIndexChanged);
            this.contactsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contactsListBox_KeyDown);
            // 
            // findTextBox
            // 
            this.findTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findTextBox.Location = new System.Drawing.Point(39, 6);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(168, 20);
            this.findTextBox.TabIndex = 1;
            this.findTextBox.TextChanged += new System.EventHandler(this.findTextBox_TextChanged);
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findLabel.Location = new System.Drawing.Point(3, 8);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(31, 15);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Find";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.vkIDTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.vkIDLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.surnameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.emailLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.phoneNumberLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.birthdayLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.surnameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.emailTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.birthdayTimePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.phoneMaskedTextBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(228, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 204);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // vkIDTextBox
            // 
            this.vkIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.vkIDTextBox.Location = new System.Drawing.Point(69, 174);
            this.vkIDTextBox.Name = "vkIDTextBox";
            this.vkIDTextBox.ReadOnly = true;
            this.vkIDTextBox.Size = new System.Drawing.Size(472, 20);
            this.vkIDTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(69, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(472, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // vkIDLabel
            // 
            this.vkIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.vkIDLabel.AutoSize = true;
            this.vkIDLabel.Location = new System.Drawing.Point(18, 178);
            this.vkIDLabel.Name = "vkIDLabel";
            this.vkIDLabel.Size = new System.Drawing.Size(45, 13);
            this.vkIDLabel.TabIndex = 7;
            this.vkIDLabel.Text = "vk.com:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameTextBox.Location = new System.Drawing.Point(69, 6);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(472, 20);
            this.surnameTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(28, 142);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(22, 109);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneNumberLabel.TabIndex = 7;
            this.phoneNumberLabel.Text = "Phone:";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(15, 76);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(48, 13);
            this.birthdayLabel.TabIndex = 6;
            this.birthdayLabel.Text = "Birthday:";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(25, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(11, 10);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(52, 13);
            this.surnameLabel.TabIndex = 5;
            this.surnameLabel.Text = "Surname:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Location = new System.Drawing.Point(69, 138);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(472, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // birthdayTimePicker
            // 
            this.birthdayTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.birthdayTimePicker.Enabled = false;
            this.birthdayTimePicker.Location = new System.Drawing.Point(69, 72);
            this.birthdayTimePicker.Name = "birthdayTimePicker";
            this.birthdayTimePicker.Size = new System.Drawing.Size(131, 20);
            this.birthdayTimePicker.TabIndex = 10;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.AllowDrop = true;
            this.phoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(69, 105);
            this.phoneMaskedTextBox.Mask = "+7(000) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.ReadOnly = true;
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(472, 20);
            this.phoneMaskedTextBox.TabIndex = 11;
            this.phoneMaskedTextBox.Text = "0000000000";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add Contact";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete Contact";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.Controls.Add(this.TodayPictureBox);
            this.BirthdayPanel.Controls.Add(this.TodayBirthdayLabel);
            this.BirthdayPanel.Location = new System.Drawing.Point(228, 241);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(544, 100);
            this.BirthdayPanel.TabIndex = 5;
            // 
            // TodayPictureBox
            // 
            this.TodayPictureBox.Image = global::ContactAppUI.Properties.Resources.Happy_Birthday;
            this.TodayPictureBox.InitialImage = global::ContactAppUI.Properties.Resources.Happy_Birthday;
            this.TodayPictureBox.Location = new System.Drawing.Point(13, 10);
            this.TodayPictureBox.Name = "TodayPictureBox";
            this.TodayPictureBox.Size = new System.Drawing.Size(64, 63);
            this.TodayPictureBox.TabIndex = 1;
            this.TodayPictureBox.TabStop = false;
            // 
            // TodayBirthdayLabel
            // 
            this.TodayBirthdayLabel.AutoSize = true;
            this.TodayBirthdayLabel.Location = new System.Drawing.Point(83, 10);
            this.TodayBirthdayLabel.Name = "TodayBirthdayLabel";
            this.TodayBirthdayLabel.Size = new System.Drawing.Size(0, 13);
            this.TodayBirthdayLabel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.BirthdayPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.contactUIPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "Contacts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contactUIPanel.ResumeLayout(false);
            this.contactUIPanel.PerformLayout();
            this.operationLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodayPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contactUIPanel;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.ListBox contactsListBox;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Button editContactButton;
        private System.Windows.Forms.Button deleteContactButton;
        private System.Windows.Forms.TableLayoutPanel operationLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label vkIDLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox vkIDTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker birthdayTimePicker;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.Label TodayBirthdayLabel;
        private System.Windows.Forms.PictureBox TodayPictureBox;
    }
}

