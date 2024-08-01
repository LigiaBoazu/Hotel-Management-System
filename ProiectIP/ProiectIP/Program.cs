using System;
using System.Windows.Forms;
using Login;

namespace GestionareHotel
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IModel model = new Model();
            IModel loggingModel = new LoggingModelDecorator(model);
            IView view = new FormLogare(loggingModel);
            IPresenter presenter = new Presenter(view, loggingModel);
            view.SetPresenter(presenter);
            Application.Run((FormLogare)view);
        }
    }
}
