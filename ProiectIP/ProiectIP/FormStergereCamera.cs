/**************************************************************************
 *                                                                        *
 *  File:        FormAplicatie.cs                                         *
 *  Copyright:   (c) 2024, Florea Alexandra                               *
 *  E-mail:      alexandra.florea@student.tuiasi.ro                       *
 *  Description: Form-ul pentru stergerea camerelor.                      *
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
    public partial class FormStergereCamera : Form, IView
    {
        private IModel _model;
        private IPresenter _presenter;


        /// <summary>
        /// Constructorul implicit al clasei FormLogare.
        /// Inițializează componentele formularului.
        /// </summary>
        public FormStergereCamera()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructorul suprascris al clasei FormLogare care primește un model ca parametru.
        /// Inițializează componentele formularului și setează modelul.
        /// </summary>
        /// <param name="model">Modelul de date al aplicației</param>
        public FormStergereCamera(IModel model)
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
        private void AfiseazaCamere()
        {
            List<Camera> camere = _model.GetCamera();
            List<int> iduri = _model.GetIdCamere();

            dataGridViewAfisareCamera.Rows.Clear();
            comboBoxIdStergere.Items.Clear();

            Dictionary<int, Camera> camereDict = new Dictionary<int, Camera>();

            if (camere.Count != iduri.Count)
            {
                MessageBox.Show("Numărul camerelor nu corespunde cu numărul ID-urilor.");
                return;
            }

            for (int i = 0; i < camere.Count; i++)
            {
                camereDict[iduri[i]] = camere[i];
            }

            string ocupat;
            foreach (var id in iduri)
            {
                var camera = camereDict[id];

                if (camera.getOcupat() == 0)
                    ocupat = "Disponibila";
                else
                    ocupat = "Ocupata";

                dataGridViewAfisareCamera.Rows.Add(id, camera.getNumar(), camera.getTarif(), ocupat);
                comboBoxIdStergere.Items.Add(id);
            }
        }
        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de ieșire.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Metodă pentru tratarea evenimentului din momentul in care deschidem form-ul.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void FormStergereCamera_Load(object sender, EventArgs e)
        {
            AfiseazaCamere();
        }
        /// <summary>
        /// Metodă pentru tratarea evenimentului de click pe butonul de stergere a camerelor.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonDeleteCamera_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxIdStergere.Text))
                    throw new Exception("Te rugăm să selectezi numarul camerei.");
                //MessageBox.Show("Vom sterge camera cu numarul " + comboBoxIdStergere.Text + ".");
                _model.DeleteCamera(Int32.Parse(comboBoxIdStergere.Text));
                comboBoxIdStergere.Items.Clear();
                AfiseazaCamere();
                MessageBox.Show("Am sters camera cu numarul " + comboBoxIdStergere.Text + ".");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAjutor_Click(object sender, EventArgs e)
        {
            string helpFilePath = System.Environment.CurrentDirectory + "\\Ajutor Stergere Camera.chm";
            Help.ShowHelp(this, helpFilePath);
        }
    }
}
