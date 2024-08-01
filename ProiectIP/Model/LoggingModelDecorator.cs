using GestionareHotel;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareHotel
{
    /// <summary>
    /// Clasa LoggingModelDecorator implementeaza sablonul Decorator.
    /// Aceasta implementează interfața IModel pentru a comunica cu modelul.
    /// </summary>
    public class LoggingModelDecorator : IModel
    {
        private readonly IModel _decoratedModel;
        private readonly string _connectionString = "Data Source=mydatabase.db;Version=3;";

        /// <summary>
        /// Constructor pentru clasa Presenter.
        /// </summary>
        /// <param name="decoratedModel">Modelul aplicației decorat</param>
        public LoggingModelDecorator(IModel decoratedModel)
        {
            _decoratedModel = decoratedModel;
        }

        /// <summary>
        /// Metodă pentru inițializarea datelor.
        /// </summary>
        public void InitializeData()
        {
            _decoratedModel.InitializeData();
        }

        /// <summary>
        /// Insereaza o inregistrare in tabela logs.
        /// </summary>
        public bool AddCamera(Camera camera)
        {
            LogAction("AddCamera");
            return _decoratedModel.AddCamera(camera);
        }

        /// <summary>
        /// Insereaza o inregistrare in tabela logs.
        /// </summary>
        public bool AddRezervare(Rezervare rezervare)
        {
            LogAction("AddRezervare");
            return _decoratedModel.AddRezervare(rezervare);
        }

        /// <summary>
        /// Insereaza o inregistrare in tabela logs.
        /// </summary>
        public bool AddUser(User user)
        {
            LogAction("AddUser");
            return _decoratedModel.AddUser(user);
        }

        /// <summary>
        /// Insereaza o inregistrare in tabela logs.
        /// </summary>
        public bool DeleteCamera(int id)
        {
            LogAction("DeleteCamera");
            return _decoratedModel.DeleteCamera(id);
        }

        /// <summary>
        /// Insereaza o inregistrare in tabela logs.
        /// </summary>
        public bool DeleteRezervare(int id)
        {
            LogAction("DeleteRezervare");
            return _decoratedModel.DeleteRezervare(id);
        }

        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public List<int> GetNumereCamereLibere()
        {
            return _decoratedModel.GetNumereCamereLibere();
        }

        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public List<Camera> GetCamereLibere()
        {
            return _decoratedModel.GetCamereLibere();
        }

        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public List<Rezervare> GetRezervare()
        {
            return _decoratedModel.GetRezervare();
        }
        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public List<Camera> GetCamera()
        {
            return _decoratedModel.GetCamera();
        }
        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public List<int> GetIdRezervare()
        {
            return _decoratedModel.GetIdRezervare();
        }
        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public List<int> GetIdCamere()
        {
            return _decoratedModel.GetIdCamere();
        }

        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public List<Rezervare> SearchRezervareNume(string nume)
        {
            return _decoratedModel.SearchRezervareNume(nume);
        }

        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public List<Rezervare> SearchRezervarePrenume(string prenume)
        {
            return _decoratedModel.SearchRezervarePrenume(prenume);
        }

        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public List<Rezervare> SearchRezervareNumePrenume(string nume, string prenume)
        {
            return _decoratedModel.SearchRezervareNumePrenume(nume, prenume);
        }

        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public bool IsCameraGoala(int nr)
        {
            return _decoratedModel.IsCameraGoala(nr);
        }

        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public bool ValidateUser(string username, string password)
        {
            return _decoratedModel.ValidateUser(username, password);
        }

        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public int GetPrivilegeLevel(string username)
        {
            return _decoratedModel.GetPrivilegeLevel(username);
        }

        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public int CalculeazaPretRezervare(int cameraNumar, int zile)
        {
            return _decoratedModel.CalculeazaPretRezervare(cameraNumar, zile);
        }

        /// <summary>
        /// Nu insereaza o inregistrare in tabela logs.
        /// Necesara datorita implementarii interfetei IModel.
        /// </summary>
        public int GetUserIdByCredentials(string nume, string prenume)
        {
            return _decoratedModel.GetUserIdByCredentials(nume, prenume);
        }

        /// <summary>
        /// Adaugă o inregistrare de tip log in baza de date.
        /// </summary>
        /// <param name="item">Obiectul de tip Log care trebuie adăugat</param>
        /// <returns>True dacă adăugarea a fost realizată cu succes, altfel False</returns>
        private void LogAction(string item)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                string createTableSql = "CREATE TABLE IF NOT EXISTS logs (id INTEGER PRIMARY KEY, start_date TEXT, item TEXT)";
                string insertLogSql = "INSERT INTO logs (start_date, item) VALUES (@start_date, @item)";

                SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection);
                SQLiteCommand insertLogCommand = new SQLiteCommand(insertLogSql, connection);

                insertLogCommand.Parameters.AddWithValue("@start_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                insertLogCommand.Parameters.AddWithValue("@item", item);

                try
                {
                    connection.Open();
                    createTableCommand.ExecuteNonQuery();
                    insertLogCommand.ExecuteNonQuery();
                    Console.WriteLine("Log entry created!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error logging action: {ex.Message}");
                }
            }
        }
    }
}
