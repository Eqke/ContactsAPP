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
    public class Contact : ICloneable, IComparable<Contact>, IEquatable<Contact>
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
            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("Error: Incorrected VkID. " +
                                                "VkID must be hav Coe less then 16 symbols.");
                }

                _vkid = value;
            }
        }

        /// <summary>
        /// Метод, возвращающий фамилию
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                if (IsCorrectedField(value))
                {
                    value = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
                    _surname = value;
                }
            }
        }

        /// <summary>
        /// Метод, возвращающий имя
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (IsCorrectedField(value))
                {
                    value = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Метод, возвращающий дату рождения
        /// </summary>
        public DateTime BirthDay
        {
            get => _birthDay;
            set 
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentException("Error: incorrected year. " +
                                                "Please, choose year more then 1900.");
                }
                else if (value > DateTime.Now)
                {
                    throw new ArgumentException("Error: incorrected year. " +
                                                "Birthday can't be later then today.");
                }
                _birthDay = value;
                }
        }

        /// <summary>
        /// Метод, возвращающий электронную почту
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Error: incorrected email. " +
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
            set { _phoneNumber = value; }
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

        /// <summary>
        /// Метод, необходимый для реализации интерфейса IEquatable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Contact other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _surname == other._surname 
                   && _name == other._name 
                   && _birthDay.Equals(other._birthDay) 
                   && _email == other._email 
                   && Equals(_phoneNumber, other._phoneNumber) 
                   && _vkid == other._vkid;
        }

        /// <summary>
        /// Метод, необходимый для реализации интерфейса IEquatable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Contact) obj);
        }

        /// <summary>
        /// Метод, необходимый для реализации интерфейса IEquatable
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_surname != null ? _surname.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_name != null ? _name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ _birthDay.GetHashCode();
                hashCode = (hashCode * 397) ^ (_email != null ? _email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_phoneNumber != null ? _phoneNumber.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_vkid != null ? _vkid.GetHashCode() : 0);
                return hashCode;
            }
        }


        private bool IsCorrectedField(string value)
        {
            if (value.Length > 50)
            {
                throw new ArgumentException("Error: incorrected data. " +
                                            "Name length must be have less then 51 symbols");
            }
            else if (value == string.Empty)
            {
                throw new ArgumentException("Error: incorrected data. " +
                                            "Name can't be empty string");
            }
            else if (Regex.IsMatch(value, "[^a-zA-Zа-яА-Я]"))
            {
                throw new ArgumentException("Error: incorrected data. " + 
                                            "Surname have incorrected symbols.");
            }
            return true;
        }
    }
}
