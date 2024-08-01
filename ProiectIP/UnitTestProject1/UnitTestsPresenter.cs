using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace GestionareHotel.Tests
{
    /// <summary>
    /// Clasa de test pentru Presenter.
    /// </summary>
    [TestClass]
    public class PresenterTests
    {
        /// <summary>
        /// Implementare pentru IView în scop de testare.
        /// </summary>
        private class MockView : IView
        {
            public string LastDisplayedMessage { get; private set; }

            public void Display(string message)
            {
                LastDisplayedMessage = message;
            }

            public void SetPresenter(IPresenter presenter)
            {
            }
        }

        /// <summary>
        /// Implementare pentru IModel în scop de testare.
        /// </summary>
        private class MockModel : IModel
        {
            public bool AddRezervareResult { get; set; }
            public bool AddCameraResult { get; set; }
            public bool AddUserResult { get; set; }
            public bool DeleteCameraResult { get; set; }
            public bool DeleteRezervareResult { get; set; }

            public bool AddRezervare(Rezervare rezervare)
            {
                return AddRezervareResult;
            }

            public bool AddCamera(Camera camera)
            {
                return AddCameraResult;
            }

            public bool AddUser(User user)
            {
                return AddUserResult;
            }

            public void InitializeData()
            {
                throw new NotImplementedException();
            }

            public int CalculeazaPretRezervare(int nrNopti, int tarif)
            {
                throw new NotImplementedException();
            }

            public bool DeleteCamera(int id)
            {
                return DeleteCameraResult;
            }

            public bool DeleteRezervare(int id)
            {
                return DeleteRezervareResult;
            }

            public List<Camera> GetCamera()
            {
                throw new NotImplementedException();
            }

            public List<Camera> GetCamereLibere()
            {
                throw new NotImplementedException();
            }

            public List<Camera> GetCamereLiberePerioadaPret(int tarif)
            {
                throw new NotImplementedException();
            }

            public List<int> GetIdCamere()
            {
                throw new NotImplementedException();
            }

            public List<int> GetIdRezervare()
            {
                throw new NotImplementedException();
            }

            public List<int> GetNumereCamereLibere()
            {
                throw new NotImplementedException();
            }

            public int GetPrivilegeLevel(string username)
            {
                throw new NotImplementedException();
            }

            public List<Rezervare> GetRezervare()
            {
                throw new NotImplementedException();
            }

            public int GetUserIdByCredentials(string username, string password)
            {
                throw new NotImplementedException();
            }

            public bool IsCameraGoala(int id)
            {
                throw new NotImplementedException();
            }

            public List<Rezervare> SearchRezervareNume(string nume)
            {
                throw new NotImplementedException();
            }

            public List<Rezervare> SearchRezervarePrenume(string prenume)
            {
                throw new NotImplementedException();
            }

            public List<Rezervare> SearchRezervareNumePrenume(string nume, string prenume)
            {
                throw new NotImplementedException();
            }

            public bool ValidateUser(string username, string password)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Testează metoda AddRezervare când returnează true.
        /// </summary>
        [TestMethod]
        public void AddRezervare_WhenModelReturnsTrue_ShouldDisplaySuccessMessage()
        {
            var mockModel = new MockModel();
            var mockView = new MockView();
            var presenter = new Presenter(mockView, mockModel);
            var rezervare = new Rezervare("Mircea", "Mihai", 3, 150, 1);
            mockModel.AddRezervareResult = true;

            presenter.AddRezervare(rezervare);

            Assert.AreEqual("Am rezervat cu succes.", mockView.LastDisplayedMessage);
        }

        /// <summary>
        /// Testează metoda AddRezervare când returnează false.
        /// </summary>
        [TestMethod]
        public void AddRezervare_WhenModelReturnsFalse_ShouldDisplayErrorMessage()
        {
            var mockModel = new MockModel();
            var mockView = new MockView();
            var presenter = new Presenter(mockView, mockModel);
            var rezervare = new Rezervare("Mircea", "Mihai", 3, 150, 1);
            mockModel.AddRezervareResult = false;

            presenter.AddRezervare(rezervare);

            Assert.AreEqual("Eroare la inserarea rezervarii în baza de date.", mockView.LastDisplayedMessage);
        }

        /// <summary>
        /// Testează metoda AddCamera când returnează true.
        /// </summary>
        [TestMethod]
        public void AddCamera_WhenModelReturnsTrue_ShouldDisplaySuccessMessage()
        {
            var mockModel = new MockModel();
            var mockView = new MockView();
            var presenter = new Presenter(mockView, mockModel);
            var camera = new Camera(101, 200, 0);
            mockModel.AddCameraResult = true;

            presenter.AddCamera(camera);

            Assert.AreEqual("Am adaugat camera cu succes.", mockView.LastDisplayedMessage);
        }

        /// <summary>
        /// Testează metoda AddCamera când returnează false.
        /// </summary>
        [TestMethod]
        public void AddCamera_WhenModelReturnsFalse_ShouldDisplayErrorMessage()
        {
            var mockModel = new MockModel();
            var mockView = new MockView();
            var presenter = new Presenter(mockView, mockModel);
            var camera = new Camera(101, 200, 0);
            mockModel.AddCameraResult = false;

            presenter.AddCamera(camera);

            Assert.AreEqual("Eroare la inserarea camerei în baza de date.", mockView.LastDisplayedMessage);
        }

        /// <summary>
        /// Testează metoda AddUser când returnează true.
        /// </summary>
        [TestMethod]
        public void AddUser_WhenModelReturnsTrue_ShouldDisplaySuccessMessage()
        {
            var mockModel = new MockModel();
            var mockView = new MockView();
            var presenter = new Presenter(mockView, mockModel);
            var user = new User("popaandrei", "popaandrei", 1);
            mockModel.AddUserResult = true;

            presenter.AddUser(user);

            Assert.AreEqual("Am adaugat utilizatorul cu succes.", mockView.LastDisplayedMessage);
        }

        /// <summary>
        /// Testează metoda AddUser când returnează false.
        /// </summary>
        [TestMethod]
        public void AddUser_WhenModelReturnsFalse_ShouldDisplayErrorMessage()
        {
            var mockModel = new MockModel();
            var mockView = new MockView();
            var presenter = new Presenter(mockView, mockModel);
            var user = new User("popaandrei", "popaandrei", 1);
            mockModel.AddUserResult = false;

            presenter.AddUser(user);

            Assert.AreEqual("Eroare la inserarea utilizatorului în baza de date.", mockView.LastDisplayedMessage);
        }

        /// <summary>
        /// Testează metoda DeleteCamera când returnează true.
        /// </summary>
        [TestMethod]
        public void DeleteCamera_WhenModelReturnsTrue_ShouldDisplaySuccessMessage()
        {
            var mockModel = new MockModel();
            var mockView = new MockView();
            var presenter = new Presenter(mockView, mockModel);
            int cameraId = 101;
            mockModel.DeleteCameraResult = true; 

            presenter.DeleteCamera(cameraId);

            Assert.AreEqual("Camera a fost eliminată din sistem.", mockView.LastDisplayedMessage);
        }

        /// <summary>
        /// Testează metoda DeleteCamera când returnează false.
        /// </summary>
        [TestMethod]
        public void DeleteCamera_WhenModelReturnsFalse_ShouldDisplayErrorMessage()
        {
            var mockModel = new MockModel();
            var mockView = new MockView();
            var presenter = new Presenter(mockView, mockModel);
            int cameraId = 101;
            mockModel.DeleteCameraResult = false; 

            presenter.DeleteCamera(cameraId);

            Assert.AreEqual("Eroare la ștergerea camerei din baza de date.", mockView.LastDisplayedMessage);
        }

        /// <summary>
        /// Testează metoda DeleteRezervare când returnează true.
        /// </summary>
        [TestMethod]
        public void DeleteRezervare_WhenModelReturnsTrue_ShouldDisplaySuccessMessage()
        {
            var mockModel = new MockModel();
            var mockView = new MockView();
            var presenter = new Presenter(mockView, mockModel);
            int rezervareId = 1;
            mockModel.DeleteRezervareResult = true; 

            presenter.DeleteRezervare(rezervareId);

            Assert.AreEqual("Rezervarea a fost eliminată din sistem.", mockView.LastDisplayedMessage);
        }

        /// <summary>
        /// Testează metoda DeleteRezervare când returnează false.
        /// </summary>
        [TestMethod]
        public void DeleteRezervare_WhenModelReturnsFalse_ShouldDisplayErrorMessage()
        {
            var mockModel = new MockModel();
            var mockView = new MockView();
            var presenter = new Presenter(mockView, mockModel);
            int rezervareId = 1;
            mockModel.DeleteRezervareResult = false; 

            presenter.DeleteRezervare(rezervareId);

            Assert.AreEqual("Eroare la ștergerea rezervării din baza de date.", mockView.LastDisplayedMessage);
        }
    }
}
