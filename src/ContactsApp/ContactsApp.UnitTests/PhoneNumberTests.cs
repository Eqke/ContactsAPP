using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class PhoneNumberTests
    {
        [TestCase("89234364565", "must throw exception, if number not started with 7",
            Description = "Negative phone number set test", TestName = "Incorrected phone number started with 8")]
        [TestCase("792343645655555", "must throw exception, if phone number length more then 11 symbols",
            Description = "Negative phone number set test", TestName = "Incorrected phone number have more then 11 symbols")]
        [TestCase("79kk4364565", "must throw exception, if phone have incorrected symbols",
            Description = "Negative phone number set test", TestName = "incorrected phone number with incorrected symbols")]
        public void PhoneNumber_Set_Incorrected(string incorretedNumber, string message)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var phoneNumber = new PhoneNumber(incorretedNumber);
            }, message);
        }

        [TestCase(TestName = "Positive number get test")]
        public void PhoneNumber_Set_Corrected()
        {
            // Setup
            var expected = "79052234567";
            var phoneNumber = new PhoneNumber(expected);

            // Act
            var actual = phoneNumber.Number;

            // Assert
            Assert.AreEqual(expected,actual);
        }
    }
}
