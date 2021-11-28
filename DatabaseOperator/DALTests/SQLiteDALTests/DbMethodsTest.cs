using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataBaseOperator.DAL.Data.SQLite.Services;
using DataBaseOperator.Domain.Core;


namespace DALTests.SQLiteDALTests
{
    [TestClass]
    public class DbMethodsTest
    {
        [TestMethod]
        public void GetFreeIDFromListTest_01()
        {
            List<User> list = new()
            {
                new User { ID = "1" },
                new User { ID = "2" }
            };
            Assert.AreEqual(3, DbMethods.GetFreeIDFromUserList(list));
        }

        [TestMethod]
        public void GetFreeIDFromListTest_02()
        {
            List<User> list = new()
            {
                new User { ID = "1" },
                new User { ID = "3" }
            };
            Assert.AreEqual(2, DbMethods.GetFreeIDFromUserList(list));
        }

        [TestMethod]
        public void GetFreeIDFromListTest_03()
        {
            List<User> list = new()
            {
                new User { ID = "4" },
                new User { ID = "7" }
            };
            Assert.AreEqual(1, DbMethods.GetFreeIDFromUserList(list));
        }

        [TestMethod]
        public void GetFreeIDFromListTest_04()
        {
            List<User> list = new()
            {
                new User { ID = "-2" },
                new User { ID = "1" },
                new User { ID = "2" },
                new User { ID = "3" },
                new User { ID = "4" },
                new User { ID = "5" },
                new User { ID = "7" }
            };
            Assert.AreEqual(6, DbMethods.GetFreeIDFromUserList(list));
        }

        [TestMethod]
        public void GetFreeIDFromListTest_05()
        {
            List<User> list = new()
            {
                new User { ID = "-3" },
                new User { ID = "3" }
            };
            Assert.AreEqual(1, DbMethods.GetFreeIDFromUserList(list));
        }

        [TestMethod]
        public void GetFreeIDFromListTest_06()
        {
            List<User> list = new()
            {
                new User { ID = "0" },
                new User { ID = "2" }
            };
            Assert.AreEqual(1, DbMethods.GetFreeIDFromUserList(list));
        }

        [TestMethod]
        public void GetFreeIDFromListTest_07()
        {
            List<User> list = new()
            {
                new User { ID = "-1" },
                new User { ID = "3" }
            };
            Assert.AreEqual(1, DbMethods.GetFreeIDFromUserList(list));
        }

        [TestMethod]
        public void GetFreeIDFromListTest_08()
        {
            List<User> list = new()
            {
                new User { ID = "0" },
                new User { ID = "1" }
            };
            Assert.AreEqual(2, DbMethods.GetFreeIDFromUserList(list));
        }

        [TestMethod]
        public void GetFreeIDFromListTest_09()
        {
            List<User> list = new()
            {
                new User { ID = "1" },
                new User { ID = "10" },
                new User { ID = "2" },
                new User { ID = "3" },
                new User { ID = "4" },
                new User { ID = "5" },
                new User { ID = "6" },
                new User { ID = "7" },
                new User { ID = "8" },
                new User { ID = "9" },
            };
            Assert.AreEqual(11, DbMethods.GetFreeIDFromUserList(list));
        }

        [TestMethod]
        public void SearchTheMatchesInTheInputTest_01()
        {
            Assert.AreEqual(true, DbMethods.SearchMatchesInTheInput("Abcdef", "Abc"));
        }

        [TestMethod]
        public void SearchTheMatchesInTheInputTest_02()
        {
            Assert.AreEqual(false, DbMethods.SearchMatchesInTheInput("Accdef", "Abc"));
        }

        [TestMethod]
        public void SearchTheMatchesInTheInputTest_03()
        {
            Assert.AreEqual(true, DbMethods.SearchMatchesInTheInput("12345", "123"));
        }

        [TestMethod]
        public void SearchTheMatchesInTheInputTest_04()
        {
            Assert.AreEqual(false, DbMethods.SearchMatchesInTheInput("Ab", "Abc"));
        }

        [TestMethod]
        public void SearchTheMatchesInTheInputTest_05()
        {
            Assert.AreEqual(true, DbMethods.SearchMatchesInTheInput("Ab", "Ab"));
        }

        [TestMethod]
        public void IsANumberTest_01()
        {
            Assert.AreEqual(true, DbMethods.IsAIntNumber("12"));
        }

        [TestMethod]
        public void IsANumberTest_02()
        {
            Assert.AreEqual(true, DbMethods.IsAIntNumber("45"));
        }

        [TestMethod]
        public void IsANumberTest_03()
        {
            Assert.AreEqual(false, DbMethods.IsAIntNumber("12f"));
        }

    }
}