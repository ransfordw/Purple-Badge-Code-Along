using System;
using _03_Defining_Classes_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Defining_Classes_1_Unit_Tests
{
    [TestClass]
    public class EmployeeTests
    {
        //--Field
        private Employee _employee;

        [TestInitialize]
        public void Arrange()
        {
            //--Arrange
            _employee = new Employee();
            _employee.EmployeeID = 1;
            _employee.LastName = "Walker";
            _employee.HoursOnClock = 400;
            _employee.Age = 27;
        }

        [TestMethod]
        public void Employee_SetLastName_IsString()
        {
            //--Act
            var actual = _employee.LastName;
            var expected = "Walker";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_SetEmployeeID_IsInt()
        {
            //--Act
            var actual = _employee.EmployeeID;
            var expected = 1;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_SetHoursOnClock_IsInt()
        {
            //--Act
            var actual = _employee.HoursOnClock;
            var expected = 400;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_SetAge_IsInt()
        {
            //--Act
            var actual = _employee.Age;
            var expected = 27;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
