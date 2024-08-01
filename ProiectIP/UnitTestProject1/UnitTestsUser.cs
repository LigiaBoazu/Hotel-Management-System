using GestionareHotel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareHotel.Tests
{
    /// <summary>
    /// Testarea unitatilor pentru clasa User.
    /// </summary>
    [TestClass]
    public class UnitTestsUser
    {
        /// <summary>
        /// Testează constructorul User cu parametri.
        /// </summary>
        [TestMethod]
        public void Constructor_User()
        {
            string expectedUser = "admin";
            string expectedPass = "password";
            int expectedPrivilegiu = 1;

            User user = new User(expectedUser, expectedPass, expectedPrivilegiu);

            Assert.AreEqual(expectedUser, user.getUser());
            Assert.AreEqual(expectedPass, user.getPass());
            Assert.AreEqual(expectedPrivilegiu, user.getPrivilegiu());
        }

        /// <summary>
        /// Testează constructorul User cu parametrul Data Row.
        /// </summary>
        [TestMethod]
        public void Constructor_User_DataRow()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("User", typeof(string));
            dataTable.Columns.Add("Pass", typeof(string));
            dataTable.Columns.Add("Privilegiu", typeof(int));
            DataRow dataRow = dataTable.NewRow();
            dataRow[0] = "user1";
            dataRow[1] = "pass1";
            dataRow[2] = 2;
            dataTable.Rows.Add(dataRow);

            string expectedUser = "user1";
            string expectedPass = "pass1";
            int expectedPrivilegiu = 2;

            User user = new User(dataRow);

            Assert.AreEqual(expectedUser, user.getUser());
            Assert.AreEqual(expectedPass, user.getPass());
            Assert.AreEqual(expectedPrivilegiu, user.getPrivilegiu());
        }

        /// <summary>
        /// Testează metoda GetUser pentru a obține numele utilizatorului.
        /// </summary>
        [TestMethod]
        public void GetUser()
        {
            string expectedUser = "testuser";
            User user = new User(expectedUser, "testpass", 1);
            string actualUser = user.getUser();
            Assert.AreEqual(expectedUser, actualUser);
        }

        /// <summary>
        /// Testează metoda GetPassword pentru a obține parola utilizatorului.
        /// </summary>
        [TestMethod]
        public void GetPassword()
        {
            string expectedPass = "testpass";
            User user = new User("testuser", expectedPass, 1);
            string actualPass = user.getPass();
            Assert.AreEqual(expectedPass, actualPass);
        }

        /// <summary>
        /// Testează metoda GetPrivilegiu pentru a obține nivelul de acces al utilizatorului.
        /// </summary>
        [TestMethod]
        public void GetPrivilegiu()
        {
            int expectedPrivilegiu = 1;
            User user = new User("testuser", "testpass", expectedPrivilegiu);
            int actualPrivilegiu = user.getPrivilegiu();
            Assert.AreEqual(expectedPrivilegiu, actualPrivilegiu);
        }
    }
}
