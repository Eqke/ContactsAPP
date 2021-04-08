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
        /// <summary>
        /// Переменная, хранящая проект
        /// </summary>
        private Project _project;

        /// <summary>
        /// Переменная, хранящая коонтакты, отображаемые в contactslistbox
        /// </summary>
        private List <KeyValuePair<int, Contact>> _viewedContactList;

        /// <summary>
        /// Метод, обновляющий информационные поля формы
        /// </summary>
        private void RefreshViewedList()
        {
            contactsListBox.Items.Clear();
            if (_viewedContactList.Count == 0) return;
            for (int i = 0; i < _viewedContactList.Count; i++)
            {
                contactsListBox.Items.Add(_viewedContactList[i].Value.Surname);
            }
            CheckBirthdayToday(DateTime.Today);
        }

        /// <summary>
        /// Метод, иницилизирующий список отооборажаемых в contactslistbox
        /// </summary>
        private void InitialViewedList()
        {
            _viewedContactList.Clear();
            for (int i = 0; i < _project.Contacts.Count; i++)
            {
                _viewedContactList.Add(new KeyValuePair<int,Contact>(i,_project.Contacts[i]));
            }
        }
        
        /// <summary>
        /// Конструктоор фоормы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultPathToData, ProjectManager.DefaultFileName);
            _project.SortList();
            _viewedContactList = new List<KeyValuePair<int, Contact>>();
            InitialViewedList();
            RefreshViewedList();
        }

        /// <summary>
        /// Метод, описывающий рекакцию на клик поо кнопке Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        /// <summary>
        /// Метод, описывающий рекакцию на клик по кнопке Edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editContactButton_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        /// <summary>
        /// Метод, описывающий рекакцию на клик по кнопке Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteContactButton_Click(object sender, EventArgs e)
        {
            DeleteContact();
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
            var aboutForm = new AboutForm();
            aboutForm.Show(this);
        }

        /// <summary>
        /// Метод, описывающий рекакцию на изменение выбранного в списке контакта 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshContactBoxes();
        }

        /// <summary>
        /// Метод, выдающий список контактов с введенной подстрокой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            contactsListBox.Items.Clear();
            _viewedContactList = _project.FindContacts(findTextBox.Text);
            RefreshViewedList();
        }

        /// <summary>
        /// Метод для реализации удаления на кнопку delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contactsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteContact();
            }
        }

        /// <summary>
        /// Метод реализующий вывоод информации об именинников
        /// </summary>
        /// <param name="today"></param>
        private void CheckBirthdayToday(DateTime today)
        {
            var birthdayContactsSurname = _project.TodayBirthdayList(today);
            if (birthdayContactsSurname.Count != 0)
            {
                BirthdayPanel.Visible = true;
                TodayBirthdayLabel.Text = "today is these people's birthday: ";
                var birthdayLabelText = String.Join(", ", birthdayContactsSurname);
                TodayBirthdayLabel.Text += birthdayLabelText;
            }
            else
            {
                BirthdayPanel.Visible = false;
            }
        }

        /// <summary>
        /// Метод, реализуюший сохранение до закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project,ProjectManager.DefaultPathToData, ProjectManager.DefaultFileName);
        }

        /// <summary>
        /// Метод, отвечающий за обновление информации в полях формы
        /// </summary>
        private void RefreshContactBoxes()
        {
            if (contactsListBox.SelectedIndex == -1) return;
            var selectedIndex = _viewedContactList[contactsListBox.SelectedIndex].Key;

            if (contactsListBox.Items.Count > 0)
            {
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

        /// <summary>
        /// Метод дообавления контакта
        /// </summary>
        private void AddContact()
        {
            var form = new ContactForm(null);
            var dialogResult = form.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                _project.Contacts.Add(form.Contact);
                _project.SortList();
                InitialViewedList();
                RefreshViewedList();
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultPathToData, ProjectManager.DefaultFileName);
            }
        }

        /// <summary>
        /// Метод редактирования контакта
        /// </summary>
        private void EditContact()
        {
            if (_project.Contacts.Count == 0) return;
            if (contactsListBox.SelectedIndex == -1) return;
            var selectedIndex = _viewedContactList[contactsListBox.SelectedIndex].Key;
            ContactForm form = new ContactForm(_project.Contacts[selectedIndex]);
            var dialogResult = form.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                _project.Contacts[selectedIndex] = form.Contact;
                _project.SortList();
                InitialViewedList();
                RefreshViewedList();
                RefreshContactBoxes();
            }
        }

        /// <summary>
        /// Метод удаления контакта
        /// </summary>
        private void DeleteContact()
        {
            if (contactsListBox.Items.Count == 0) return;
            if (contactsListBox.SelectedIndex == -1) return;
            var selectedIndex = _viewedContactList[contactsListBox.SelectedIndex].Key;
            DialogResult result = MessageBox.Show("Are you wanna delete " + _project.Contacts[selectedIndex].Surname + "?",
                "Verification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                _project.Contacts.RemoveAt(selectedIndex);
                _viewedContactList.RemoveAt(selectedIndex);
                InitialViewedList();
                RefreshViewedList();
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultPathToData, ProjectManager.DefaultFileName);
                RefreshContactBoxes();
            }
        }

        /// <summary>
        /// Реакция на клик элемента menuitem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        /// <summary>
        /// Реакция на клик элемента menuitem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact();
        }

    }
}
