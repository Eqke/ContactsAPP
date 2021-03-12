using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;


namespace ContactAppUI
{
    
    public partial class MainForm : Form
    {
        private Project _project;
        private string _currentPath = "";
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, описывающий рекакцию на клик поо кнопке Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addContactButton_Click(object sender, EventArgs e)
        {
            ContactForm editForm = new ContactForm();
            var dialogResult = editForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                _project.Contacts.Add(editForm.CurrentContact);
                _project.SortList();
                this.contactsListBox.Items.Clear();
                foreach (var contact in _project.Contacts)
                {
                    this.contactsListBox.Items.Add(contact.Surname);
                }
                editForm.Close();
                ProjectManager.SaveToFile(_project,_currentPath);
                CheckBirthdayToday(DateTime.Today);
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                editForm.Close();
            }
        }

        /// <summary>
        /// Метод, описывающий загрузку данной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultPathToData);
            _currentPath = ProjectManager.DefaultPathToData;
            _project.SortList();
            contactsListBox.Items.Clear();
            foreach (var contact in _project.Contacts)
            {
                this.contactsListBox.Items.Add(contact.Surname);
            }
        }

        /// <summary>
        /// Метод, описывающий рекакцию на клик по кнопке Edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editContactButton_Click(object sender, EventArgs e)
        {
            if (contactsListBox.Items.Count != 0)
            {
                ContactForm editForm = new ContactForm();
                var selectedIndex = contactsListBox.SelectedIndex;
                editForm.CurrentContact = _project.Contacts[selectedIndex];
                var dialogResult = editForm.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    _project.Contacts[contactsListBox.SelectedIndex] = editForm.CurrentContact;
                    _project.SortList();
                    this.contactsListBox.Items.Clear();
                    foreach (var contact in _project.Contacts)
                    {
                        this.contactsListBox.Items.Add(contact.Surname);
                    }

                    editForm.Close();
                    CheckBirthdayToday(DateTime.Today);
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    editForm.Close();
                }
            }
            else
            {
                MessageBox.Show("Error: you haven't contacts for edit", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод, описывающий рекакцию на клик по кнопке Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteContactButton_Click(object sender, EventArgs e)
        {
            if (contactsListBox.Items.Count != 0)
            {
                var selectedIndex = contactsListBox.SelectedIndex;
            DialogResult result = MessageBox.Show("Are you wanna delete " +
                            _project.Contacts[selectedIndex].Surname + "?", "Verification",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                _project.Contacts.RemoveAt(selectedIndex);
                _project.SortList();
                this.contactsListBox.Items.Clear();
                foreach (var contact in _project.Contacts)
                {
                    this.contactsListBox.Items.Add(contact.Surname);
                }
                CheckBirthdayToday(DateTime.Today);
                ProjectManager.SaveToFile(_project,_currentPath);
            }
            RefreshContactBoxs();
            }
            else
            {
                MessageBox.Show("Error: you haven't contacts for delete", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод, описывающий рекакцию на клик по кнопке save, находящийся в menustrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "only txt files (*.txt) | *.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;
                ProjectManager.SaveToFile(_project, path);
            }
            CheckBirthdayToday(DateTime.Today);
        }

        /// <summary>
        /// Метод, описывающий рекакцию на клик по кнопке load, находящийся в menustrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "only txt files (*.txt) | *.txt";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                _currentPath = openDialog.FileName;
                contactsListBox.Items.Clear();
                _project = ProjectManager.LoadFromFile(_currentPath);
                _project.SortList();
                foreach (var contact in _project.Contacts)
                {
                    contactsListBox.Items.Add(contact.Surname);
                }
                CheckBirthdayToday(DateTime.Today);
            }
        }

        /// <summary>
        /// Метод, описывающий рекакцию на клик по кнопке exit, находящийся в menustrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Метод, описывающий рекакцию на клик по кнопке about, находящийся в menustrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show(this);
        }

        /// <summary>
        /// Метод, описывающий рекакцию на изменение выбранного в списке контакта 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshContactBoxs();
        }

        /// <summary>
        /// Метод, выдающий список контактов с введенной подстрокой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            if (findTextBox.Text == "")
            {
                contactsListBox.Items.Clear();
                foreach (var contact in _project.Contacts)
                {
                    contactsListBox.Items.Add(contact.Surname);
                }
            }
            else
            {
                contactsListBox.Items.Clear();
                foreach (var contact in _project.Contacts)
                {
                    if (Regex.IsMatch(contact.Surname.ToLower(), findTextBox.Text.ToLower()))
                    {
                        contactsListBox.Items.Add(contact.Surname);
                    }
                }
            }
        }

        /// <summary>
        /// Метод для реализации удаления на кнопку delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contactsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && contactsListBox.Items.Count != 0)
            {
                var selectedIndex = contactsListBox.SelectedIndex;
                if (selectedIndex == -1)
                {
                    selectedIndex = _project.Contacts.Count - 1;
                }
                DialogResult result = MessageBox.Show("Are you wanna delete " +
                                                      _project.Contacts[selectedIndex].Surname + "?", "Verification",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    _project.Contacts.RemoveAt(selectedIndex);
                    _project.SortList();
                    this.contactsListBox.Items.Clear();
                    foreach (var contact in _project.Contacts)
                    {
                        this.contactsListBox.Items.Add(contact.Surname);
                    }
                }
                CheckBirthdayToday(DateTime.Today);
            }
        }

        /// <summary>
        /// Метод реализующий вывоод информации об именинников
        /// </summary>
        /// <param name="today"></param>
        private void CheckBirthdayToday(DateTime today)
        {
            List<Contact> birthdayContacts = _project.TodayBirthdayList(today);
            if (birthdayContacts.Count != 0)
            {
                TodayBirthdayLabel.Text = "Сегодня день рождения у: ";
                string brithdayLabelText = "";
                foreach (var contact in birthdayContacts)
                {
                    brithdayLabelText += contact.Surname + ", ";
                }

                TodayPictureBox.Visible = true;
                TodayBirthdayLabel.Text += brithdayLabelText.Substring(0,brithdayLabelText.Length-2) + ".";
            }
            else
            {
                TodayBirthdayLabel.Text = "";
                TodayPictureBox.Visible = false;
            }
        }

        /// <summary>
        /// Метод, реализуюший сохранение до закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project,_currentPath);
        }

        /// <summary>
        /// Метод, отвечающий за обновление информации в полях формы
        /// </summary>
        private void RefreshContactBoxs()
        {
            if (contactsListBox.Items.Count > 0)
            {
                var selectedIndex = contactsListBox.SelectedIndex;
                if (selectedIndex == -1)
                {
                    selectedIndex = _project.Contacts.Count - 1;
                }

                nameTextBox.Text = _project.Contacts[selectedIndex].Name;
                surnameTextBox.Text = _project.Contacts[selectedIndex].Surname;
                phoneMaskedTextBox.Text = _project.Contacts[selectedIndex].PhoneNumber.Number.Substring(1, 10);
                birthdayTimePicker.Value = _project.Contacts[selectedIndex].BirthDay;
                emailTextBox.Text = _project.Contacts[selectedIndex].Email;
                vkIDTextBox.Text = _project.Contacts[selectedIndex].VkID;
            }
            else
            {
                nameTextBox.Text = "";
                surnameTextBox.Text = "";
                phoneMaskedTextBox.Text = "00000000000";
                birthdayTimePicker.Value = DateTime.Today;
                emailTextBox.Text = "";
                vkIDTextBox.Text = "";
            }
        }
    }
}
