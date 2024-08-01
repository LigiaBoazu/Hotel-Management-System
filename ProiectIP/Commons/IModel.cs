using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareHotel
{
    /// <summary>
    /// Interfața pentru modelul aplicației.
    /// </summary>
    public interface IModel
    {
        /// <summary>
        /// Adaugă o cameră în sistem.
        /// </summary>
        bool AddCamera(Camera camera);

        /// <summary>
        /// Adaugă o rezervare în sistem.
        /// </summary>
        bool AddRezervare(Rezervare rezervare);

        /// <summary>
        /// Adaugă un utilizator în sistem.
        /// </summary>
        bool AddUser(User user);

        /// <summary>
        /// Returnează lista camerelor libere din sistem.
        /// </summary>
        List<Camera> GetCamereLibere();

        /// <summary>
        /// Șterge o cameră din sistem pe baza identificatorului său.
        /// </summary>
        bool DeleteCamera(int id);

        /// <summary>
        /// Șterge o rezervare din sistem pe baza numelui și prenumelui clientului.
        /// </summary>
        bool DeleteRezervare(int id);

        /// <summary>
        /// Returnează lista numerelor camerelor libere din sistem.
        /// </summary>
        List<int> GetNumereCamereLibere();

        /// <summary>
        /// Returnează lista tuturor rezervărilor din sistem.
        /// </summary>
        List<Rezervare> GetRezervare();

        /// <summary>
        /// Returnează lista tuturor id-urilorcamerelor din sistem.
        /// </summary>
        List<int> GetIdCamere();

        // <summary>
        /// Returnează lista tuturor id-urilor rezervărilor din sistem.
        /// </summary>
        List<int> GetIdRezervare();

        /// <summary>
        /// Returnează lista tuturor camerelor din sistem.
        /// </summary>
        List<Camera> GetCamera();

        /// <summary>
        /// Caută rezervările în sistem pe baza numelui clientului.
        /// </summary>
        List<Rezervare> SearchRezervareNume(String nume);

        /// <summary>
        /// Caută rezervările în sistem pe baza prenumelui clientului.
        /// </summary>
        List<Rezervare> SearchRezervarePrenume(String prenume);

        /// <summary>
        /// Caută rezervările în sistem pe baza numelui și prenumelui clientului.
        /// </summary>
        List<Rezervare> SearchRezervareNumePrenume(String nume, String prenume);

        /// <summary>
        /// Verifică dacă o cameră este liberă pe baza numărului său.
        /// </summary>
        bool IsCameraGoala(int nr);

        /// <summary>
        /// Validează datele de autentificare ale unui utilizator.
        /// </summary>
        bool ValidateUser(string username, string password);

        /// <summary>
        /// Returneaza nivelul de privileziu a unui utilizator.
        /// </summary>
        int GetPrivilegeLevel(string username);

        /// <summary>
        /// Inițializează datele în sistem.
        /// </summary>
        void InitializeData();

        /// <summary>
        /// Calculeaza pretul de cazare.
        /// </summary>
        int CalculeazaPretRezervare(int cameraNumar, int zile);

        /// <summary>
        /// Returneaza ID-ul unui utilizator dupa nume si prenume.
        /// </summary>

        int GetUserIdByCredentials(string nume, string prenume);
    }
}
