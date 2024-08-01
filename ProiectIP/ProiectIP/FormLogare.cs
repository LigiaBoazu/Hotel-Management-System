/**************************************************************************
 *                                                                        *
 *  File:        FormLogare.cs                                            *
 *  Copyright:   (c) 2024, Florea Alexandra                               *
 *  E-mail:      alexandra.florea@student.tuiasi.ro                       *
 *  Description: Form-ul folosit pentru logare. Are functii de logare si  *
 *  validare a logarii.                                                   *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/
using GestionareHotel;
using ProiectIP;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login 
{
    /// <summary>
    /// Clasa FormLogare reprezintă formularul de logare pentru aplicație.
    /// Aceasta implementează interfața IView pentru a comunica cu presenter-ul.
    /// </summary>
    public partial class FormLogare : Form, IView
    {
        private IModel _model;
        private IPresenter _presenter;


        /// <summary>
        /// Constructorul implicit al clasei FormLogare.
        /// Inițializează componentele formularului.
        /// </summary>
        public FormLogare()
        {
            InitializeComponent();
            textBoxParola.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Constructorul suprascris al clasei FormLogare care primește un model ca parametru.
        /// Inițializează componentele formularului și setează modelul.
        /// </summary>
        /// <param name="model">Modelul de date al aplicației</param>
        public FormLogare(IModel model)
        {
            InitializeComponent();
            _model = model;
            textBoxParola.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Metoda pentru setarea presenter-ului.
        /// </summary>
        /// <param name="presenter">Referința la presenter</param>
        public void SetPresenter(IPresenter presenter)
        {
            _presenter = presenter;
            _presenter.Init();
        }

        /// <summary>
        /// Metoda pentru afișarea unui mesaj într-o casetă de dialog.
        /// </summary>
        /// <param name="text">Textul mesajului de afișat</param>
        public void Display(string text)
        {
            MessageBox.Show(text);
        }

        /// <summary>
        /// Metoda pentru tratarea evenimentului de click pe butonul de logare.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonLogare_Click(object sender, EventArgs e)
        {
            try
            {
                if (_model == null)
                {
                    MessageBox.Show("Modelul nu este inițializat.");
                    return;
                }

                // Validate the user
                bool isValidUser = _model.ValidateUser(textBoxUser.Text, textBoxParola.Text);
                if (isValidUser)
                {
                    // Retrieve privilege level
                    int privilegeLevel = _model.GetPrivilegeLevel(textBoxUser.Text);
                    int currentUserId = _model.GetUserIdByCredentials(textBoxUser.Text, textBoxParola.Text);

                    // Launch FormAplicatie with privilege level
                    FormAplicatie formAplicatie = new FormAplicatie(_model, privilegeLevel, currentUserId);
                    formAplicatie.Show();

                    IPresenter presenter = new Presenter(formAplicatie, _model);
                    formAplicatie.SetPresenter(presenter);
                }
                else
                {
                    MessageBox.Show("User sau parola incorecte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}");
            }
        }


        /// <summary>
        /// Metoda pentru afisarea rezervarilor.
        /// </summary>
        private void ShowFormAfisareRezervari()
        {
            FormAfisareRezervari formAfisareRezervari = new FormAfisareRezervari(_model);
            formAfisareRezervari.Show();
        }




        /// <summary>
        /// Metoda pentru tratarea evenimentului de click pe butonul de ieșire.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonIesireLogare_Click(object sender, EventArgs e)
        {
            // Închide formularul de logare
            Close(); 
        }

        private void buttonAjutorLogare_Click(object sender, EventArgs e)
        {
            string helpFilePath = System.Environment.CurrentDirectory + "\\Ajutor Logare.chm";
            Help.ShowHelp(this, helpFilePath);
        }
    }
}