using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ContactsApp
{
    /// <summary>
    /// Класс контакта, хранящий информацию о имени, фамилии, дате рождения
    /// и электронной почте.
    /// </summary>
    public class Contact : ICloneable, IComparable<Contact>
    {

        /// <summary>
        /// Переменная, хранящая фамилию.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Переменная, хранящая имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Переменная, хранящая дату рождения.
        /// </summary>
        private DateTime _birthDay;

        /// <summary>
        /// Переменная, хранящая электронную почту.
        /// </summary>
        private string _email;

        /// <summary>
        /// Переменная, хранящая телефонный номер.
        /// </summary>
        private PhoneNumber _phoneNumber;

        /// <summary>
        /// Переменная, хранящая ID вконтакте
        /// </summary>
        private string _vkid;

        /// <summary>
        /// Метод, возвращающий vk id
        /// </summary>
        public string VkID
        {
            get { return _vkid; }
            private set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("Error: Incorrected VkID. " +
                                                "VkID must be have less then 16 symbols.");
                }

                _vkid = value;
            }
        }

        /// <summary>
        /// Метод, возвращающий фамилию
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            private set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Error: incorrected surname. " +
                                                "Surname length must be have less then 51 symbols");
                }
                else if (value == string.Empty)
                {
                    throw new ArgumentException("Error: incorrected surname. " +
                                                "Surname can't be empty string");
                }
                value = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
                _surname = value;
            }
        }

        /// <summary>
        /// Метод, возвращающий имя
        /// </summary>
        public string Name
        {
            get { return _name; }
            private set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Error: incorrected name. " +
                                                "Name length must be have less then 51 symbols");
                }
                else if (value == string.Empty)
                {
                    throw new ArgumentException("Error: incorrected name. " +
                                                "Name can't be empty string");
                }
                value = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
                _name = value;
            }
        }

        /// <summary>
        /// Метод, возвращающий дату рождения
        /// </summary>
        public DateTime BirthDay
        {
            get { return _birthDay; }
            private set 
            {

                if (value.Year < 1900)
                {
                    throw new ArgumentException("Error: incorrected year. " +
                                                "Please, choose year more then 1900.");
                }
                else if (value >= DateTime.Today) // or now
                {
                    throw new ArgumentException("Error: incorrected year. " +
                                                "Birthday can't be equal current day.");
                }
                _birthDay = value;
                }
        }

        /// <summary>
        /// Метод, возвращающий электронную почту
        /// </summary>
        public string Email
        {
            get { return _email; }
            private set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Error: incorrected name. " +
                                                "Email length must be less then 51 symbols");
                }
                else if (!Regex.IsMatch(value, "[@]"))
                {
                    throw new ArgumentException("Error: incorrected email. " +
                                                "Email must have '@' symbol.");
                }
                _email = value;
            }
        }

        /// <summary>
        /// Метод, возвращающий ообъект телефонного номера
        /// </summary>
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            private set { _phoneNumber = value; }
        }

        /// <summary>
        /// Метод, реализующий копирование объекта.
        /// </summary>
        /// <returns>Воозвращает новый объект, являющийся копией оригинала. </returns>
        public object Clone()
        {
            return new Contact(this.Surname, this.Name, 
                this.BirthDay, this.Email, this.PhoneNumber, this.VkID);
        }

        /// <summary>
        /// Конструктор класса, принимающий все поля класса.
        /// </summary>
        /// <param name="surname">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="birthDay">День Рождения</param>
        /// <param name="email">Электроонная почта</param>
        /// <param name="phoneNumber">Телефнный номер</param>
        /// <param name="vkid">ID Вконтакте</param>
        [JsonConstructor]
        public Contact(string surname, string name, DateTime birthDay, string email, PhoneNumber phoneNumber, string vkid)
        {
            this.Surname = surname;
            this.Name = name;
            this.BirthDay = birthDay;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.VkID = vkid;
        }

        /// <summary>
        /// Дефолтный конструктор класса
        /// </summary>
        public Contact()
        {
            _surname = null;
            _name = null;
            _birthDay = Convert.ToDateTime(null);
            _phoneNumber = new PhoneNumber("70000000000");
            _email = "";
            _vkid = "";
        }

        /// <summary>
        /// Метод, необходимый для реализации интерфейса IComporable
        /// </summary>
        /// <param name="other">Контакт для сравнения</param>
        /// <returns></returns>
        public int CompareTo(Contact other)
        {
            if (other == null) return 1;

            return _surname.CompareTo(other._surname);
        }

    }
}
