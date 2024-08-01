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
    /// Clasa de test pentru Rezervare.
    /// </summary>
    [TestClass]
    public class UnitTestsRezervare
    {
        /// <summary>
        /// Testarea constructorului Rezervare cu parametri.
        /// </summary>
        [TestMethod]
        public void Constructor_Rezervare()
        {
            string expectedNume = "Popescu";
            string expectedPrenume = "Ion";
            int expectedNumarZile = 5;
            int expectedPret = 500;
            int expectedCamera = 101;
            Rezervare rezervare = new Rezervare(expectedNume, expectedPrenume, expectedNumarZile, expectedPret, expectedCamera);
            Assert.AreEqual(expectedNume, rezervare.getNume());
            Assert.AreEqual(expectedPrenume, rezervare.getPrenume());
            Assert.AreEqual(expectedNumarZile, rezervare.getZile());
            Assert.AreEqual(expectedPret, rezervare.getPret());
            Assert.AreEqual(expectedCamera, rezervare.getCamera());
        }

        /// <summary>
        /// Testarea constructorului Rezervare cu parametrul Data Row.
        /// </summary>
        [TestMethod]
        public void Constructor_Rezervare_DataRow()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nume", typeof(string));
            dataTable.Columns.Add("Prenume", typeof(string));
            dataTable.Columns.Add("NumarZile", typeof(int));
            dataTable.Columns.Add("Pret", typeof(int));
            dataTable.Columns.Add("Camera", typeof(int));
            DataRow dataRow = dataTable.NewRow();
            dataRow[0] = 1;
            dataRow[1] = "Ionescu";
            dataRow[2] = "Maria";
            dataRow[3] = 3;
            dataRow[4] = 300;
            dataRow[5] = 102;
            dataTable.Rows.Add(dataRow);
            string expectedNume = "Ionescu";
            string expectedPrenume = "Maria";
            int expectedNumarZile = 3;
            int expectedPret = 300;
            int expectedCamera = 102;
            Rezervare rezervare = new Rezervare(dataRow);
            Assert.AreEqual(expectedNume, rezervare.getNume());
            Assert.AreEqual(expectedPrenume, rezervare.getPrenume());
            Assert.AreEqual(expectedNumarZile, rezervare.getZile());
            Assert.AreEqual(expectedPret, rezervare.getPret());
            Assert.AreEqual(expectedCamera, rezervare.getCamera());
        }

        /// <summary>
        /// Testeaza metoda getNume din clasa Rezervare.
        /// </summary>
        [TestMethod]
        public void GetNume()
        {
            string expectedNume = "Ion";
            var rezervare = new Rezervare(expectedNume, "Ionel", 3, 100, 1);
            string actualNume = rezervare.getNume();
            Assert.AreEqual(expectedNume, actualNume);
        }

        /// <summary>
        /// Testeaza metoda getPrenume din clasa Rezervare.
        /// </summary>
        [TestMethod]
        public void GetPrenume()
        {
            string expectedPrenume = "Popa";
            var rezervare = new Rezervare("Carmen", expectedPrenume, 3, 100, 1);
            string actualPrenume = rezervare.getPrenume();
            Assert.AreEqual(expectedPrenume, actualPrenume);
        }

        /// <summary>
        /// Testeaza metoda getZile din clasa Rezervare.
        /// </summary>
        [TestMethod]
        public void GetZile()
        {
            int expectedZile = 3;
            var rezervare = new Rezervare("Ilinca", "Artene", expectedZile, 100, 1);
            int actualZile = rezervare.getZile();
            Assert.AreEqual(expectedZile, actualZile);
        }

        /// <summary>
        /// Testeaza metoda getPret din clasa Rezervare.
        /// </summary>
        [TestMethod]
        public void GetPret()
        {
            int expectedPret = 100;
            var rezervare = new Rezervare("Ion", "Popa", 3, expectedPret, 1);
            int actualPret = rezervare.getPret();
            Assert.AreEqual(expectedPret, actualPret);
        }

        /// <summary>
        /// Testeaza metoda getCamera din clasa Rezervare.
        /// </summary>
        [TestMethod]
        public void GetCamera()
        {
            int expectedCamera = 1;
            var rezervare = new Rezervare("Io", "Doe", 3, 100, expectedCamera);
            int actualCamera = rezervare.getCamera();
            Assert.AreEqual(expectedCamera, actualCamera);
        }
    }
}
