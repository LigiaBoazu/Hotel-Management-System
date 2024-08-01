namespace GestionareHotel
{
    partial class FormAplicatie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxRezervare = new System.Windows.Forms.GroupBox();
            this.buttonCalculeazaPret = new System.Windows.Forms.Button();
            this.labelPretRezervare = new System.Windows.Forms.Label();
            this.comboBoxTipCamera = new System.Windows.Forms.ComboBox();
            this.buttonRezerva = new System.Windows.Forms.Button();
            this.textBoxNumarZile = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelTipCamera = new System.Windows.Forms.Label();
            this.labelNumarZile = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.buttonCautaRezervare = new System.Windows.Forms.Button();
            this.groupBoxAddCamera = new System.Windows.Forms.GroupBox();
            this.buttonDeleteCamera = new System.Windows.Forms.Button();
            this.buttonDeleteRezervare = new System.Windows.Forms.Button();
            this.labelTarifCamera = new System.Windows.Forms.Label();
            this.textBoxAddTarifCamera = new System.Windows.Forms.TextBox();
            this.buttonAddCamera = new System.Windows.Forms.Button();
            this.textBoxAddTipCamera = new System.Windows.Forms.TextBox();
            this.labelAddTarifCamera = new System.Windows.Forms.Label();
            this.labelAddNrCamere = new System.Windows.Forms.Label();
            this.buttonAjutor = new System.Windows.Forms.Button();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.groupBoxAddUser = new System.Windows.Forms.GroupBox();
            this.comboBoxTipUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdaugaUser = new System.Windows.Forms.Button();
            this.textBoxAddParola = new System.Windows.Forms.TextBox();
            this.textBoxAddUser = new System.Windows.Forms.TextBox();
            this.labelAddUser = new System.Windows.Forms.Label();
            this.labelAddParola = new System.Windows.Forms.Label();
            this.groupBoxRezervare.SuspendLayout();
            this.groupBoxAddCamera.SuspendLayout();
            this.groupBoxAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRezervare
            // 
            this.groupBoxRezervare.Controls.Add(this.buttonCalculeazaPret);
            this.groupBoxRezervare.Controls.Add(this.labelPretRezervare);
            this.groupBoxRezervare.Controls.Add(this.comboBoxTipCamera);
            this.groupBoxRezervare.Controls.Add(this.buttonRezerva);
            this.groupBoxRezervare.Controls.Add(this.textBoxNumarZile);
            this.groupBoxRezervare.Controls.Add(this.textBoxPrenume);
            this.groupBoxRezervare.Controls.Add(this.textBoxPret);
            this.groupBoxRezervare.Controls.Add(this.textBoxNume);
            this.groupBoxRezervare.Controls.Add(this.labelTipCamera);
            this.groupBoxRezervare.Controls.Add(this.labelNumarZile);
            this.groupBoxRezervare.Controls.Add(this.labelPrenume);
            this.groupBoxRezervare.Controls.Add(this.labelNume);
            this.groupBoxRezervare.Location = new System.Drawing.Point(172, 30);
            this.groupBoxRezervare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRezervare.Name = "groupBoxRezervare";
            this.groupBoxRezervare.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRezervare.Size = new System.Drawing.Size(381, 310);
            this.groupBoxRezervare.TabIndex = 9;
            this.groupBoxRezervare.TabStop = false;
            this.groupBoxRezervare.Text = "Rezervare";
            // 
            // buttonCalculeazaPret
            // 
            this.buttonCalculeazaPret.Location = new System.Drawing.Point(84, 162);
            this.buttonCalculeazaPret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalculeazaPret.Name = "buttonCalculeazaPret";
            this.buttonCalculeazaPret.Size = new System.Drawing.Size(128, 33);
            this.buttonCalculeazaPret.TabIndex = 20;
            this.buttonCalculeazaPret.Text = "Calculeaza pret";
            this.buttonCalculeazaPret.UseVisualStyleBackColor = true;
            this.buttonCalculeazaPret.Click += new System.EventHandler(this.buttonCalculeazaPret_Click);
            // 
            // labelPretRezervare
            // 
            this.labelPretRezervare.AutoSize = true;
            this.labelPretRezervare.Location = new System.Drawing.Point(324, 170);
            this.labelPretRezervare.Name = "labelPretRezervare";
            this.labelPretRezervare.Size = new System.Drawing.Size(21, 16);
            this.labelPretRezervare.TabIndex = 19;
            this.labelPretRezervare.Text = "lei";
            // 
            // comboBoxTipCamera
            // 
            this.comboBoxTipCamera.FormattingEnabled = true;
            this.comboBoxTipCamera.Location = new System.Drawing.Point(181, 119);
            this.comboBoxTipCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTipCamera.Name = "comboBoxTipCamera";
            this.comboBoxTipCamera.Size = new System.Drawing.Size(137, 24);
            this.comboBoxTipCamera.TabIndex = 17;
            // 
            // buttonRezerva
            // 
            this.buttonRezerva.Location = new System.Drawing.Point(124, 229);
            this.buttonRezerva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRezerva.Name = "buttonRezerva";
            this.buttonRezerva.Size = new System.Drawing.Size(128, 45);
            this.buttonRezerva.TabIndex = 14;
            this.buttonRezerva.Text = "Rezerva";
            this.buttonRezerva.UseVisualStyleBackColor = true;
            this.buttonRezerva.Click += new System.EventHandler(this.buttonRezerva_Click);
            // 
            // textBoxNumarZile
            // 
            this.textBoxNumarZile.Location = new System.Drawing.Point(181, 86);
            this.textBoxNumarZile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumarZile.Name = "textBoxNumarZile";
            this.textBoxNumarZile.Size = new System.Drawing.Size(137, 22);
            this.textBoxNumarZile.TabIndex = 12;
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(181, 57);
            this.textBoxPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(137, 22);
            this.textBoxPrenume.TabIndex = 11;
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(220, 167);
            this.textBoxPret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(98, 22);
            this.textBoxPret.TabIndex = 10;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(181, 26);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(137, 22);
            this.textBoxNume.TabIndex = 9;
            // 
            // labelTipCamera
            // 
            this.labelTipCamera.AutoSize = true;
            this.labelTipCamera.Location = new System.Drawing.Point(80, 122);
            this.labelTipCamera.Name = "labelTipCamera";
            this.labelTipCamera.Size = new System.Drawing.Size(89, 16);
            this.labelTipCamera.TabIndex = 7;
            this.labelTipCamera.Text = "Tipul camerei";
            // 
            // labelNumarZile
            // 
            this.labelNumarZile.AutoSize = true;
            this.labelNumarZile.Location = new System.Drawing.Point(80, 86);
            this.labelNumarZile.Name = "labelNumarZile";
            this.labelNumarZile.Size = new System.Drawing.Size(89, 16);
            this.labelNumarZile.TabIndex = 4;
            this.labelNumarZile.Text = "Numar de zile";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(80, 59);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(61, 16);
            this.labelPrenume.TabIndex = 3;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(80, 30);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(43, 16);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "Nume";
            // 
            // buttonCautaRezervare
            // 
            this.buttonCautaRezervare.Location = new System.Drawing.Point(378, 34);
            this.buttonCautaRezervare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCautaRezervare.Name = "buttonCautaRezervare";
            this.buttonCautaRezervare.Size = new System.Drawing.Size(128, 45);
            this.buttonCautaRezervare.TabIndex = 18;
            this.buttonCautaRezervare.Text = "Cauta o rezervare";
            this.buttonCautaRezervare.UseVisualStyleBackColor = true;
            this.buttonCautaRezervare.Click += new System.EventHandler(this.buttonCautaRezervare_Click_1);
            // 
            // groupBoxAddCamera
            // 
            this.groupBoxAddCamera.Controls.Add(this.buttonDeleteCamera);
            this.groupBoxAddCamera.Controls.Add(this.buttonDeleteRezervare);
            this.groupBoxAddCamera.Controls.Add(this.labelTarifCamera);
            this.groupBoxAddCamera.Controls.Add(this.buttonCautaRezervare);
            this.groupBoxAddCamera.Controls.Add(this.textBoxAddTarifCamera);
            this.groupBoxAddCamera.Controls.Add(this.buttonAddCamera);
            this.groupBoxAddCamera.Controls.Add(this.textBoxAddTipCamera);
            this.groupBoxAddCamera.Controls.Add(this.labelAddTarifCamera);
            this.groupBoxAddCamera.Controls.Add(this.labelAddNrCamere);
            this.groupBoxAddCamera.Location = new System.Drawing.Point(88, 344);
            this.groupBoxAddCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddCamera.Name = "groupBoxAddCamera";
            this.groupBoxAddCamera.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddCamera.Size = new System.Drawing.Size(536, 269);
            this.groupBoxAddCamera.TabIndex = 10;
            this.groupBoxAddCamera.TabStop = false;
            this.groupBoxAddCamera.Text = "Adauga camera";
            // 
            // buttonDeleteCamera
            // 
            this.buttonDeleteCamera.Location = new System.Drawing.Point(378, 190);
            this.buttonDeleteCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteCamera.Name = "buttonDeleteCamera";
            this.buttonDeleteCamera.Size = new System.Drawing.Size(128, 45);
            this.buttonDeleteCamera.TabIndex = 20;
            this.buttonDeleteCamera.Text = "Sterge o camera";
            this.buttonDeleteCamera.UseVisualStyleBackColor = true;
            this.buttonDeleteCamera.Click += new System.EventHandler(this.buttonDeleteCamera_Click);
            // 
            // buttonDeleteRezervare
            // 
            this.buttonDeleteRezervare.Location = new System.Drawing.Point(378, 114);
            this.buttonDeleteRezervare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteRezervare.Name = "buttonDeleteRezervare";
            this.buttonDeleteRezervare.Size = new System.Drawing.Size(128, 45);
            this.buttonDeleteRezervare.TabIndex = 19;
            this.buttonDeleteRezervare.Text = "Sterge o rezervare";
            this.buttonDeleteRezervare.UseVisualStyleBackColor = true;
            this.buttonDeleteRezervare.Click += new System.EventHandler(this.buttonDeleteRezervare_Click);
            // 
            // labelTarifCamera
            // 
            this.labelTarifCamera.AutoSize = true;
            this.labelTarifCamera.Location = new System.Drawing.Point(324, 129);
            this.labelTarifCamera.Name = "labelTarifCamera";
            this.labelTarifCamera.Size = new System.Drawing.Size(21, 16);
            this.labelTarifCamera.TabIndex = 13;
            this.labelTarifCamera.Text = "lei";
            // 
            // textBoxAddTarifCamera
            // 
            this.textBoxAddTarifCamera.Location = new System.Drawing.Point(181, 126);
            this.textBoxAddTarifCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddTarifCamera.Name = "textBoxAddTarifCamera";
            this.textBoxAddTarifCamera.Size = new System.Drawing.Size(137, 22);
            this.textBoxAddTarifCamera.TabIndex = 12;
            // 
            // buttonAddCamera
            // 
            this.buttonAddCamera.Location = new System.Drawing.Point(140, 190);
            this.buttonAddCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCamera.Name = "buttonAddCamera";
            this.buttonAddCamera.Size = new System.Drawing.Size(128, 45);
            this.buttonAddCamera.TabIndex = 11;
            this.buttonAddCamera.Text = "Adauga camera";
            this.buttonAddCamera.UseVisualStyleBackColor = true;
            this.buttonAddCamera.Click += new System.EventHandler(this.buttonAddCamera_Click);
            // 
            // textBoxAddTipCamera
            // 
            this.textBoxAddTipCamera.Location = new System.Drawing.Point(181, 78);
            this.textBoxAddTipCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddTipCamera.Name = "textBoxAddTipCamera";
            this.textBoxAddTipCamera.Size = new System.Drawing.Size(137, 22);
            this.textBoxAddTipCamera.TabIndex = 3;
            // 
            // labelAddTarifCamera
            // 
            this.labelAddTarifCamera.AutoSize = true;
            this.labelAddTarifCamera.Location = new System.Drawing.Point(80, 129);
            this.labelAddTarifCamera.Name = "labelAddTarifCamera";
            this.labelAddTarifCamera.Size = new System.Drawing.Size(83, 16);
            this.labelAddTarifCamera.TabIndex = 1;
            this.labelAddTarifCamera.Text = "Tarif camera";
            // 
            // labelAddNrCamere
            // 
            this.labelAddNrCamere.AutoSize = true;
            this.labelAddNrCamere.Location = new System.Drawing.Point(80, 78);
            this.labelAddNrCamere.Name = "labelAddNrCamere";
            this.labelAddNrCamere.Size = new System.Drawing.Size(89, 16);
            this.labelAddNrCamere.TabIndex = 0;
            this.labelAddNrCamere.Text = "Tipul camerei";
            // 
            // buttonAjutor
            // 
            this.buttonAjutor.Location = new System.Drawing.Point(562, 89);
            this.buttonAjutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjutor.Name = "buttonAjutor";
            this.buttonAjutor.Size = new System.Drawing.Size(128, 37);
            this.buttonAjutor.TabIndex = 12;
            this.buttonAjutor.Text = "Ajutor";
            this.buttonAjutor.UseVisualStyleBackColor = true;
            this.buttonAjutor.Click += new System.EventHandler(this.buttonAjutor_Click);
            // 
            // buttonIesire
            // 
            this.buttonIesire.Location = new System.Drawing.Point(562, 149);
            this.buttonIesire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(128, 37);
            this.buttonIesire.TabIndex = 13;
            this.buttonIesire.Text = "Iesire";
            this.buttonIesire.UseVisualStyleBackColor = true;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // groupBoxAddUser
            // 
            this.groupBoxAddUser.Controls.Add(this.comboBoxTipUser);
            this.groupBoxAddUser.Controls.Add(this.label1);
            this.groupBoxAddUser.Controls.Add(this.buttonAdaugaUser);
            this.groupBoxAddUser.Controls.Add(this.textBoxAddParola);
            this.groupBoxAddUser.Controls.Add(this.textBoxAddUser);
            this.groupBoxAddUser.Controls.Add(this.labelAddUser);
            this.groupBoxAddUser.Controls.Add(this.labelAddParola);
            this.groupBoxAddUser.Location = new System.Drawing.Point(172, 631);
            this.groupBoxAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddUser.Name = "groupBoxAddUser";
            this.groupBoxAddUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddUser.Size = new System.Drawing.Size(381, 207);
            this.groupBoxAddUser.TabIndex = 14;
            this.groupBoxAddUser.TabStop = false;
            this.groupBoxAddUser.Text = "Adauga user";
            // 
            // comboBoxTipUser
            // 
            this.comboBoxTipUser.FormattingEnabled = true;
            this.comboBoxTipUser.Items.AddRange(new object[] {
            "Client",
            "Receptioner"});
            this.comboBoxTipUser.Location = new System.Drawing.Point(181, 98);
            this.comboBoxTipUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTipUser.Name = "comboBoxTipUser";
            this.comboBoxTipUser.Size = new System.Drawing.Size(137, 24);
            this.comboBoxTipUser.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tip user";
            // 
            // buttonAdaugaUser
            // 
            this.buttonAdaugaUser.Location = new System.Drawing.Point(124, 148);
            this.buttonAdaugaUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdaugaUser.Name = "buttonAdaugaUser";
            this.buttonAdaugaUser.Size = new System.Drawing.Size(128, 37);
            this.buttonAdaugaUser.TabIndex = 11;
            this.buttonAdaugaUser.Text = "Adauga user";
            this.buttonAdaugaUser.UseVisualStyleBackColor = true;
            this.buttonAdaugaUser.Click += new System.EventHandler(this.buttonAdaugaUser_Click);
            // 
            // textBoxAddParola
            // 
            this.textBoxAddParola.Location = new System.Drawing.Point(181, 66);
            this.textBoxAddParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddParola.Name = "textBoxAddParola";
            this.textBoxAddParola.Size = new System.Drawing.Size(137, 22);
            this.textBoxAddParola.TabIndex = 3;
            // 
            // textBoxAddUser
            // 
            this.textBoxAddUser.Location = new System.Drawing.Point(181, 34);
            this.textBoxAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddUser.Name = "textBoxAddUser";
            this.textBoxAddUser.Size = new System.Drawing.Size(137, 22);
            this.textBoxAddUser.TabIndex = 2;
            // 
            // labelAddUser
            // 
            this.labelAddUser.AutoSize = true;
            this.labelAddUser.Location = new System.Drawing.Point(80, 39);
            this.labelAddUser.Name = "labelAddUser";
            this.labelAddUser.Size = new System.Drawing.Size(36, 16);
            this.labelAddUser.TabIndex = 1;
            this.labelAddUser.Text = "User";
            // 
            // labelAddParola
            // 
            this.labelAddParola.AutoSize = true;
            this.labelAddParola.Location = new System.Drawing.Point(80, 69);
            this.labelAddParola.Name = "labelAddParola";
            this.labelAddParola.Size = new System.Drawing.Size(47, 16);
            this.labelAddParola.TabIndex = 0;
            this.labelAddParola.Text = "Parola";
            // 
            // FormAplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(711, 840);
            this.Controls.Add(this.groupBoxAddUser);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.buttonAjutor);
            this.Controls.Add(this.groupBoxAddCamera);
            this.Controls.Add(this.groupBoxRezervare);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAplicatie";
            this.Text = "Aplicatie";
            this.groupBoxRezervare.ResumeLayout(false);
            this.groupBoxRezervare.PerformLayout();
            this.groupBoxAddCamera.ResumeLayout(false);
            this.groupBoxAddCamera.PerformLayout();
            this.groupBoxAddUser.ResumeLayout(false);
            this.groupBoxAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRezervare;
        private System.Windows.Forms.TextBox textBoxNumarZile;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelTipCamera;
        private System.Windows.Forms.Label labelNumarZile;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Button buttonRezerva;
        private System.Windows.Forms.GroupBox groupBoxAddCamera;
        private System.Windows.Forms.Label labelAddNrCamere;
        private System.Windows.Forms.Button buttonAddCamera;
        private System.Windows.Forms.TextBox textBoxAddTipCamera;
        private System.Windows.Forms.Label labelAddTarifCamera;
        private System.Windows.Forms.Button buttonAjutor;
        private System.Windows.Forms.Button buttonIesire;
        private System.Windows.Forms.GroupBox groupBoxAddUser;
        private System.Windows.Forms.Button buttonAdaugaUser;
        private System.Windows.Forms.TextBox textBoxAddParola;
        private System.Windows.Forms.TextBox textBoxAddUser;
        private System.Windows.Forms.Label labelAddUser;
        private System.Windows.Forms.Label labelAddParola;
        private System.Windows.Forms.ComboBox comboBoxTipUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddTarifCamera;
        private System.Windows.Forms.ComboBox comboBoxTipCamera;
        private System.Windows.Forms.Button buttonCautaRezervare;
        private System.Windows.Forms.Label labelPretRezervare;
        private System.Windows.Forms.Label labelTarifCamera;
        private System.Windows.Forms.Button buttonDeleteCamera;
        private System.Windows.Forms.Button buttonDeleteRezervare;
        private System.Windows.Forms.Button buttonCalculeazaPret;
    }
}

