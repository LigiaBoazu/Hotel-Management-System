/**************************************************************************
 *                                                                        *
 *  File:        FormAplicatie.cs                                         *
 *  Copyright:   (c) 2024, Florea Alexandra                               *
 *  E-mail:      alexandra.florea@student.tuiasi.ro                       *
 *  Description: Form-ul programului principal. Interfata comuna tuturor  *
 *  userilor. Genereaza functii de callback.                              *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic; 
using System.Windows.Forms;
using ProiectIP;

namespace GestionareHotel
{
    /// <summary>
    /// Clasa FormAplicatie reprezintă formularul principal al aplicației.
    /// Aceasta implementează interfața IView pentru a comunica cu presenter-ul.
    /// </summary>
    public partial class FormAplicatie : Form, IView
    {
        private IModel _model;
        private IPresenter _presenter;
        private int _privilegeLevel;
        private int _currentUserId;

        /// <summary>
        /// Constructorul implicit al clasei FormAplicatie.
        /// Inițializează componentele formularului.
        /// </summary>
        public FormAplicatie(IModel model, int privilegeLevel, int currentUserId)
        {
            InitializeComponent();
            //InitializeDataGridView(); 
            _model = model;
            _currentUserId = currentUserId;
            _privilegeLevel = privilegeLevel;
            AdjustUIBasedOnPrivilege();
        }

        /// <summary>
        /// Setare privilegii in functie de acces
        /// </summary>
        private void AdjustUIBasedOnPrivilege()
        {
            Console.WriteLine($"Current user privilege level: {_privilegeLevel}");
            MessageBox.Show($"Current user privilege level: {_privilegeLevel}", "Debug Info");

            switch (_privilegeLevel)
            {
                case 0: // Admin
                    break;

                case 1: // Client
                    groupBoxRezervare.Visible = true;
                    groupBoxRezervare.Enabled = true;  
                    textBoxPret.Visible = true;      
                    textBoxPret.Enabled = false;
                    groupBoxAddUser.Visible = false;
                    groupBoxAddUser.Enabled = false;
                    groupBoxAddCamera.Visible = false;
                    groupBoxAddCamera.Enabled = false;
                    
                    break;

                case 2: // Receptionist
                    groupBoxAddUser.Visible = false;
                    groupBoxAddUser.Enabled = false;
                    buttonAddCamera.Visible = true;
                    buttonRezerva.Visible = true;
                    buttonAddCamera.Enabled = true;
                    buttonRezerva.Enabled = true;
                    break;

                default:
                    MessageBox.Show("Acces neautorizat.");
                    this.Close(); 
                    break;
            }
        }

        /// <summary>
        /// Metodă declanșată la încărcarea formularului.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void FormAplicatie_Load(object sender, EventArgs e)
        {
            List<int> numarCamereLibere = _model.GetNumereCamereLibere();
            // Adaugă numerele camerelor libere în combobox
            foreach (int numar in numarCamereLibere)
            {
                comboBoxTipCamera.Items.Add(numar);
            }
            textBoxPret.Enabled = false;
        }

        /// <summary>
        /// Constructorul suprascris al clasei FormAplicatie care primește un model ca parametru.
        /// Inițializează componentele formularului și setează modelul.
        /// </summary>
        /// <param name="model">Modelul de date al aplicației</param>
        public FormAplicatie(IModel model)
        {
            _model = model;
            InitializeComponent();
            comboBoxTipCamera.Items.Clear();
            List<int> numarCamereLibere = _model.GetNumereCamereLibere();
            // Adaugă numerele camerelor libere în combobox
            foreach (int numar in numarCamereLibere) 
            {
                comboBoxTipCamera.Items.Add(numar);
            }
            textBoxPret.Enabled = false;
        }

        /// <summary>
        /// Metodă pentru setarea presenter-ului.
        /// </summary>
        /// <param name="presenter">Referința la presenter</param>
        public void SetPresenter(IPresenter presenter)
        {
            _presenter = presenter; 
            _presenter.Init(); 
        }

        /// <summary>
        /// Metodă pentru afișarea unui mesaj într-o casetă de dialog.
        /// </summary>
        /// <param name="text">Textul mesajului de afișat</param>
        public void Display(string text)
        {
            MessageBox.Show(text); 
        }

        /// <summary>
        /// Metodă pentru tratarea excepțiilor la rezervare.
        /// </summary>
        private void TratareExceptiiRezervare()
        {
            int nrZile;
            if (string.IsNullOrEmpty(textBoxNume.Text))
                throw new Exception("Vă rugăm să completați numele.");
            if (string.IsNullOrEmpty(textBoxPrenume.Text))
                throw new Exception("Vă rugăm să completați prenumele.");
            if (!int.TryParse(textBoxNumarZile.Text, out nrZile) || nrZile <= 0)
                throw new Exception("Vă rugăm să introduceți un număr valid de zile.");
            if (string.IsNullOrEmpty(comboBoxTipCamera.Text))
                throw new Exception("Vă rugăm să introduceți tipul camerei (din cele din lista).");
        }

        /// <summary>
        /// Metodă pentru tratarea excepțiilor la adăugarea camerei.
        /// </summary>
        private void TratareExceptiiAddCamera()
        {
            int tarif;
            int nrCamera;
            if (string.IsNullOrEmpty(textBoxAddTipCamera.Text))
                throw new Exception("Vă rugăm să introduceți un număr de cameră.");
            if (!int.TryParse(textBoxAddTipCamera.Text, out nrCamera) || nrCamera <= 0)
                throw new Exception("Vă rugăm să introduceți un număr valid pentru cameră. (> 0) ");
            if (string.IsNullOrEmpty(textBoxAddTarifCamera.Text))
                throw new Exception("Vă rugăm să introduceți un tarif pentru cameră.");
            if (!int.TryParse(textBoxAddTarifCamera.Text, out tarif) || tarif <= 100)
                throw new Exception("Vă rugăm să introduceți un număr valid de preț. (> 100)");
        }

        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de rezervare.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonRezerva_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifică validitatea datelor de rezervare
                TratareExceptiiRezervare(); 

                String nume = textBoxNume.Text;
                String prenume = textBoxPrenume.Text;
                int nrZile = Int32.Parse(textBoxNumarZile.Text);
                int camera = Int32.Parse(comboBoxTipCamera.Text);
                int pret = _model.CalculeazaPretRezervare(camera, nrZile);
                
                // Creează un obiect Rezervare
                Rezervare rezervare = new Rezervare(nume, prenume, nrZile, pret, camera);
                // Adaugă rezervarea prin presenter
                _presenter.AddRezervare(rezervare);
                textBoxNume.Clear();
                textBoxPrenume.Clear();
                textBoxNumarZile.Clear();
                textBoxPret.Clear();
                comboBoxTipCamera.Text = "";
                comboBoxTipCamera.Items.Clear();
                List<int> numarCamereLibere = _model.GetNumereCamereLibere();
                // Adaugă numerele camerelor libere în combobox
                foreach (int numar in numarCamereLibere)
                {
                    comboBoxTipCamera.Items.Add(numar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de ieșire.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonIesire_Click(object sender, EventArgs e)
        {
            // Închide formularul principal
            Close(); 
        }

        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de adăugare a camerei.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonAddCamera_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifică validitatea datelor camerei
                TratareExceptiiAddCamera();

                int tarif = Int32.Parse(textBoxAddTarifCamera.Text);
                int nrCamera = Int32.Parse(textBoxAddTipCamera.Text);
                // Creează un obiect Camera
                Camera camera = new Camera(nrCamera, tarif, 0);
                // Adaugă camera prin presenter
                _presenter.AddCamera(camera);
                textBoxAddTarifCamera.Clear();
                textBoxAddTipCamera.Clear();
                comboBoxTipCamera.Items.Clear();
                List<int> numarCamereLibere = _model.GetNumereCamereLibere();
                // Adaugă numerele camerelor libere în combobox
                foreach (int numar in numarCamereLibere)
                {
                    comboBoxTipCamera.Items.Add(numar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Metodă pentru tratarea excepțiilor la adăugarea utilizatorului.
        /// </summary>
        private void TratareExceptiiAddUser()
        {
            if (string.IsNullOrEmpty(textBoxAddUser.Text))
                throw new Exception("Te rugăm să adaugi username-ul.");
            if (string.IsNullOrEmpty(textBoxAddParola.Text))
                throw new Exception("Te rugăm să adaugi o parolă pentru user.");
            if (string.IsNullOrEmpty(comboBoxTipUser.Text))
                throw new Exception("Te rugăm să adaugi tipul userului.");
        }

        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de adăugare a utilizatorului.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonAdaugaUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifică validitatea datelor utilizatorului
                TratareExceptiiAddUser(); 

                String userName = textBoxAddUser.Text;
                String parola = textBoxAddParola.Text;
                int privilegiu;

                switch (comboBoxTipUser.Text)
                {
                    case "Client":
                        {
                            privilegiu = 1;
                            break;
                        }
                    case "Receptioner":
                        {
                            privilegiu = 2;
                            break;
                        }
                    default:
                        {
                            privilegiu = -1;
                            break;
                        }
                }
                // Creează un obiect User
                User user = new User(userName, parola, privilegiu);
                // Adaugă utilizatorul prin presenter
                _presenter.AddUser(user); 
                textBoxAddUser.Clear();
                textBoxAddParola.Clear();
                comboBoxTipUser.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de căutare a rezervărilor.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonCautaRezervare_Click_1(object sender, EventArgs e)
        {
            // Ascunde formularul curent
            //this.Hide();
            // Închide formularul curent
            //this.Close();
            // Creează un nou formular de afișare a rezervărilor
            FormAfisareRezervari formAfisareRezervari = new FormAfisareRezervari(_model);
            formAfisareRezervari.Show();

            IPresenter presenter = new Presenter(formAfisareRezervari, _model);
            formAfisareRezervari.SetPresenter(presenter);
            
        }
        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de calculare de pret a rezervărilor.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonCalculeazaPret_Click(object sender, EventArgs e)
        {
            try
            {
                TratareExceptiiRezervare();
                int pret = _model.CalculeazaPretRezervare(Int32.Parse(textBoxNumarZile.Text), Int32.Parse(comboBoxTipCamera.Text));
                textBoxPret.Text = pret.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de stergere a rezervărilor.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>

        private void buttonDeleteRezervare_Click(object sender, EventArgs e)
        {
            FormStergereRezervare formStergereRezervare = new FormStergereRezervare(_model);
            formStergereRezervare.Show();

            IPresenter presenter = new Presenter(formStergereRezervare, _model);
            formStergereRezervare.SetPresenter(presenter);
        }
        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de stergere a camerelor.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonDeleteCamera_Click(object sender, EventArgs e)
        {
            FormStergereCamera formStergereCamera = new FormStergereCamera(_model);
            formStergereCamera.Show();

            IPresenter presenter = new Presenter(formStergereCamera, _model);
            formStergereCamera.SetPresenter(presenter);
        }

        private void buttonAjutor_Click(object sender, EventArgs e)
        {
            if (_privilegeLevel == 0)
            {
                string helpFilePath = System.Environment.CurrentDirectory + "\\Ajutor Admin.chm";
                Help.ShowHelp(this, helpFilePath);
            }
            else if (_privilegeLevel == 2)
            {
                string helpFilePath = System.Environment.CurrentDirectory + "\\Ajutor Receptioner.chm";
                Help.ShowHelp(this, helpFilePath);
            }
            else if (_privilegeLevel == 1)
            {
                string helpFilePath = System.Environment.CurrentDirectory + "\\Ajutor Client.chm";
                Help.ShowHelp(this, helpFilePath);
            }
        }
    }
}

