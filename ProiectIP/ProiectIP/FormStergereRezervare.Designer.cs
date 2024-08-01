namespace ProiectIP
{
    partial class FormStergereRezervare
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
            this.dataGridViewAfisareRezervari = new System.Windows.Forms.DataGridView();
            this.Numar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumarZile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelIDRezervare = new System.Windows.Forms.Label();
            this.buttonDeleteRezervare = new System.Windows.Forms.Button();
            this.comboBoxIdStergere = new System.Windows.Forms.ComboBox();
            this.buttonAjutor = new System.Windows.Forms.Button();
            this.buttonIesireLogare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfisareRezervari)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAfisareRezervari
            // 
            this.dataGridViewAfisareRezervari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAfisareRezervari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numar,
            this.Nume,
            this.Prenume,
            this.NumarZile,
            this.tipCamera,
            this.Pret});
            this.dataGridViewAfisareRezervari.Location = new System.Drawing.Point(26, 76);
            this.dataGridViewAfisareRezervari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAfisareRezervari.Name = "dataGridViewAfisareRezervari";
            this.dataGridViewAfisareRezervari.RowHeadersVisible = false;
            this.dataGridViewAfisareRezervari.RowHeadersWidth = 62;
            this.dataGridViewAfisareRezervari.RowTemplate.Height = 28;
            this.dataGridViewAfisareRezervari.Size = new System.Drawing.Size(658, 274);
            this.dataGridViewAfisareRezervari.TabIndex = 1;
            // 
            // Numar
            // 
            this.Numar.HeaderText = "Nr.";
            this.Numar.MinimumWidth = 8;
            this.Numar.Name = "Numar";
            this.Numar.Width = 50;
            // 
            // Nume
            // 
            this.Nume.FillWeight = 80F;
            this.Nume.HeaderText = "Nume";
            this.Nume.MinimumWidth = 8;
            this.Nume.Name = "Nume";
            this.Nume.Width = 150;
            // 
            // Prenume
            // 
            this.Prenume.HeaderText = "Prenume";
            this.Prenume.MinimumWidth = 8;
            this.Prenume.Name = "Prenume";
            this.Prenume.Width = 150;
            // 
            // NumarZile
            // 
            this.NumarZile.HeaderText = "Numar Zile";
            this.NumarZile.MinimumWidth = 8;
            this.NumarZile.Name = "NumarZile";
            this.NumarZile.Width = 70;
            // 
            // tipCamera
            // 
            this.tipCamera.HeaderText = "Tip Camera";
            this.tipCamera.MinimumWidth = 8;
            this.tipCamera.Name = "tipCamera";
            this.tipCamera.Width = 70;
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.MinimumWidth = 8;
            this.Pret.Name = "Pret";
            this.Pret.Width = 70;
            // 
            // labelIDRezervare
            // 
            this.labelIDRezervare.AutoSize = true;
            this.labelIDRezervare.Location = new System.Drawing.Point(22, 33);
            this.labelIDRezervare.Name = "labelIDRezervare";
            this.labelIDRezervare.Size = new System.Drawing.Size(158, 16);
            this.labelIDRezervare.TabIndex = 2;
            this.labelIDRezervare.Text = "Introdu numarul rezervarii:";
            // 
            // buttonDeleteRezervare
            // 
            this.buttonDeleteRezervare.Location = new System.Drawing.Point(327, 22);
            this.buttonDeleteRezervare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteRezervare.Name = "buttonDeleteRezervare";
            this.buttonDeleteRezervare.Size = new System.Drawing.Size(137, 38);
            this.buttonDeleteRezervare.TabIndex = 3;
            this.buttonDeleteRezervare.Text = "Sterge rezervarea";
            this.buttonDeleteRezervare.UseVisualStyleBackColor = true;
            this.buttonDeleteRezervare.Click += new System.EventHandler(this.buttonDeleteRezervare_Click);
            // 
            // comboBoxIdStergere
            // 
            this.comboBoxIdStergere.FormattingEnabled = true;
            this.comboBoxIdStergere.Location = new System.Drawing.Point(198, 30);
            this.comboBoxIdStergere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxIdStergere.Name = "comboBoxIdStergere";
            this.comboBoxIdStergere.Size = new System.Drawing.Size(108, 24);
            this.comboBoxIdStergere.TabIndex = 4;
            // 
            // buttonAjutor
            // 
            this.buttonAjutor.Location = new System.Drawing.Point(178, 363);
            this.buttonAjutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjutor.Name = "buttonAjutor";
            this.buttonAjutor.Size = new System.Drawing.Size(128, 37);
            this.buttonAjutor.TabIndex = 13;
            this.buttonAjutor.Text = "Ajutor";
            this.buttonAjutor.UseVisualStyleBackColor = true;
            this.buttonAjutor.Click += new System.EventHandler(this.buttonAjutor_Click);
            // 
            // buttonIesireLogare
            // 
            this.buttonIesireLogare.Location = new System.Drawing.Point(382, 363);
            this.buttonIesireLogare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIesireLogare.Name = "buttonIesireLogare";
            this.buttonIesireLogare.Size = new System.Drawing.Size(121, 34);
            this.buttonIesireLogare.TabIndex = 14;
            this.buttonIesireLogare.Text = "Iesire";
            this.buttonIesireLogare.UseVisualStyleBackColor = true;
            this.buttonIesireLogare.Click += new System.EventHandler(this.buttonIesireLogare_Click);
            // 
            // FormStergereRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 417);
            this.Controls.Add(this.buttonIesireLogare);
            this.Controls.Add(this.buttonAjutor);
            this.Controls.Add(this.comboBoxIdStergere);
            this.Controls.Add(this.buttonDeleteRezervare);
            this.Controls.Add(this.labelIDRezervare);
            this.Controls.Add(this.dataGridViewAfisareRezervari);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStergereRezervare";
            this.Text = "FormStergereRezervare";
            this.Load += new System.EventHandler(this.FormStergereRezervare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfisareRezervari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAfisareRezervari;
        private System.Windows.Forms.Label labelIDRezervare;
        private System.Windows.Forms.Button buttonDeleteRezervare;
        private System.Windows.Forms.ComboBox comboBoxIdStergere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumarZile;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.Button buttonAjutor;
        private System.Windows.Forms.Button buttonIesireLogare;
    }
}