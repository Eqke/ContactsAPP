using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
namespace ContactAppUI
{
    public partial class ContactForm : Form
    {
        private Contact _currentContact;
        
        public ContactForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свойства CurrentContact
        /// </summary>
        public Contact CurrentContact
        {
            set { this._currentContact = value; }
            get { return _currentContact; }
        }

        /// <summary>
        /// Метод, описывающий реакцию на нажатие кнопки cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelEditorFormButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Метод, описывающий реакцию на нажатие кнопки ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okEditorFormButton_Click(object sender, EventArgs e)
        {
            if (SurnameTextBox.Text != "" && SurnameTextBox.BackColor != Color.Red
                && NameTextBox.Text != "" && NameTextBox.BackColor != Color.Red
                && BirthdayErrorLabel.Text == "" && EmailTextBox.Text != "" && EmailTextBox.BackColor != Color.Red
                && VkIDTextBox.Text != "" && PhoneMaskedTextBox.Text.Length == 16)
            {
                var correctedNumber = PhoneFilter(PhoneMaskedTextBox.Text);
                this._currentContact = new Contact(SurnameTextBox.Text, NameTextBox.Text,
                    BirthdayTimePicker.Value, EmailTextBox.Text, new PhoneNumber(correctedNumber), VkIDTextBox.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("There were errors in filling in the fields, correct them.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditorForm_Load(object sender, EventArgs e)
        {
            if (_currentContact == null)
            {
                _currentContact = new Contact();
            }
            else
            {
                this.NameTextBox.Text = _currentContact.Name;
                this.SurnameTextBox.Text = _currentContact.Surname;
                this.PhoneMaskedTextBox.Text = _currentContact.PhoneNumber.Number.Substring(1,10);
                this.BirthdayTimePicker.Value = _currentContact.BirthDay;
                this.EmailTextBox.Text = _currentContact.Email;
                this.VkIDTextBox.Text = _currentContact.VkID;
            }
        }

        /// <summary>
        /// Метод, проверяющий коорректность введенной фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(SurnameTextBox.Text, "[^a-zа-яA-ZА-Я]"))
            {
                SurnameTextBox.BackColor = Color.Red;
            }
            else
            {
                SurnameTextBox.BackColor = Color.White;
            }

        }

        /// <summary>
        /// Метод, проверяющий коорректность введеннго имени 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(NameTextBox.Text, "[^a-zа-яA-ZА-Я]"))
            {
                NameTextBox.BackColor = Color.Red;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Метод, проверяющий корректноость введенной даты рождения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void birthdayTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (BirthdayTimePicker.Value.Year < 1900 || BirthdayTimePicker.Value >= DateTime.Today)
            {
                BirthdayErrorLabel.Text = "Error: Incorrected Date";
            }
            else
            {
                BirthdayErrorLabel.Text = "";
            }
        }

        /// <summary>
        /// Метод проверяющий корректность вводимой электронной почты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(EmailTextBox.Text, "[@]"))
            {
                EmailTextBox.BackColor = Color.Red;
            }
            else
            {
                EmailTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Метод, преобразующий из строки maskedtextbox в номер, без символов 
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        private string PhoneFilter(string phoneNumber)
        {
            var count = phoneNumber.Length;
            string correctedPhoneNumber = phoneNumber.Substring(1, 1) 
                                          + phoneNumber.Substring(3, 3) 
                                          + phoneNumber.Substring(8, 3) 
                                          + phoneNumber.Substring(12, 4);
            return correctedPhoneNumber;
        }

    }
}
