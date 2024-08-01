/**************************************************************************
 *                                                                        *
 *  File:        FormAplicatie.cs                                         *
 *  Copyright:   (c) 2024, Florea Alexandra                               *
 *  E-mail:      alexandra.florea@student.tuiasi.ro                       *
 *  Description: Form-ul pentru stergerea rezervarilor.                   *
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
    public partial class FormStergereRezervare : Form, IView
    {
        private IModel _model;
        private IPresenter _presenter;


        /// <summary>
        /// Constructorul implicit al clasei FormLogare.
        /// Inițializează componentele formularului.
        /// </summary>
        public FormStergereRezervare()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructorul suprascris al clasei FormLogare care primește un model ca parametru.
        /// Inițializează componentele formularului și setează modelul.
        /// </summary>
        /// <param name="model">Modelul de date al aplicației</param>
        public FormStergereRezervare(IModel model)
        {
            InitializeComponent();
            _model = model;
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
        /// Metoda pentru afișarea tuturor rezervarilor.
        /// </summary>
        private void AfiseazaRezervari()
        {
            List<Rezervare> rezervari = _model.GetRezervare();
            List<int> iduri = _model.GetIdRezervare();

            dataGridViewAfisareRezervari.Rows.Clear();
            comboBoxIdStergere.Items.Clear();

            Dictionary<int, Rezervare> rezervariDict = new Dictionary<int, Rezervare>();

            if (rezervari.Count != iduri.Count)
            {
                MessageBox.Show("Numărul rezervărilor nu corespunde cu numărul ID-urilor.");
                return;
            }

            for (int i = 0; i < rezervari.Count; i++)
            {
                rezervariDict[iduri[i]] = rezervari[i];
            }

            foreach (var id in iduri)
            {
                var rezervare = rezervariDict[id];
                dataGridViewAfisareRezervari.Rows.Add(id, rezervare.getNume(), rezervare.getPrenume(), rezervare.getZile(), rezervare.getCamera(), rezervare.getPret());
                comboBoxIdStergere.Items.Add(id);
            }
        }

        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de stergere a rezervărilor.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonDeleteRezervare_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxIdStergere.Text))
                    throw new Exception("Te rugăm să selectezi numarul camerei.");
                MessageBox.Show("Vom sterge rezervarea cu numarul " + comboBoxIdStergere.Text + ".");
                _model.DeleteRezervare(Int32.Parse(comboBoxIdStergere.Text));
                comboBoxIdStergere.Items.Clear();
                AfiseazaRezervari();
                MessageBox.Show("Am sters rezervarea cu numarul " + comboBoxIdStergere.Text + ".");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// Metodă pentru tratarea evenimentului din momentul in care deschidem form-ul.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void FormStergereRezervare_Load(object sender, EventArgs e)
        {
            AfiseazaRezervari();
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

        private void buttonAjutor_Click(object sender, EventArgs e)
        {
            string helpFilePath = System.Environment.CurrentDirectory + "\\Ajutor Stergere Rezervare.chm";
            Help.ShowHelp(this, helpFilePath);
        }
    }
}
