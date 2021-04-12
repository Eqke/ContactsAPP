using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactAppUI
{
    public partial class ContactForm : Form
    {
        /// <summary>
        /// переменная, хранящая цвет ошибку
        /// </summary>
        Color _errorColor = Color.DarkOrange;

        /// <summary>
        /// переменная, хранящая цвет корректного ввода
        /// </summary>
        Color _rightColor = Color.White;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свойства CurrentContact
        /// </summary>
        public Contact Contact { set;  get; }

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
            if (IsContactEnterCorrected())
            {
                var correctedNumber = PhoneFilter(PhoneMaskedTextBox.Text);
                this.Contact = new Contact(SurnameTextBox.Text, NameTextBox.Text,
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
        /// Метод, проверяющий корректность данных и заполнены пооля или нет
        /// </summary>
        /// <returns></returns>
        private bool IsContactEnterCorrected()
        {
            return SurnameTextBox.Text != ""
                   && SurnameTextBox.BackColor != _errorColor
                   && NameTextBox.Text != ""
                   && NameTextBox.BackColor != _errorColor
                   && BirthdayErrorLabel.Text == ""
                   && EmailTextBox.Text != ""
                   && EmailTextBox.BackColor != _errorColor
                   && VkIDTextBox.Text != ""
                   && PhoneMaskedTextBox.Text.Length == 16;
        }

        /// <summary>
        /// Метод, проверяющий коорректность введенной фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.Surname = SurnameTextBox.Text;
                SurnameTextBox.BackColor = _rightColor;
            }
            catch (Exception exception)
            {
                SurnameTextBox.BackColor = _errorColor;
            }
        }

        /// <summary>
        /// Метод, проверяющий коорректность введеннго имени 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.Name = NameTextBox.Text;
                NameTextBox.BackColor = _rightColor;
            }
            catch (Exception exception)
            {
                NameTextBox.BackColor = _errorColor;
            }
        }

        /// <summary>
        /// Метод, проверяющий корректноость введенной даты рождения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void birthdayTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.BirthDay = BirthdayTimePicker.Value;
                BirthdayErrorLabel.Text = "";
            }
            catch (Exception exception)
            {
                BirthdayErrorLabel.Text = exception.Message;
            }
        }

        /// <summary>
        /// Метод проверяющий корректность вводимой электронной почты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = _rightColor;
            }
            catch (Exception exception)
            {
                EmailTextBox.BackColor = _errorColor;
            }
        }

        /// <summary>
        /// Метод, преобразующий из строки maskedtextbox в номер, без символов 
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        private string PhoneFilter(string phoneNumber)
        {
            var countryCodeIndex = 1;
            var operatorCodeIndex = 3;
            var firstPartNumberIndex = 8;
            var secondPartNumberIndex = 12;
            string correctedPhoneNumber = phoneNumber.Substring(countryCodeIndex, 1) 
                                          + phoneNumber.Substring(operatorCodeIndex, 3) 
                                          + phoneNumber.Substring(firstPartNumberIndex, 3) 
                                          + phoneNumber.Substring(secondPartNumberIndex, 4);
            return correctedPhoneNumber;
        }

        /// <summary>
        /// Метод, обновляющий поля формы
        /// </summary>
        public void InitialField()
        {
            if (Contact == null)
            {
                Contact = new Contact();
                return;
            }

            SurnameTextBox.Text = Contact.Surname;
            NameTextBox.Text = Contact.Name;
            EmailTextBox.Text = Contact.Email;
            VkIDTextBox.Text = Contact.VkID;
            PhoneMaskedTextBox.Text = Contact.PhoneNumber.Number;
            BirthdayTimePicker.Value = Contact.BirthDay;
        }
    }
}
