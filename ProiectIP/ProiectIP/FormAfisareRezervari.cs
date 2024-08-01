/**************************************************************************
 *                                                                        *
 *  File:        FormAfisareRezervari.cs                                  *
 *  Copyright:   (c) 2024, Florea Alexandra                               *
 *  E-mail:      alexandra.florea@student.tuiasi.ro                       *
 *  Description: Form-ul folosit pentru a vizualiza rezervarile.          *
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP
{
    /// <summary>
    /// Formular pentru afișarea rezervărilor și căutarea acestora după diverse criterii.
    /// </summary>
    public partial class FormAfisareRezervari : Form, IView
    {
        private IModel _model;
        private IPresenter _presenter;

        /// <summary>
        /// Constructor implicit pentru FormAfisareRezervari.
        /// </summary>
        public FormAfisareRezervari()
        {
            InitializeComponent();
            textBoxCautaPrenume.Enabled = false;
        }

        /// <summary>
        /// Constructor care primește un model și inițializează formularul.
        /// </summary>
        /// <param name="model">Modelul de date</param>
        public FormAfisareRezervari(IModel model)
        {
            InitializeComponent();
            textBoxCautaPrenume.Enabled = false;
            _model = model;
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
        /// Metodă pentru setarea presenter-ului.
        /// </summary>
        /// <param name="presenter">Referința la presenter</param>
        public void SetPresenter(IPresenter presenter)
        {
            _presenter = presenter;
            _presenter.Init();
        }

        // Metode private pentru afișarea rezervărilor după diferite criterii de căutare.

        /// <summary>
        /// Afișează rezervările după nume.
        /// </summary>
        /// <param name="nume">Numele pentru căutare</param>
        private void AfiseazaRezervariDupaNume(string nume)
        {
            List<Rezervare> rezervari = _model.SearchRezervareNume(nume);
            dataGridViewAfisareRezervari.Rows.Clear();

            foreach (var rezervare in rezervari)
            {
                dataGridViewAfisareRezervari.Rows.Add(rezervare.getNume(), rezervare.getPrenume(), rezervare.getZile(), rezervare.getCamera(), rezervare.getPret());
            }
        }

        /// <summary>
        /// Afișează rezervările după prenume.
        /// </summary>
        /// <param name="prenume">Prenumele pentru căutare</param>
        private void AfiseazaRezervariDupaPrenume(string prenume)
        {
            List<Rezervare> rezervari = _model.SearchRezervarePrenume(prenume);
            dataGridViewAfisareRezervari.Rows.Clear();

            foreach (var rezervare in rezervari)
            {
                dataGridViewAfisareRezervari.Rows.Add(rezervare.getNume(), rezervare.getPrenume(), rezervare.getZile(), rezervare.getCamera(), rezervare.getPret());
            }
        }

        /// <summary>
        /// Afișează rezervările după nume și prenume.
        /// </summary>
        /// <param name="nume">Numele pentru căutare</param>
        /// <param name="prenume">Prenumele pentru căutare</param>
        private void AfiseazaRezervariDupaNumePrenume(string nume, string prenume)
        {
            List<Rezervare> rezervari = _model.SearchRezervareNumePrenume(nume, prenume);
            dataGridViewAfisareRezervari.Rows.Clear();

            foreach (var rezervare in rezervari)
            {
                dataGridViewAfisareRezervari.Rows.Add(rezervare.getNume(), rezervare.getPrenume(), rezervare.getZile(), rezervare.getCamera(), rezervare.getPret());
            }
        }

        /// <summary>
        /// Afișează toate rezervările.
        /// </summary>
        private void AfiseazaRezervari()
        {
            List<Rezervare> rezervari = _model.GetRezervare();
            dataGridViewAfisareRezervari.Rows.Clear();

            foreach (var rezervare in rezervari)
            {
                dataGridViewAfisareRezervari.Rows.Add(rezervare.getNume(), rezervare.getPrenume(), rezervare.getZile(), rezervare.getCamera(), rezervare.getPret());
            }
        }

        // Evenimente pentru butoane și combobox.

        /// <summary>
        /// Metodă apelată când este apăsat butonul pentru afișarea rezervărilor.
        /// </summary>
        private void buttonAfisareRezervareDupaCriteriu_Click(object sender, EventArgs e)
        {
            String nume = textBoxCautaNume.Text;
            String prenume = textBoxCautaPrenume.Text;
            String numele = textBoxCautaNume.Text;
            String prenumele = textBoxCautaPrenume.Text;

            switch (comboBoxSearchRezervare.Text)
            {
                case "Nume":
                    {
                        AfiseazaRezervariDupaNume(nume);
                        break;
                    }
                case "Prenume":
                    {
                        AfiseazaRezervariDupaPrenume(prenume);
                        break;
                    }
                case "Nume si prenume":
                    {
                        AfiseazaRezervariDupaNumePrenume(numele, prenumele);
                        break;
                    }
                case "Toate rezervarile":
                    {
                        AfiseazaRezervari();
                        break;
                    }
            }
        }

        /// <summary>
        /// Metodă apelată când este selectată o opțiune din combobox-ul pentru căutare.
        /// </summary>
        private void comboBoxSearchRezervare_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSearchRezervare.Text)
            {
                case "Nume":
                    {
                        textBoxCautaNume.Enabled = true;
                        textBoxCautaPrenume.Enabled = false;
                        textBoxCautaNume.Clear();
                        textBoxCautaPrenume.Clear();
                        break;
                    }
                case "Prenume":
                    {
                        textBoxCautaNume.Enabled = false;
                        textBoxCautaPrenume.Enabled = true;
                        textBoxCautaNume.Clear();
                        textBoxCautaPrenume.Clear();
                        break;
                    }
                case "Nume si prenume":
                    {
                        textBoxCautaNume.Enabled = true;
                        textBoxCautaPrenume.Enabled = true;
                        textBoxCautaNume.Clear();
                        textBoxCautaPrenume.Clear();
                        break;
                    }
            }
        }
        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de ieșire.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonIesireLogare_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAjutorLogare_Click(object sender, EventArgs e)
        {
            string helpFilePath = System.Environment.CurrentDirectory + "\\Ajutor Cautare Rezervare.chm";
            Help.ShowHelp(this, helpFilePath);
        }
    }
}
