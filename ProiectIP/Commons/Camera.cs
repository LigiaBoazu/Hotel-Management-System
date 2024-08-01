using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareHotel
{
    /// <summary>
    /// Clasa care reprezintă o cameră în hotel.
    /// </summary>
    public class Camera
    {
        private int _numar;
        private int _tarif;
        private int _ocupata;

        /// <summary>
        /// Constructor pentru crearea unei noi camere.
        /// </summary>
        /// <param name="numar">Numărul camerei</param>
        /// <param name="tarif">Tariful camerei</param>
        /// <param name="ocupata">Starea de ocupare a camerei (0 - liberă, 1 - ocupată)</param>
        public Camera(int numar, int tarif, int ocupata)
        {
            _numar = numar;
            _tarif = tarif;
            _ocupata = ocupata;
        }

        /// <summary>
        /// Constructor pentru crearea unei camere folosind o linie dintr-un DataRow.
        /// </summary>
        /// <param name="row">Linia din DataRow care conține datele camerei</param>
        public Camera(DataRow row)
        {
            if (row == null) throw new ArgumentNullException(nameof(row));

            _numar = row[0] != DBNull.Value ? Convert.ToInt32(row[1]) : 0;
            _tarif = row[1] != DBNull.Value ? Convert.ToInt32(row[2]) : 0;
            _ocupata = row[2] != DBNull.Value ? Convert.ToInt32(row[3]) : 0;
        }

        /// <summary>
        /// Returnează numărul camerei.
        /// </summary>
        /// <returns>Numărul camerei</returns>
        public int getNumar()
        {
            return _numar;
        }

        /// <summary>
        /// Returnează tariful camerei.
        /// </summary>
        /// <returns>Tariful camerei</returns>
        public int getTarif()
        {
            return _tarif;
        }

        /// <summary>
        /// Returnează starea de ocupare a camerei.
        /// </summary>
        /// <returns>Starea de ocupare a camerei (0 - liberă, 1 - ocupată)</returns>
        public int getOcupat()
        {
            return _ocupata;
        }
    }
}
