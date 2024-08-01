using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareHotel
{
    /// <summary>
    /// Clasa care reprezintă o rezervare în hotel.
    /// </summary>
    public class Rezervare
    {
        private string _nume;
        private string _prenume;
        private int _numarZile;
        private int _pret;
        private int _camera;

        /// <summary>
        /// Constructor pentru crearea unei noi rezervări.
        /// </summary>
        /// <param name="nume">Numele clientului</param>
        /// <param name="prenume">Prenumele clientului</param>
        /// <param name="nrZile">Numărul de zile pentru care s-a făcut rezervarea</param>
        /// <param name="pret">Pretul rezervării</param>
        /// <param name="cam">Numărul camerei rezervate</param>
        public Rezervare(string nume, string prenume, int nrZile, int pret, int cam)
        {
            _nume = nume;
            _prenume = prenume;
            _numarZile = nrZile;
            _pret = pret;
            _camera = cam;
        }

        /// <summary>
        /// Constructor pentru crearea unei rezervări folosind o linie dintr-un DataRow.
        /// </summary>
        /// <param name="row">Linia din DataRow care conține datele rezervării</param>
        public Rezervare(DataRow row)
        {
            _nume = row[1].ToString();
            _prenume = row[2].ToString();

            int nrZile, pret, cam;
            if (!int.TryParse(row[3].ToString(), out nrZile))
            {
                nrZile = 0;
            }
            if (!int.TryParse(row[4].ToString(), out pret))
            {
                pret = 0;
            }
            if (!int.TryParse(row[5].ToString(), out cam))
            {
                cam = 0;
            }

            _numarZile = nrZile;
            _pret = pret;
            _camera = cam;
        }

        /// <summary>
        /// Returnează numele clientului.
        /// </summary>
        /// <returns>Numele clientului</returns>
        public string getNume()
        {
            return _nume;
        }

        /// <summary>
        /// Returnează prenumele clientului.
        /// </summary>
        /// <returns>Prenumele clientului</returns>
        public string getPrenume()
        {
            return _prenume;
        }

        /// <summary>
        /// Returnează numărul de zile ale rezervării.
        /// </summary>
        /// <returns>Numărul de zile</returns>
        public int getZile()
        {
            return _numarZile;
        }

        /// <summary>
        /// Returnează prețul rezervării.
        /// </summary>
        /// <returns>Prețul rezervării</returns>
        public int getPret()
        {
            return _pret;
        }

        /// <summary>
        /// Returnează numărul camerei rezervate.
        /// </summary>
        /// <returns>Numărul camerei</returns>
        public int getCamera()
        {
            return _camera;
        }
    }
}
