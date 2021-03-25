using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public List<string> TodayBirthdayList(DateTime today)
        {
            var birthdayContactsList = new List<string>();
            foreach (var contact in Contacts)
            {
                if (contact.BirthDay.Day == today.Day 
                    && contact.BirthDay.Month == today.Month)
                {
                    birthdayContactsList.Add(contact.Surname);
                }
            }
            return birthdayContactsList;
        }

        /// <summary>
        /// Метод, реализующий поиск контактов по фамилии
        /// </summary>
        /// <param name="searchingSurname">Список людей</param>
        /// <returns></returns>
        public List<KeyValuePair<int, Contact>> FindContacts(string searchingSurname)
        {
            var findedContactsList = new List<KeyValuePair<int, Contact>>();
            if (searchingSurname == "")
            {
                for (int i = 0; i < Contacts.Count; i++)
                {
                    findedContactsList.Add(new KeyValuePair <int, Contact> (i, Contacts[i]));
                }
            }
            else
            {
                for (int i = 0; i < Contacts.Count; i++)
                {
                    if (Regex.IsMatch(Contacts[i].Surname.ToLower(), searchingSurname.ToLower()))
                    {
                        findedContactsList.Add(new KeyValuePair<int, Contact>(i, Contacts[i]));
                    }
                }
            }
            return findedContactsList;
        }
    }
}
