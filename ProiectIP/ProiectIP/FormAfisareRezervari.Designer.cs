namespace ProiectIP
{
    partial class FormAfisareRezervari
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
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumarZile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSearchRezervare = new System.Windows.Forms.Label();
            this.comboBoxSearchRezervare = new System.Windows.Forms.ComboBox();
            this.buttonAfisareRezervareDupaCriteriu = new System.Windows.Forms.Button();
            this.labelCautaNume = new System.Windows.Forms.Label();
            this.labelCautaPrenume = new System.Windows.Forms.Label();
            this.textBoxCautaNume = new System.Windows.Forms.TextBox();
            this.textBoxCautaPrenume = new System.Windows.Forms.TextBox();
            this.buttonAjutorLogare = new System.Windows.Forms.Button();
            this.buttonIesireLogare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfisareRezervari)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAfisareRezervari
            // 
            this.dataGridViewAfisareRezervari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAfisareRezervari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Prenume,
            this.NumarZile,
            this.tipCamera,
            this.Pret});
            this.dataGridViewAfisareRezervari.Location = new System.Drawing.Point(33, 169);
            this.dataGridViewAfisareRezervari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAfisareRezervari.Name = "dataGridViewAfisareRezervari";
            this.dataGridViewAfisareRezervari.RowHeadersVisible = false;
            this.dataGridViewAfisareRezervari.RowHeadersWidth = 62;
            this.dataGridViewAfisareRezervari.RowTemplate.Height = 28;
            this.dataGridViewAfisareRezervari.Size = new System.Drawing.Size(658, 200);
            this.dataGridViewAfisareRezervari.TabIndex = 0;
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
            // labelSearchRezervare
            // 
            this.labelSearchRezervare.AutoSize = true;
            this.labelSearchRezervare.Location = new System.Drawing.Point(29, 22);
            this.labelSearchRezervare.Name = "labelSearchRezervare";
            this.labelSearchRezervare.Size = new System.Drawing.Size(79, 16);
            this.labelSearchRezervare.TabIndex = 1;
            this.labelSearchRezervare.Text = "Cauta dupa:";
            // 
            // comboBoxSearchRezervare
            // 
            this.comboBoxSearchRezervare.FormattingEnabled = true;
            this.comboBoxSearchRezervare.Items.AddRange(new object[] {
            "Nume",
            "Prenume",
            "Nume si prenume",
            "Toate rezervarile"});
            this.comboBoxSearchRezervare.Location = new System.Drawing.Point(120, 19);
            this.comboBoxSearchRezervare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSearchRezervare.Name = "comboBoxSearchRezervare";
            this.comboBoxSearchRezervare.Size = new System.Drawing.Size(151, 24);
            this.comboBoxSearchRezervare.TabIndex = 2;
            this.comboBoxSearchRezervare.Text = "Nume";
            this.comboBoxSearchRezervare.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchRezervare_SelectedIndexChanged);
            // 
            // buttonAfisareRezervareDupaCriteriu
            // 
            this.buttonAfisareRezervareDupaCriteriu.Location = new System.Drawing.Point(305, 94);
            this.buttonAfisareRezervareDupaCriteriu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAfisareRezervareDupaCriteriu.Name = "buttonAfisareRezervareDupaCriteriu";
            this.buttonAfisareRezervareDupaCriteriu.Size = new System.Drawing.Size(145, 35);
            this.buttonAfisareRezervareDupaCriteriu.TabIndex = 3;
            this.buttonAfisareRezervareDupaCriteriu.Text = "Afiseaza tabelul";
            this.buttonAfisareRezervareDupaCriteriu.UseVisualStyleBackColor = true;
            this.buttonAfisareRezervareDupaCriteriu.Click += new System.EventHandler(this.buttonAfisareRezervareDupaCriteriu_Click);
            // 
            // labelCautaNume
            // 
            this.labelCautaNume.AutoSize = true;
            this.labelCautaNume.Location = new System.Drawing.Point(301, 22);
            this.labelCautaNume.Name = "labelCautaNume";
            this.labelCautaNume.Size = new System.Drawing.Size(43, 16);
            this.labelCautaNume.TabIndex = 4;
            this.labelCautaNume.Text = "Nume";
            // 
            // labelCautaPrenume
            // 
            this.labelCautaPrenume.AutoSize = true;
            this.labelCautaPrenume.Location = new System.Drawing.Point(301, 62);
            this.labelCautaPrenume.Name = "labelCautaPrenume";
            this.labelCautaPrenume.Size = new System.Drawing.Size(61, 16);
            this.labelCautaPrenume.TabIndex = 5;
            this.labelCautaPrenume.Text = "Prenume";
            // 
            // textBoxCautaNume
            // 
            this.textBoxCautaNume.Location = new System.Drawing.Point(380, 19);
            this.textBoxCautaNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCautaNume.Name = "textBoxCautaNume";
            this.textBoxCautaNume.Size = new System.Drawing.Size(151, 22);
            this.textBoxCautaNume.TabIndex = 6;
            // 
            // textBoxCautaPrenume
            // 
            this.textBoxCautaPrenume.Location = new System.Drawing.Point(380, 60);
            this.textBoxCautaPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCautaPrenume.Name = "textBoxCautaPrenume";
            this.textBoxCautaPrenume.Size = new System.Drawing.Size(151, 22);
            this.textBoxCautaPrenume.TabIndex = 7;
            // 
            // buttonAjutorLogare
            // 
            this.buttonAjutorLogare.Location = new System.Drawing.Point(149, 390);
            this.buttonAjutorLogare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjutorLogare.Name = "buttonAjutorLogare";
            this.buttonAjutorLogare.Size = new System.Drawing.Size(121, 34);
            this.buttonAjutorLogare.TabIndex = 8;
            this.buttonAjutorLogare.Text = "Ajutor";
            this.buttonAjutorLogare.UseVisualStyleBackColor = true;
            this.buttonAjutorLogare.Click += new System.EventHandler(this.buttonAjutorLogare_Click);
            // 
            // buttonIesireLogare
            // 
            this.buttonIesireLogare.Location = new System.Drawing.Point(380, 390);
            this.buttonIesireLogare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIesireLogare.Name = "buttonIesireLogare";
            this.buttonIesireLogare.Size = new System.Drawing.Size(121, 34);
            this.buttonIesireLogare.TabIndex = 9;
            this.buttonIesireLogare.Text = "Iesire";
            this.buttonIesireLogare.UseVisualStyleBackColor = true;
            this.buttonIesireLogare.Click += new System.EventHandler(this.buttonIesireLogare_Click);
            // 
            // FormAfisareRezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 442);
            this.Controls.Add(this.buttonIesireLogare);
            this.Controls.Add(this.buttonAjutorLogare);
            this.Controls.Add(this.textBoxCautaPrenume);
            this.Controls.Add(this.textBoxCautaNume);
            this.Controls.Add(this.labelCautaPrenume);
            this.Controls.Add(this.labelCautaNume);
            this.Controls.Add(this.buttonAfisareRezervareDupaCriteriu);
            this.Controls.Add(this.comboBoxSearchRezervare);
            this.Controls.Add(this.labelSearchRezervare);
            this.Controls.Add(this.dataGridViewAfisareRezervari);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAfisareRezervari";
            this.Text = "FormAfisareRezervari";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfisareRezervari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAfisareRezervari;
        private System.Windows.Forms.Label labelSearchRezervare;
        private System.Windows.Forms.ComboBox comboBoxSearchRezervare;
        private System.Windows.Forms.Button buttonAfisareRezervareDupaCriteriu;
        private System.Windows.Forms.Label labelCautaNume;
        private System.Windows.Forms.Label labelCautaPrenume;
        private System.Windows.Forms.TextBox textBoxCautaNume;
        private System.Windows.Forms.TextBox textBoxCautaPrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumarZile;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.Button buttonAjutorLogare;
        private System.Windows.Forms.Button buttonIesireLogare;
    }
}