using System;
using _02_Reference_Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Reference_Types_Unit_Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Customer_SetFirstName_ShouldBeString()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Ransford";

            //--Act
            var actual = customer.FirstName;
            var expected = "Ransford";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SetLastName_ShouldBeString()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.LastName = "Walker";

            //--Act
            var actual = customer.LastName;
            var expected = "Walker";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SetEmail_ShouldBeString()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.Email = "ransfordw@gmail.com";

            //--Act
            var actual = customer.Email;
            var expected = "ransfordw@gmail.com";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SetPhoneNumber_ShouldBeString()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.PhoneNumber = "317-535-0324";

            //--Act
            var actual = customer.PhoneNumber;
            var expected = "317-535-0324";

            //--Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
    }
}
