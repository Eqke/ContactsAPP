using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectTests
    {
        [TestCase(TestName = "Positive project get test")]
        public void Project_Get_Positive()
        {
            // Setup
            var expectedContact = new Contact("Сидоров", "Иван", new DateTime(1998, 3, 15), "sid.i@ya.ru",
                new PhoneNumber("79996542354"), "sid0rov");
            var project = new Project();
            project.Contacts.Add(expectedContact);

            // Act
            var actualContact = project.Contacts[0];

            // Assert
            Assert.AreEqual(expectedContact, actualContact);
        }

        [TestCase(TestName = "Positive sort test")]
        public void Project_SortList_Positive()
        {
            // Setup
            var secondContact = new Contact("Некифор", "Петр", new DateTime(1993, 1, 20),
                "neck@gmail.com", new PhoneNumber("78324651236"), "id43345");
            var firstContact = new Contact("Авдеев", "Максим", new DateTime(1993, 1, 25),
                "avd@mail.ru", new PhoneNumber("78324441236"), "id21345");
            var project =new Project();
            project.Contacts.Add(secondContact);
            project.Contacts.Add(firstContact);
            
            // Actual
            var firstActualContact = firstContact;
            var secondActualContact = secondContact;
            project.SortList();

            // Assert

            Assert.Multiple(() =>
            {
                Assert.AreEqual(project.Contacts[0].Surname, firstActualContact.Surname, "first incorrected"); 
                Assert.AreEqual(project.Contacts[1].Surname,secondActualContact.Surname,"second incorrected");
            });
                
        }

        [TestCase(TestName = "Negative sort test")]
        public void Project_SortList_Negative()
        {
            // Setup
            var secondContact = new Contact("Некифор", "Петр", new DateTime(1993, 1, 20),
                "neck@gmail.com", new PhoneNumber("78324651236"), "id43345");
            var firstContact = new Contact("Авдеев", "Максим", new DateTime(1993, 1, 25),
                "avd@mail.ru", new PhoneNumber("78324441236"), "id21345");
            var project = new Project();
            project.Contacts.Add(secondContact);
            project.Contacts.Add(firstContact);

            // Actual
            var firstActualContact = secondContact;
            var secondActualContact = firstContact;
            project.SortList();

            // Assert

            Assert.Multiple(() =>
            {
                Assert.AreNotEqual(project.Contacts[0].Surname, firstActualContact.Surname, "first incorrected");
                Assert.AreNotEqual(project.Contacts[1].Surname, secondActualContact.Surname, "second incorrected");
            });

        }

        [TestCase(TestName = "Positive detect Birthday guys test")]
        public void Project_TodayBirthdayList_WithBirthday()
        {
            // Setup
            var today = DateTime.Today;
            var project = new Project();
            var contact = new Contact("Некифор", "Петр", new DateTime(1993, today.Month, today.Day),
                "neck@gmail.com", new PhoneNumber("78324651236"), "id43345");
            project.Contacts.Add(contact);
            

            // Actual
            var birthDayList = project.TodayBirthdayList(today);

            // Assert
            Assert.AreEqual(contact.Surname, birthDayList[0], "method work incorrected");
        }

        [TestCase(TestName = "Negative detect Birthday guys test")]
        public void Project_TodayBirthdayList_WithoutBirthday()
        {
            // Setup
            var today = DateTime.Today;
            var project = new Project();
            var contact = new Contact("Некифор", "Петр", new DateTime(1993, today.Month, today.Day + 1),
                "neck@gmail.com", new PhoneNumber("78324651236"), "id43345");
            project.Contacts.Add(contact);


            // Actual
            var birthDayList = project.TodayBirthdayList(today);

            // Assert
            Assert.AreEqual(birthDayList.Count, 0, "method work incorrected");
        }
    }
}
