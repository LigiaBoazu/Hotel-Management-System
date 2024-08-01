using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareHotel
{
    /// <summary>
    /// Interfața care definește comportamentul unui presenter în cadrul aplicației de gestionare a hotelului.
    /// </summary>
    public interface IPresenter
    {
        /// <summary>
        /// Metodă pentru adăugarea unei rezervări în sistem.
        /// </summary>
        /// <param name="rezervare">Obiectul Rezervare care urmează să fie adăugat</param>
        void AddRezervare(Rezervare rezervare);

        /// <summary>
        /// Metodă pentru adăugarea unei camere în sistem.
        /// </summary>
        /// <param name="camera">Obiectul Camera care urmează să fie adăugat</param>
        void AddCamera(Camera camera);

        /// <summary>
        /// Metodă pentru adăugarea unui utilizator în sistem.
        /// </summary>
        /// <param name="user">Obiectul User care urmează să fie adăugat</param>
        void AddUser(User user);

        /// <summary>
        /// Metodă pentru inițializarea presenterului.
        /// </summary>
        void Init();
    }
}
