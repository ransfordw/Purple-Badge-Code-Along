using System;
using _04_Encapsulation_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Encapuslation_Tests
{
    [TestClass]
    public class RoomTests
    {
        private Room _room;

        [TestInitialize]
        public void Arrange()
        {
            Room _room = new Room(8, 8, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Please enter a length between 6 and 30.")]
        public void Room_LengthOutOfRange_ShouldThrowException()
        {
            Room room = new Room(4,8,11);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Please enter a width between 6 and 30.")]
        public void Room_WidthOutOfRange_ShouldThrowException()
        {
            Room room = new Room(8, 4, 11);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Please enter a heigth between 10 and 12.")]
        public void Room_HeigthOutOfRange_ShouldThrowException()
        {
            Room room = new Room(8, 8, 9);
        }

        [TestMethod]
        public void Room_CalculateAreaOfWalls_ShouldReturnCorrectDouble()
        {
            Room _room = new Room(8, 8, 10);

            var actual = _room.GetSurfaceAreaOfWalls();
            var expected = 320;

            Assert.AreEqual(expected, actual);
        }

    }
}
