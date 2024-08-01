using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareHotel
{
    /// <summary>
    /// Clasa Presenter care gestionează interacțiunea între model și interfața utilizator.
    /// </summary>
    public class Presenter : IPresenter
    {
        private IModel _model; 
        private IView _view;

        /// <summary>
        /// Constructor pentru clasa Presenter.
        /// </summary>
        /// <param name="view">Interfața utilizator</param>
        /// <param name="model">Modelul aplicației</param>
        public Presenter(IView view, IModel model)
        {
            _model = model;
            _view = view;
        }

        /// <summary>
        /// Metodă pentru inițializarea datelor.
        /// </summary>
        public void Init()
        {
            _model.InitializeData(); 
        }

        /// <summary>
        /// Metodă pentru adăugarea unei rezervări.
        /// </summary>
        /// <param name="rezervare">Obiectul Rezervare care urmează să fie adăugat</param>
        public void AddRezervare(Rezervare rezervare)
        {
            // Verificăm dacă adăugarea rezervării în baza de date a fost cu succes sau nu
            if (_model.AddRezervare(rezervare))
            {
                _view.Display("Am rezervat cu succes."); 
            }
            else
            {
                _view.Display("Eroare la inserarea rezervarii în baza de date."); 
            }
        }

        /// <summary>
        /// Metodă pentru adăugarea unei camere.
        /// </summary>
        /// <param name="camera">Obiectul Camera care urmează să fie adăugat</param>
        public void AddCamera(Camera camera)
        {
            // Verificăm dacă adăugarea camerei în baza de date a fost cu succes sau nu
            if (_model.AddCamera(camera))
            {
                _view.Display("Am adaugat camera cu succes.");
            }
            else
            {
                _view.Display("Eroare la inserarea camerei în baza de date."); 
            }
        }

        /// <summary>
        /// Metodă pentru adăugarea unui utilizator.
        /// </summary>
        /// <param name="user">Obiectul User care urmează să fie adăugat</param>
        public void AddUser(User user)
        {
            // Verificăm dacă adăugarea utilizatorului în baza de date a fost cu succes sau nu
            if (_model.AddUser(user))
            {
                _view.Display("Am adaugat utilizatorul cu succes."); 
            }
            else
            {
                _view.Display("Eroare la inserarea utilizatorului în baza de date.");
            }
        }

        /// <summary>
        /// Metodă pentru stergerea unei camere
        /// </summary>
        /// <param name="id">Obiectul User care urmează să fie adăugat</param>
        public void DeleteCamera(int id)
        {
            // Verificăm dacă adăugarea utilizatorului în baza de date a fost cu succes sau nu
            if (_model.DeleteCamera(id))
            {
                _view.Display("Camera a fost eliminată din sistem.");
            }
            else
            {
                _view.Display("Eroare la ștergerea camerei din baza de date.");
            }
        }

        /// <summary>
        /// Metodă pentru stergerea unei rezervări
        /// </summary>
        /// <param name="id">Obiectul User care urmează să fie adăugat</param>
        public void DeleteRezervare(int id)
        {
            // Verificăm dacă adăugarea utilizatorului în baza de date a fost cu succes sau nu
            if (_model.DeleteRezervare(id))
            {
                _view.Display("Rezervarea a fost eliminată din sistem.");
            }
            else
            {
                _view.Display("Eroare la ștergerea rezervării din baza de date.");
            }
        }
    }
}
