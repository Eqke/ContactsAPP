using System;
using System.Collections;
using System.Security.Cryptography;
using NUnit.Framework;
using ContactsApp;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ContactTests
    {
        [TestCase(TestName = "Positive surname get test")]
        public void SurnameGetTest()
        {
            // Setup
            var expected = "Смирнов";
            var contact = new Contact(expected, "Алексей", new DateTime(2000, 10, 2),
                "rek@mail.ru", new PhoneNumber("79245271235"), "rek");

            //Act
            var actual = contact.Surname;

            //Assert
            Assert.AreEqual(expected, actual, "get returned incorrected data");
        }

        [TestCase("", "must throw exception, if surname is empty string",
            TestName = "Set surname empty string test")]
        [TestCase("Козлюк-Козлюк-Козлюк-Козлюк-Козлюк-Козлюк-Козлюк-++",
            "must throw exception, if surname have more then 50 symbols",
            TestName = "Set surname more then 50 symbols test")]
        public void SurnameSetTest_Negative(string incorrectedSurname, string message)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var contact = new Contact(incorrectedSurname, "Алексей", new DateTime(2000, 10, 2),
                    "rek@mail.ru", new PhoneNumber("79245271235"), "rek");
            }, message);
        }

        [TestCase(TestName = "Positive name get test")]
        public void NameGetTest()
        {
            // Setup
            var expected = "Василий";
            var contact = new Contact("Козлюк", expected, new DateTime(2000, 10, 2),
                "rek@mail.ru", new PhoneNumber("79245271235"), "rek");

            // Act
            var actual = contact.Name;

            // Assert
            Assert.AreEqual(expected, actual, "get returned incorrected data");
        }

        [TestCase("", "must throw exception, if name is empty string",
            TestName = "Set name empty string test")]
        [TestCase("ВасилийВасилийВасилийВасилийВасилийВасилийВасилий++",
            "must throw exception, if name have more then 50 symbols",
            TestName = "Set name more then 50 symbols test")]
        public void NameSetTest(string incorrectedName, string message)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var contact = new Contact("Слепцов", incorrectedName, new DateTime(2000, 10, 2),
                    "rek@mail.ru", new PhoneNumber("79245271235"), "rek");
            }, message);
        }

        [TestCase(TestName = "Positive birthday get test")]
        public void BirthdayGetTest()
        {
            // Setup
            var expected = new DateTime(2000, 2, 25);
            var contact = new Contact("Козлюк", "Василий", expected,
                "rek@mail.ru", new PhoneNumber("79245271235"), "rek");

            // Act
            var actual = contact.BirthDay;

            // Assert
            Assert.AreEqual(expected, actual, "get returned incorrected data");
        }

        //[TestCase(Description = "Negative birthday set test", TestName = "Birthday year set less then 1900")]
        //public void BirthdaySetTest_YearLessThen1900()
        //{
        //    Assert.Throws<ArgumentException>(() =>
        //    {
        //        var contact = new Contact("Слепцов", "Евдоким", new DateTime(1700, 10, 2),
        //            "rek@mail.ru", new PhoneNumber("79245271235"), "rek");
        //    }, "must throw exception, if birthday year less then 1900");
        //}

        //[TestCase(Description = "Negative birthday set test", TestName = "Birthday later then today")]
        //public void BirthdaySetTest_DateLaterThenToday()
        //{
        //    var birthday = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 1);

        //    Assert.Throws<ArgumentException>(() =>
        //    {
        //        var contact = new Contact("Слепцов", "Петр", birthday,
        //            "rek@mail.ru", new PhoneNumber("79245271235"), "rek");
        //    }, "must throw exception, if birthday is today or later");
        //}

        [TestCase(1700, 10, 2, "must throw exception, if birthday year less then 1900", 
            Description = "Negative birthday set test", TestName = "Birthday year set less then 1900")]
        [TestCase(3000, 10, 2,  "must throw exception, if birthday is today or later", 
            Description = "Negative birthday set test", TestName = "Birthday later then today")]
        public void BirthdaySetTest(int year, int month, int day, string message)
        {
            
            //Assert
            Assert.Throws<ArgumentException>(() =>
               {
                   var contact = new Contact("Слепцов", "Евдоким", new DateTime(year, month, day),
                       "rek@mail.ru", new PhoneNumber("79245271235"), "rek");
               }, message);
        }

        [TestCase(TestName = "Positive phone get test")]
        public void PhoneNumberGetTest()
        {
            // Setup
            var expected = new PhoneNumber("79234364565");
            var contact = new Contact("Козлюк", "Василий", new DateTime(2003, 5, 20),
                "rek@mail.ru", expected, "rek");

            // Act
            var actual = contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expected, actual, "get returned incorrected data");
        }

        [TestCase(TestName = "Positive get test email")]
        public void EmailGetTest()
        {
            // Setup
            var expected = "chipenko.n@mail.ru";
            var contact = new Contact("Козлюк", "Василий", new DateTime(2003, 5, 20),
                expected, new PhoneNumber("79245271235"), "rek");

            // Act
            var actual = contact.Email;

            // Assert
            Assert.AreEqual(expected,actual,"get returned incorrected data");
        }

        [TestCase("chirkmail.ru", "must throw exception, if email haven't @ symbol",
            Description = "Negative email set test", TestName = "Email have @ symbol")]
        [TestCase("chipenkochipenkochipenkochipenkochipenkochipenko.n@mail.ru", 
            "must throw exception, if email have more then 50 symbols",
            Description = "Negative email set test", TestName = "Email can't be more then 50 symbols")]
        public void EmailSetTest(string incorrectedEmail, string message)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var contact = new Contact("Слепцов", "Петр", new DateTime(2003, 5, 20),
                    incorrectedEmail, new PhoneNumber("79245271235"), "rek");
            }, message);
        }

        [TestCase(TestName = "Positive vkid get test")]
        public void VKIDGetTest()
        {
            // Setup
            var expected = "id21343204";
            var contact = new Contact("Козлюк", "Василий", new DateTime(2003, 5, 20),
                "krip@yandex.ru", new PhoneNumber("79245271235"), expected);
            // Act
            var actual = contact.VkID;

            // Assert
            Assert.AreEqual(expected,actual,"get returned incorrected data");
        }

        [TestCase("id1234567890jup1", "must throw exception, if vkid have more then 15 symbols",
            Description = "Negative email set test", TestName = "VkID can't be more then 15 symbols")]
        public void VKIDSetTest(string incorrectedVKID, string message)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var contact = new Contact("Слепцов", "Петр", new DateTime(2003, 5, 20),
                    "err@ya.ru", new PhoneNumber("79245271235"), incorrectedVKID);
            }, message);
        }

        //[TestCase(null, null, null, null, "70000000000", null, 
        //    "construct work is incorrected", TestName = "Positive construct test")]
        //public void ContactConstructTest_Positive(string surname, string name, string birthday, string email, 
        //    string number, string vkid, string message)
        //{
        //    // Setup
        //    var expected = new Contact(surname, name, Convert.ToDateTime(birthday), email, new PhoneNumber(number),
        //        vkid);

        //    // Actual 
        //    var actual = new Contact();

        //    // Assert
        //    Assert.AreEqual(expected,actual, message);
        //}

        [TestCase("Козлюк", "Василий", "25.02.2000", "reklama@ya.ru",
            "79234364565", "id324215", "contctruct work is corrected",
            TestName = "Negative construct test")]
        public void ContactConstructTest_Negative(string surname, string name, string birthday, string email,
            string number, string vkid, string message)
        {
            // Setup
            var expected = new Contact(surname, name, Convert.ToDateTime(birthday), email, new PhoneNumber(number),
                vkid);

            // Actual 
            var actual = new Contact();

            // Assert
            Assert.AreNotEqual(expected, actual, message);
        }
    }
}