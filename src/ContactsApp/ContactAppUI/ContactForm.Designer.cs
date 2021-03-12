
namespace ContactAppUI
{
    partial class ContactForm
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
            this.EditorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.VkIDTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.VkIDLabel = new System.Windows.Forms.Label();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.BirthdayErrorLabel = new System.Windows.Forms.Label();
            this.BirthdayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CancelEditorFormButton = new System.Windows.Forms.Button();
            this.OkEditorFormButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EditorTableLayoutPanel.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorTableLayoutPanel
            // 
            this.EditorTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorTableLayoutPanel.ColumnCount = 2;
            this.EditorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.EditorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditorTableLayoutPanel.Controls.Add(this.VkIDTextBox, 1, 5);
            this.EditorTableLayoutPanel.Controls.Add(this.EmailTextBox, 1, 4);
            this.EditorTableLayoutPanel.Controls.Add(this.PhoneMaskedTextBox, 1, 3);
            this.EditorTableLayoutPanel.Controls.Add(this.NameTextBox, 1, 1);
            this.EditorTableLayoutPanel.Controls.Add(this.SurnameTextBox, 1, 0);
            this.EditorTableLayoutPanel.Controls.Add(this.SurnameLabel, 0, 0);
            this.EditorTableLayoutPanel.Controls.Add(this.NameLabel, 0, 1);
            this.EditorTableLayoutPanel.Controls.Add(this.BirthdayLabel, 0, 2);
            this.EditorTableLayoutPanel.Controls.Add(this.PhoneLabel, 0, 3);
            this.EditorTableLayoutPanel.Controls.Add(this.EmailLabel, 0, 4);
            this.EditorTableLayoutPanel.Controls.Add(this.VkIDLabel, 0, 5);
            this.EditorTableLayoutPanel.Controls.Add(this.BirthdayPanel, 1, 2);
            this.EditorTableLayoutPanel.Location = new System.Drawing.Point(26, 12);
            this.EditorTableLayoutPanel.Name = "EditorTableLayoutPanel";
            this.EditorTableLayoutPanel.RowCount = 6;
            this.EditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.EditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.EditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.EditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.EditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.EditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.EditorTableLayoutPanel.Size = new System.Drawing.Size(534, 206);
            this.EditorTableLayoutPanel.TabIndex = 0;
            // 
            // VkIDTextBox
            // 
            this.VkIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VkIDTextBox.Location = new System.Drawing.Point(63, 178);
            this.VkIDTextBox.MaxLength = 15;
            this.VkIDTextBox.Name = "VkIDTextBox";
            this.VkIDTextBox.Size = new System.Drawing.Size(468, 20);
            this.VkIDTextBox.TabIndex = 14;
            this.VkIDTextBox.UseWaitCursor = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(63, 143);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(468, 20);
            this.EmailTextBox.TabIndex = 13;
            this.EmailTextBox.UseWaitCursor = true;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneMaskedTextBox.BeepOnError = true;
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(63, 109);
            this.PhoneMaskedTextBox.Mask = "+7(000) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(468, 20);
            this.PhoneMaskedTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(63, 41);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(468, 20);
            this.NameTextBox.TabIndex = 8;
            this.NameTextBox.UseWaitCursor = true;
            this.NameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(63, 7);
            this.SurnameTextBox.MaxLength = 50;
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(468, 20);
            this.SurnameTextBox.TabIndex = 7;
            this.SurnameTextBox.UseWaitCursor = true;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.surnameTextBox_TextChanged);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(3, 10);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(54, 13);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Surname:";
            this.SurnameLabel.UseWaitCursor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 44);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            this.NameLabel.UseWaitCursor = true;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(3, 78);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(54, 13);
            this.BirthdayLabel.TabIndex = 2;
            this.BirthdayLabel.Text = "Birthday:";
            this.BirthdayLabel.UseWaitCursor = true;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(3, 112);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(54, 13);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone:";
            this.PhoneLabel.UseWaitCursor = true;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(3, 146);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(54, 13);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email:";
            this.EmailLabel.UseWaitCursor = true;
            // 
            // VkIDLabel
            // 
            this.VkIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VkIDLabel.AutoSize = true;
            this.VkIDLabel.Location = new System.Drawing.Point(3, 181);
            this.VkIDLabel.Name = "VkIDLabel";
            this.VkIDLabel.Size = new System.Drawing.Size(54, 13);
            this.VkIDLabel.TabIndex = 5;
            this.VkIDLabel.Text = "vk.com/";
            this.VkIDLabel.UseWaitCursor = true;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Controls.Add(this.BirthdayErrorLabel);
            this.BirthdayPanel.Controls.Add(this.BirthdayTimePicker);
            this.BirthdayPanel.Location = new System.Drawing.Point(63, 71);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(468, 28);
            this.BirthdayPanel.TabIndex = 15;
            this.BirthdayPanel.UseWaitCursor = true;
            // 
            // BirthdayErrorLabel
            // 
            this.BirthdayErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BirthdayErrorLabel.AutoSize = true;
            this.BirthdayErrorLabel.Location = new System.Drawing.Point(166, 7);
            this.BirthdayErrorLabel.Name = "BirthdayErrorLabel";
            this.BirthdayErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.BirthdayErrorLabel.TabIndex = 12;
            this.BirthdayErrorLabel.UseWaitCursor = true;
            // 
            // BirthdayTimePicker
            // 
            this.BirthdayTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BirthdayTimePicker.Location = new System.Drawing.Point(3, 5);
            this.BirthdayTimePicker.Name = "BirthdayTimePicker";
            this.BirthdayTimePicker.Size = new System.Drawing.Size(153, 20);
            this.BirthdayTimePicker.TabIndex = 11;
            this.BirthdayTimePicker.UseWaitCursor = true;
            this.BirthdayTimePicker.ValueChanged += new System.EventHandler(this.birthdayTimePicker_ValueChanged);
            // 
            // CancelEditorFormButton
            // 
            this.CancelEditorFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelEditorFormButton.Location = new System.Drawing.Point(84, 4);
            this.CancelEditorFormButton.Name = "CancelEditorFormButton";
            this.CancelEditorFormButton.Size = new System.Drawing.Size(72, 23);
            this.CancelEditorFormButton.TabIndex = 0;
            this.CancelEditorFormButton.Text = "Cancel";
            this.CancelEditorFormButton.UseVisualStyleBackColor = true;
            this.CancelEditorFormButton.UseWaitCursor = true;
            this.CancelEditorFormButton.Click += new System.EventHandler(this.cancelEditorFormButton_Click);
            // 
            // OkEditorFormButton
            // 
            this.OkEditorFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OkEditorFormButton.Location = new System.Drawing.Point(3, 4);
            this.OkEditorFormButton.Name = "OkEditorFormButton";
            this.OkEditorFormButton.Size = new System.Drawing.Size(75, 23);
            this.OkEditorFormButton.TabIndex = 1;
            this.OkEditorFormButton.Text = "OK";
            this.OkEditorFormButton.UseVisualStyleBackColor = true;
            this.OkEditorFormButton.UseWaitCursor = true;
            this.OkEditorFormButton.Click += new System.EventHandler(this.okEditorFormButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.36612F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.63388F));
            this.tableLayoutPanel2.Controls.Add(this.OkEditorFormButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CancelEditorFormButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(401, 224);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(159, 32);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.UseWaitCursor = true;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.EditorTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.EditorTableLayoutPanel.ResumeLayout(false);
            this.EditorTableLayoutPanel.PerformLayout();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel EditorTableLayoutPanel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label VkIDLabel;
        private System.Windows.Forms.Button CancelEditorFormButton;
        private System.Windows.Forms.Button OkEditorFormButton;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DateTimePicker BirthdayTimePicker;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox VkIDTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.Label BirthdayErrorLabel;
    }
}