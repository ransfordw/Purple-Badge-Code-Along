using System;
using System.Collections.Generic;
using _03_Defining_Classes_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Defining_Classes_3_Tests
{
    [TestClass]
    public class SalesTeamMemberTests
    {
        private SalesTeamMember _member;
        private SalesTeamMember _memberTwo;
        private SalesTeamMember _memberThree;
        private SalesTeamMember _memberFour;
        private SalesTeamMemberRepository _memberRepo;

        [TestInitialize]
        public void Arrange()
        {
            _memberRepo = new SalesTeamMemberRepository();

            _member = new SalesTeamMember("Walker", 3.00m);
            _memberTwo = new SalesTeamMember("Wagner", 6.00m);
            _memberThree = new SalesTeamMember("Mullet", 5.00m);
            _memberFour = new SalesTeamMember("Tucker", 1.00m);

            _memberRepo.AddMemberToList(_member);
            _memberRepo.AddMemberToList(_memberTwo);
            _memberRepo.AddMemberToList(_memberThree);
            _memberRepo.AddMemberToList(_memberFour);
        }

        [TestMethod]
        public void SalesTeamMember_NumberOfItemsInList_ShouldReturnCorrectCount()
        {
            //--Act
            var expected = 4;
            var actual = _memberRepo.GetMemberList().Count;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTeamMember_GetTotalSales_ShouldReturnDecimal()
        {
            //--Act
            var expected = 15.00m;
            var actual = _memberRepo.GetTotalSales();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTeamMember_GetMemberSales_ShouldReturnDecimal()
        {
            //--Act
            var expected = 1.00m;
            var actual = _memberRepo.GetSalesForMember(_memberFour);

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTeamMember_GetLowestSales_ShouldReturnDecimal()
        {
            //--Act
            var expected = 1.00m;
            var actual = _memberRepo.GetLowestSales();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTeamMember_GetHighestSales_ShouldReturnDecimal()
        {
            //--Act
            var expected = 6.00m;
            var actual = _memberRepo.GetHighestSales();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTeamMember_GetListOfTopSellers_ShouldReturnList()
        {
            //--Act
            var expected = new List<SalesTeamMember> {_memberTwo};
            var actual = _memberRepo.GetTopSellers();

            //--Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTeamMember_GetListOfLowestSellers_ShouldReturnList()
        {
            //--Act
            var expected = new List<SalesTeamMember> { _memberFour };
            var actual = _memberRepo.GetLowestSellers();

            //--Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
