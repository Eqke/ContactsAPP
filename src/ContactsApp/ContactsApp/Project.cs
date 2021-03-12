using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, содержаший список контактов
    /// </summary>
    public class Project
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        

        /// <summary>
        /// Метод инициализации списка контактов
        /// </summary>
        public Project()
        {
        }

        /// <summary>
        /// Метод, сортирующий списоок контактов
        /// </summary>
        public void SortList()
        {
            Contacts.Sort();
        }

        /// <summary>
        /// Метод, формирующий список именинников
        /// </summary>
        /// <returns>Список именинников</returns>
        public List<Contact> TodayBirthdayList(DateTime today)
        {
            List<Contact> birthdayContactsList = new List<Contact>();
            foreach (var contact in Contacts)
            {
                if (contact.BirthDay.Day == today.Day 
                    && contact.BirthDay.Month == today.Month)
                {
                    birthdayContactsList.Add(contact);
                }
            }
            return birthdayContactsList;
        }
    }
}
