using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTests
    {
        
        [TestCase(Description = "Positive project manager load test", TestName = "Project manager load test")]
        public void ProjectManager_LoadCorrectData_FileLoadCorrected()
        {
            // Setup
            var expectedProject = new Project();
            var contact = new Contact("Козлюк", "Василий", new DateTime(2000, 2, 25),
                "eqkez0r@mail.ru", new PhoneNumber("79234364565"), "eqkez0r");
            expectedProject.Contacts.Add(contact);
            contact = new Contact("Семенов", "Алексей", new DateTime(2000, 3, 20),
                "sem@mail.ru", new PhoneNumber("79534364565"), "sem");
            expectedProject.Contacts.Add(contact);

            // Act
            var actualProject = ProjectManager.LoadFromFile("TestData\\", "CorrectedProjectFile.json");
            
            // Assert
            Assert.AreEqual(expectedProject.Contacts.Count, actualProject.Contacts.Count);
            for (int i = 0; i < expectedProject.Contacts.Count; i++)
            {
                Assert.AreEqual(expectedProject.Contacts[i], actualProject.Contacts[i]);
            }
        }

        [TestCase(Description = "", TestName = "Load incorrected file")]
        public void ProjectManager_LoadBrokenData_FileLoadIncorrected()
        {
            // Setup
            var expectedProject = new Project();
            var contact = new Contact("Козлюк", "Василий", new DateTime(2000, 2, 25),
                "eqkez0r@mail.ru", new PhoneNumber("79234364565"), "eqkez0r");
            expectedProject.Contacts.Add(contact);
            contact = new Contact("Семенов", "Алексей", new DateTime(2000, 3, 20),
                "sem@mail.ru", new PhoneNumber("79534364565"), "sem");
            expectedProject.Contacts.Add(contact);

            // Act
            var actualProject = ProjectManager.LoadFromFile("TestData\\", "BrokenProjectFile.json");

            // Assert
            Assert.AreNotEqual(expectedProject.Contacts.Count, actualProject.Contacts.Count);
        }

        [TestCase(Description = "", TestName = "Save correctly test")]
        public void ProjectManager_SaveCorrectData_FileSaveCorrected()
        {
            // Setup
            var savingProject = new Project();
            var contact = new Contact("Козлюк", "Василий", new DateTime(2000, 2, 25),
                "eqkez0r@mail.ru", new PhoneNumber("79234364565"), "eqkez0r");
            savingProject.Contacts.Add(contact);
            contact = new Contact("Семенов", "Алексей", new DateTime(2000, 3, 20),
                "sem@mail.ru", new PhoneNumber("79534364565"), "sem");
            savingProject.Contacts.Add(contact);

            // Act
            ProjectManager.SaveToFile(savingProject,"TestData\\", "SavingProjectFile.json");

            // Assert
            var expected = File.ReadAllText("TestData\\CorrectedProjectFile.json");
            var actual = File.ReadAllText("TestData\\SavingProjectFile.json");
            Assert.AreEqual(expected, actual);
        }
    }
}
