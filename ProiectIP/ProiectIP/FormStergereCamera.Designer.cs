namespace ProiectIP
{
    partial class FormStergereCamera
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
            this.dataGridViewAfisareCamera = new System.Windows.Forms.DataGridView();
            this.Numar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelIDCamera = new System.Windows.Forms.Label();
            this.comboBoxIdStergere = new System.Windows.Forms.ComboBox();
            this.buttonDeleteCamera = new System.Windows.Forms.Button();
            this.buttonAjutor = new System.Windows.Forms.Button();
            this.buttonIesire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfisareCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAfisareCamera
            // 
            this.dataGridViewAfisareCamera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAfisareCamera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numar,
            this.TipCamera,
            this.Tarif,
            this.Ocupat});
            this.dataGridViewAfisareCamera.Location = new System.Drawing.Point(23, 76);
            this.dataGridViewAfisareCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAfisareCamera.Name = "dataGridViewAfisareCamera";
            this.dataGridViewAfisareCamera.RowHeadersVisible = false;
            this.dataGridViewAfisareCamera.RowHeadersWidth = 62;
            this.dataGridViewAfisareCamera.RowTemplate.Height = 28;
            this.dataGridViewAfisareCamera.Size = new System.Drawing.Size(658, 274);
            this.dataGridViewAfisareCamera.TabIndex = 2;
            // 
            // Numar
            // 
            this.Numar.HeaderText = "Nr.";
            this.Numar.MinimumWidth = 8;
            this.Numar.Name = "Numar";
            this.Numar.Width = 50;
            // 
            // TipCamera
            // 
            this.TipCamera.FillWeight = 80F;
            this.TipCamera.HeaderText = "Tipul camerei";
            this.TipCamera.MinimumWidth = 8;
            this.TipCamera.Name = "TipCamera";
            this.TipCamera.Width = 150;
            // 
            // Tarif
            // 
            this.Tarif.HeaderText = "Tarif";
            this.Tarif.MinimumWidth = 8;
            this.Tarif.Name = "Tarif";
            this.Tarif.Width = 150;
            // 
            // Ocupat
            // 
            this.Ocupat.HeaderText = "Disponibilitate";
            this.Ocupat.MinimumWidth = 8;
            this.Ocupat.Name = "Ocupat";
            this.Ocupat.Width = 150;
            // 
            // labelIDCamera
            // 
            this.labelIDCamera.AutoSize = true;
            this.labelIDCamera.Location = new System.Drawing.Point(20, 29);
            this.labelIDCamera.Name = "labelIDCamera";
            this.labelIDCamera.Size = new System.Drawing.Size(152, 16);
            this.labelIDCamera.TabIndex = 3;
            this.labelIDCamera.Text = "Introdu numarul camerei:";
            // 
            // comboBoxIdStergere
            // 
            this.comboBoxIdStergere.FormattingEnabled = true;
            this.comboBoxIdStergere.Location = new System.Drawing.Point(196, 26);
            this.comboBoxIdStergere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxIdStergere.Name = "comboBoxIdStergere";
            this.comboBoxIdStergere.Size = new System.Drawing.Size(108, 24);
            this.comboBoxIdStergere.TabIndex = 5;
            // 
            // buttonDeleteCamera
            // 
            this.buttonDeleteCamera.Location = new System.Drawing.Point(317, 18);
            this.buttonDeleteCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteCamera.Name = "buttonDeleteCamera";
            this.buttonDeleteCamera.Size = new System.Drawing.Size(137, 38);
            this.buttonDeleteCamera.TabIndex = 6;
            this.buttonDeleteCamera.Text = "Sterge camera";
            this.buttonDeleteCamera.UseVisualStyleBackColor = true;
            this.buttonDeleteCamera.Click += new System.EventHandler(this.buttonDeleteCamera_Click);
            // 
            // buttonAjutor
            // 
            this.buttonAjutor.Location = new System.Drawing.Point(175, 373);
            this.buttonAjutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjutor.Name = "buttonAjutor";
            this.buttonAjutor.Size = new System.Drawing.Size(128, 37);
            this.buttonAjutor.TabIndex = 14;
            this.buttonAjutor.Text = "Ajutor";
            this.buttonAjutor.UseVisualStyleBackColor = true;
            this.buttonAjutor.Click += new System.EventHandler(this.buttonAjutor_Click);
            // 
            // buttonIesire
            // 
            this.buttonIesire.Location = new System.Drawing.Point(392, 373);
            this.buttonIesire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(121, 34);
            this.buttonIesire.TabIndex = 15;
            this.buttonIesire.Text = "Iesire";
            this.buttonIesire.UseVisualStyleBackColor = true;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // FormStergereCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 427);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.buttonAjutor);
            this.Controls.Add(this.buttonDeleteCamera);
            this.Controls.Add(this.comboBoxIdStergere);
            this.Controls.Add(this.labelIDCamera);
            this.Controls.Add(this.dataGridViewAfisareCamera);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStergereCamera";
            this.Text = "FormStergeCamera";
            this.Load += new System.EventHandler(this.FormStergereCamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfisareCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAfisareCamera;
        private System.Windows.Forms.Label labelIDCamera;
        private System.Windows.Forms.ComboBox comboBoxIdStergere;
        private System.Windows.Forms.Button buttonDeleteCamera;
        private System.Windows.Forms.Button buttonAjutor;
        private System.Windows.Forms.Button buttonIesire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocupat;
    }
}