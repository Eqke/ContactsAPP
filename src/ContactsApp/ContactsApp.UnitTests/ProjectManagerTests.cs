using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTests
    {
        [TestCase(Description = "Positive project manager get test", TestName = "Project manager get test")]
        public void ProjectManagerGetTest()
        {
            // Setup
            var expected = new Contact("Сидоров", "Иван", new DateTime(1998, 3, 15), "sid.i@ya.ru",
                new PhoneNumber("79996542354"), "sid0rov");
            Project project = new Project();
            project.Contacts.Add(expected);
            ProjectManager.SaveToFile(project, "C:/TestContact.txt");
            project = null;
            project = ProjectManager.LoadFromFile("C:/TestContact.txt");

            // Act
            var actual = project.Contacts[0];

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected.Surname, actual.Surname, "returned incorrected data(surname)");
                Assert.AreEqual(expected.Name, actual.Name, "returned incorrected data(name)");
                Assert.AreEqual(expected.PhoneNumber.Number, actual.PhoneNumber.Number, "returned incorrected data(phone number)");
                Assert.AreEqual(expected.BirthDay, expected.BirthDay, "returned incorrected data(birthday)");
                Assert.AreEqual(expected.Email, actual.Email, "returned incorrected data(email)");
                Assert.AreEqual(expected.VkID, actual.VkID, "returned incorrected data(vkid)");
            });
        }
    }
}
