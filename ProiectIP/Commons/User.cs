using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareHotel
{
    /// <summary>
    /// Clasa care reprezintă un utilizator al sistemului.
    /// </summary>
    public class User
    {
        private string _user;
        private string _pass;
        private int _privilegiu;

        /// <summary>
        /// Constructor pentru crearea unui nou utilizator.
        /// </summary>
        /// <param name="user">Numele de utilizator</param>
        /// <param name="pass">Parola utilizatorului</param>
        /// <param name="privilegiu">Nivelul de privilegiu al utilizatorului</param>
        public User(string user, string pass, int privilegiu)
        {
            _user = user;
            _pass = pass;
            _privilegiu = privilegiu;
        }

        /// <summary>
        /// Constructor pentru crearea unui utilizator folosind o linie dintr-un DataRow.
        /// </summary>
        /// <param name="row">Linia din DataRow care conține datele utilizatorului</param>
        public User(DataRow row)
        {
            _user = row[0].ToString();
            _pass = row[1].ToString();
            _privilegiu = (int)row[2];
        }

        /// <summary>
        /// Returnează numele de utilizator.
        /// </summary>
        /// <returns>Numele de utilizator</returns>
        public string getUser()
        {
            return _user;
        }

        /// <summary>
        /// Returnează parola utilizatorului.
        /// </summary>
        /// <returns>Parola utilizatorului</returns>
        public string getPass()
        {
            return _pass;
        }

        /// <summary>
        /// Returnează nivelul de privilegiu al utilizatorului.
        /// </summary>
        /// <returns>Nivelul de privilegiu al utilizatorului</returns>
        public int getPrivilegiu()
        {
            return _privilegiu;
        }
    }
}
