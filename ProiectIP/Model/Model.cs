using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.Sql;
using System.Data.SQLite;
using System.Data;
using System.Transactions;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace GestionareHotel
{
    /// <summary>
    /// Clasa care implementează interfața IModel pentru gestionarea datelor în aplicație.
    /// </summary>
    public class Model : IModel
    {
        /// <summary>
        /// Inițializează datele necesare în baza de date.
        /// </summary>
        public void InitializeData()
        {
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string createTableCamere = "CREATE TABLE IF NOT EXISTS camere (id INTEGER PRIMARY KEY, numar INTEGER, tarif INTEGER, ocupata INTEGER)";
            string createTableRezervari = "CREATE TABLE IF NOT EXISTS rezervari (id INTEGER PRIMARY KEY, nume TEXT, prenume TEXT, zile INTEGER, pret INTEGER, camera INTEGER)";
            string createTableUser = "CREATE TABLE IF NOT EXISTS useri (id INTEGER PRIMARY KEY, user TEXT, pass TEXT, privilegiu INTEGER)";
            string checkUserSql = "SELECT COUNT(*) FROM useri WHERE user = @user";
            string insertSql = "INSERT INTO useri (user, pass, privilegiu) VALUES (@user, @pass, @privilegiu)";

            SQLiteCommand createTableCamereCommand = new SQLiteCommand(createTableCamere, connection);
            SQLiteCommand createTableRezervariCommand = new SQLiteCommand(createTableRezervari, connection);
            SQLiteCommand createTableUserCommand = new SQLiteCommand(createTableUser, connection);
            SQLiteCommand checkUserCommand = new SQLiteCommand(checkUserSql, connection);
            SQLiteCommand insertCommand = new SQLiteCommand(insertSql, connection);
            checkUserCommand.Parameters.AddWithValue("@user", "admin");

            insertCommand.Parameters.AddWithValue("@user", "admin");
            insertCommand.Parameters.AddWithValue("@pass", "admin");
            insertCommand.Parameters.AddWithValue("@privilegiu", 0);

            try
            {
                connection.Open();
                createTableRezervariCommand.ExecuteNonQuery();
                createTableCamereCommand.ExecuteNonQuery();
                createTableUserCommand.ExecuteNonQuery();
                int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());
                if (userCount == 0)
                {
                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Adminul a fost adăugat!");
                }
                else
                {
                    Console.WriteLine("Adminul există deja!");
                }
                Console.WriteLine("Tables created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Adaugă o cameră în baza de date.
        /// </summary>
        /// <param name="camera">Obiectul de tip Camera care trebuie adăugat</param>
        /// <returns>True dacă adăugarea a fost realizată cu succes, altfel False</returns>
        public bool AddCamera(Camera camera)
        {
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string createTableSql = "CREATE TABLE IF NOT EXISTS camere (id INTEGER PRIMARY KEY, numar INTEGER, tarif INTEGER, ocupata INTEGER)";
                string insertSql = "INSERT INTO camere (numar, tarif, ocupata) VALUES (@numar, @tarif, @ocupata)";

                SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection);
                SQLiteCommand insertCommand = new SQLiteCommand(insertSql, connection);

                // Parameters
                insertCommand.Parameters.AddWithValue("@numar", camera.getNumar());
                insertCommand.Parameters.AddWithValue("@tarif", camera.getTarif());
                insertCommand.Parameters.AddWithValue("@ocupata", 0);

                try
                {
                    connection.Open();
                    createTableCommand.ExecuteNonQuery();
                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Table created and data inserted!");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }
        /// <summary>
        /// Adaugă o rezervare în baza de date.
        /// </summary>
        /// <param name="rezervare">Obiectul de tip Rezervare care trebuie adăugat</param>
        /// <returns>True dacă adăugarea a fost realizată cu succes, altfel False</returns>
        public bool AddRezervare(Rezervare rezervare)
        {
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string createTableSql = "CREATE TABLE IF NOT EXISTS rezervari (id INTEGER PRIMARY KEY, nume TEXT, prenume TEXT, zile INTEGER, pret INTEGER, camera INTEGER)";
                string insertSql = "INSERT INTO rezervari (nume, prenume, zile, pret, camera) VALUES (@nume, @prenume, @zile, @pret, @camera)";
                string updateCameraSql = "UPDATE camere SET ocupata = 1 WHERE numar = @numar";

                SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection);
                SQLiteCommand insertCommand = new SQLiteCommand(insertSql, connection);
                SQLiteCommand updateCameraCommand = new SQLiteCommand(updateCameraSql, connection);

                // Parameters
                insertCommand.Parameters.AddWithValue("@nume", rezervare.getNume());
                insertCommand.Parameters.AddWithValue("@prenume", rezervare.getPrenume());
                insertCommand.Parameters.AddWithValue("@zile", rezervare.getZile());
                insertCommand.Parameters.AddWithValue("@pret", rezervare.getPret());
                insertCommand.Parameters.AddWithValue("@camera", rezervare.getCamera());
                updateCameraCommand.Parameters.AddWithValue("@numar", rezervare.getCamera());


                try
                {
                    connection.Open();
                    createTableCommand.ExecuteNonQuery();
                    insertCommand.ExecuteNonQuery();
                    updateCameraCommand.ExecuteNonQuery();
                    Console.WriteLine("Table created and data inserted!");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }

        /// <summary>
        /// Metoda pentru criptarea parolei.
        /// </summary>
        /// <param name="password">Obiectul de tip password care trebuie criptat</param>
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Adaugă un utilizator în baza de date.
        /// </summary>
        /// <param name="user">Obiectul de tip User care trebuie adăugat</param>
        /// <returns>True dacă adăugarea a fost realizată cu succes, altfel False</returns>
        public bool AddUser(User user)
        {
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string createTableSql = "CREATE TABLE IF NOT EXISTS useri (id INTEGER PRIMARY KEY, user TEXT, pass TEXT, privilegiu INTEGER)";
                string insertSql = "INSERT INTO useri (user, pass, privilegiu) VALUES (@user, @pass, @privilegiu)";

                SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection);
                SQLiteCommand insertCommand = new SQLiteCommand(insertSql, connection);

                // Hash the password
                string hashedPassword = HashPassword(user.getPass());

                // Parameters
                insertCommand.Parameters.AddWithValue("@user", user.getUser());
                insertCommand.Parameters.AddWithValue("@pass", user.getPass());
                insertCommand.Parameters.AddWithValue("@privilegiu", user.getPrivilegiu());

                try
                {
                    connection.Open();
                    createTableCommand.ExecuteNonQuery();
                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Table created and data inserted!");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }


        /// <summary>
        /// Returnează o listă de camere libere din baza de date.
        /// </summary>
        /// <returns>O listă de obiecte de tip Camera care reprezintă camerele libere</returns>
        public List<Camera> GetCamereLibere()
        {
            List<Camera> listaLibere = new List<Camera>();
            String query = "SELECT * FROM camere WHERE ocupata = 0";
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            DataTable dt;

            using (var ds = new DataSet())
            {
                using (var da = new SQLiteDataAdapter(query, connectionString))
                {
                    using (var tran = new TransactionScope())
                    {
                        ds.Clear();
                        da.Fill(ds);
                        dt = ds.Tables[0];
                        tran.Complete();
                    }
                }
            }
            foreach (DataRow row in dt.Rows)
            {
                Camera camera = new Camera(row);
                listaLibere.Add(camera);
            }
            return listaLibere;
        }

        /// <summary>
        /// Șterge o cameră din baza de date după id.
        /// </summary>
        /// <param name="id">Id-ul camerei care trebuie ștearsă</param>
        /// <returns>True dacă ștergerea a fost realizată cu succes, altfel False</returns>
        public bool DeleteCamera(int id)
        {
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string deleteSql = "DELETE FROM camere WHERE id = @id";

                SQLiteCommand deleteCommand = new SQLiteCommand(deleteSql, connection);

                // Parameters
                deleteCommand.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    deleteCommand.ExecuteNonQuery();
                    Console.WriteLine("Camera stearsa!");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }

        /// <summary>
        /// Șterge o rezervare din baza de date după nume și prenume.
        /// </summary>
        /// <param name="nume">Numele rezervării care trebuie ștearsă</param>
        /// <param name="prenume">Prenumele rezervării care trebuie ștearsă</param>
        /// <returns>True dacă ștergerea a fost realizată cu succes, altfel False</returns>
        public bool DeleteRezervare(int id)
        {
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string deleteSql = "DELETE FROM rezervari WHERE id = @id";

                SQLiteCommand deleteCommand = new SQLiteCommand(deleteSql, connection);

                // Parameters
                deleteCommand.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    deleteCommand.ExecuteNonQuery();
                    Console.WriteLine("Rezervare stearsa!");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }

        /// <summary>
        /// Returnează o listă de rezervări din baza de date.
        /// </summary>
        /// <returns>O listă de obiecte de tip Rezervare care reprezintă rezervările</returns>
        public List<Rezervare> GetRezervare()
        {
            List<Rezervare> listaRezervari = new List<Rezervare>();
            String query = "SELECT * FROM rezervari";
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            DataTable dt;

            using (var ds = new DataSet())
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var da = new SQLiteDataAdapter(command))
                        {
                            using (var tran = new TransactionScope())
                            {
                                ds.Clear();
                                da.Fill(ds);
                                dt = ds.Tables[0];
                                tran.Complete();
                            }
                        }
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        Rezervare rezervare = new Rezervare(row);
                        listaRezervari.Add(rezervare);
                    }
                    return listaRezervari;
                }
            }
        }
        /// <summary>
        /// Returnează o listă de id-uri de rezervări din baza de date.
        /// </summary>
        /// <returns>O listă de obiecte de tip Rezervare care reprezintă rezervările</returns>
        public List<int> GetIdRezervare()
        {
            List<int> listaIdRezervari = new List<int>();
            String query = "SELECT * FROM rezervari";
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            DataTable dt;

            using (var ds = new DataSet())
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var da = new SQLiteDataAdapter(command))
                        {
                            using (var tran = new TransactionScope())
                            {
                                ds.Clear();
                                da.Fill(ds);
                                dt = ds.Tables[0];
                                tran.Complete();
                            }
                        }
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        int idRezervare = Convert.ToInt32(row[0]);
                        listaIdRezervari.Add(idRezervare);
                    }
                    return listaIdRezervari;
                }
            }
        }
        /// <summary>
        /// Returnează o listă de id-uri de rezervări din baza de date.
        /// </summary>
        /// <returns>O listă de obiecte de tip Rezervare care reprezintă rezervările</returns>
        public List<int> GetIdCamere()
        {
            List<int> listaIdCamere = new List<int>();
            String query = "SELECT * FROM camere";
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            DataTable dt;

            using (var ds = new DataSet())
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var da = new SQLiteDataAdapter(command))
                        {
                            using (var tran = new TransactionScope())
                            {
                                ds.Clear();
                                da.Fill(ds);
                                dt = ds.Tables[0];
                                tran.Complete();
                            }
                        }
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        int idCamere = Convert.ToInt32(row[0]);
                        listaIdCamere.Add(idCamere);
                    }
                    return listaIdCamere;
                }
            }
        }
        /// <summary>
        /// Returnează o listă de rezervări din baza de date.
        /// </summary>
        /// <returns>O listă de obiecte de tip Rezervare care reprezintă rezervările</returns>
        public List<Camera> GetCamera()
        {
            List<Camera> listaCamere = new List<Camera>();
            String query = "SELECT * FROM camere";
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            DataTable dt;

            using (var ds = new DataSet())
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var da = new SQLiteDataAdapter(command))
                        {
                            using (var tran = new TransactionScope())
                            {
                                ds.Clear();
                                da.Fill(ds);
                                dt = ds.Tables[0];
                                tran.Complete();
                            }
                        }
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        Camera camera = new Camera(row);
                        listaCamere.Add(camera);
                    }
                    return listaCamere;
                }
            }
        }

        /// <summary>
        /// Returnează o listă de rezervări din baza de date, filtrate după nume.
        /// </summary>
        /// <param name="nume">Numele după care să fie filtrate rezervările</param>
        /// <returns>O listă de obiecte de tip Rezervare care reprezintă rezervările filtrate</returns>
        public List<Rezervare> SearchRezervareNume(String nume)
        {
            List<Rezervare> listaRezervari = new List<Rezervare>();
            String query = "SELECT * FROM rezervari WHERE nume = @nume";
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            DataTable dt;

            using (var ds = new DataSet())
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nume", nume);

                        using (var da = new SQLiteDataAdapter(command))
                        {
                            using (var tran = new TransactionScope())
                            {
                                ds.Clear();
                                da.Fill(ds);
                                dt = ds.Tables[0];
                                tran.Complete();
                            }
                        }
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        Rezervare rezervare = new Rezervare(row);
                        listaRezervari.Add(rezervare);
                    }
                    return listaRezervari;
                }
            }
        }

        public int GetUserIdByCredentials(string nume, string prenume)
        {
            int userId = -1;
            string query = "SELECT id FROM useri WHERE nume = @nume AND prenume = @prenume";
            string connectionString = "Data Source=mydatabase.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@nume", nume);
                command.Parameters.AddWithValue("@prenume", prenume);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in GetUserIdByName: {ex.Message}");
                }
            }
            return userId;
        }

        /// <summary>
        /// Returnează o listă de rezervări din baza de date, filtrate după prenume.
        /// </summary>
        /// <param name="prenume">Prenumele după care să fie filtrate rezervările</param>
        /// <returns>O listă de obiecte de tip Rezervare care reprezintă rezervările filtrate</returns>
        public List<Rezervare> SearchRezervarePrenume(String prenume)
        {
            List<Rezervare> listaRezervari = new List<Rezervare>();
            String query = "SELECT * FROM rezervari WHERE prenume = @prenume";
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            DataTable dt;

            using (var ds = new DataSet())
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@prenume", prenume);

                        using (var da = new SQLiteDataAdapter(command))
                        {
                            using (var tran = new TransactionScope())
                            {
                                ds.Clear();
                                da.Fill(ds);
                                dt = ds.Tables[0];
                                tran.Complete();
                            }
                        }
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        Rezervare rezervare = new Rezervare(row);
                        listaRezervari.Add(rezervare);
                    }
                    return listaRezervari;
                }
            }
        }

        /// <summary>
        /// Returnează o listă de rezervări din baza de date, filtrate după nume și prenume.
        /// </summary>
        /// <param name="nume">Numele după care să fie filtrate rezervările</param>
        /// <param name="prenume">Prenumele după care să fie filtrate rezervările</param>
        /// <returns>O listă de obiecte de tip Rezervare care reprezintă rezervările filtrate</returns>
        public List<Rezervare> SearchRezervareNumePrenume(String nume, String prenume)
        {
            List<Rezervare> listaRezervari = new List<Rezervare>();
            String query = "SELECT * FROM rezervari WHERE prenume = @prenume and nume = @nume";
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            DataTable dt;

            using (var ds = new DataSet())
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@prenume", prenume);
                        command.Parameters.AddWithValue("@nume", nume);

                        using (var da = new SQLiteDataAdapter(command))
                        {
                            using (var tran = new TransactionScope())
                            {
                                ds.Clear();
                                da.Fill(ds);
                                dt = ds.Tables[0];
                                tran.Complete();
                            }
                        }
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        Rezervare rezervare = new Rezervare(row);
                        listaRezervari.Add(rezervare);
                    }
                    return listaRezervari;
                }
            }
        }

        /// <summary>
        /// Verifică dacă o cameră este liberă.
        /// </summary>
        /// <param name="nr">Numărul camerei care trebuie verificat</param>
        /// <returns>True dacă camera este liberă, altfel False</returns>
        public bool IsCameraGoala(int nr)
        {
            int ocupata = -1;

            string query = "SELECT ocupata FROM camere WHERE numar = @numar";
            string connectionString = "Data Source=mydatabase.db;Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@numar", nr);

                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            ocupata = Convert.ToInt32(result);
                            if (ocupata == 0)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nu exista camera");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Returnează o listă de numere de camere libere din baza de date.
        /// </summary>
        /// <returns>O listă de numere de camere libere</returns>
        public List<int> GetNumereCamereLibere()
        {
            List<int> listaNumereCamereLibere = new List<int>();
            String query = "SELECT numar FROM camere WHERE ocupata = 0";
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            DataTable dt;

            using (var ds = new DataSet())
            {
                using (var da = new SQLiteDataAdapter(query, connectionString))
                {
                    using (var tran = new TransactionScope())
                    {
                        ds.Clear();
                        da.Fill(ds);
                        dt = ds.Tables[0];
                        tran.Complete();
                    }
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                int numarCamera = Convert.ToInt32(row["numar"]);
                listaNumereCamereLibere.Add(numarCamera);
            }

            return listaNumereCamereLibere;
        }

        /// <summary>
        /// Validează credențialele unui utilizator.
        /// </summary>
        /// <param name="username">Numele de utilizator</param>
        /// <param name="password">Parola</param>
        /// <returns>True dacă credențialele sunt valide, altfel False</returns>
        public bool ValidateUser(string username, string password)
        {
            bool isValid = false;
            string query = "SELECT pass FROM useri WHERE user = @user";
            string connectionString = "Data Source=mydatabase.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@user", username);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string storedHashedPassword = result.ToString();
                        isValid = storedHashedPassword == password;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("A apărut o eroare: " + ex.Message);
                }
            }

            return isValid;
        }

        /// <summary>
        /// Returneaza nivelul de acces.
        /// </summary>
        /// <param name="username">Numele de utilizator</param>
        public int GetPrivilegeLevel(string username)
        {
            int privilegeLevel = -1;  
            string query = "SELECT privilegiu FROM useri WHERE user = @user";
            string connectionString = "Data Source=mydatabase.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@user", username);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        privilegeLevel = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("A apărut o eroare: " + ex.Message);
                }
            }

            return privilegeLevel;
        }



        /// <summary>
        /// Calculeaza pretul rezervarii.
        /// </summary>
        /// <param name="cameraNumar">Numarul camerei</param>
        /// <param name="zile">Numarul de zile</param>
        /// <returns>Pretul rezervarii</returns>
        public int CalculeazaPretRezervare(int cameraNumar, int zile)
        {
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string getTarifSql = "SELECT tarif FROM camere WHERE numar = @numar";
                SQLiteCommand getTarifCommand = new SQLiteCommand(getTarifSql, connection);
                getTarifCommand.Parameters.AddWithValue("@numar", cameraNumar);

                try
                {
                    connection.Open();
                    object result = getTarifCommand.ExecuteScalar();
                    if (result != null)
                    {
                        int tarif = Convert.ToInt32(result);
                        return tarif * zile;
                    }
                    else
                    {
                        throw new Exception("Camera not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return -1;
                }
            }
        }
    }
}
