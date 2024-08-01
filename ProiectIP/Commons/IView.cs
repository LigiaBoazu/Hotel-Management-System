using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareHotel
{
    /// <summary>
    /// Interfața care definește comportamentul unei view-uri în cadrul aplicației de gestionare a hotelului.
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Metodă pentru setarea presenterului asociat acestei view-uri.
        /// </summary>
        /// <param name="presenter">Presenter-ul asociat acestei view-uri</param>
        void SetPresenter(IPresenter presenter);

        /// <summary>
        /// Metodă pentru afișarea unui text în interfața utilizator.
        /// </summary>
        /// <param name="text">Textul care urmează să fie afișat</param>
        void Display(string text);
    }
}
