namespace Login
{
    partial class FormLogare
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
            this.groupBoxLogare = new System.Windows.Forms.GroupBox();
            this.buttonLogare = new System.Windows.Forms.Button();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelParola = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonAjutorLogare = new System.Windows.Forms.Button();
            this.buttonIesireLogare = new System.Windows.Forms.Button();
            this.groupBoxLogare.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogare
            // 
            this.groupBoxLogare.Controls.Add(this.buttonLogare);
            this.groupBoxLogare.Controls.Add(this.textBoxParola);
            this.groupBoxLogare.Controls.Add(this.textBoxUser);
            this.groupBoxLogare.Controls.Add(this.labelParola);
            this.groupBoxLogare.Controls.Add(this.labelUser);
            this.groupBoxLogare.Location = new System.Drawing.Point(192, 98);
            this.groupBoxLogare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogare.Name = "groupBoxLogare";
            this.groupBoxLogare.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogare.Size = new System.Drawing.Size(353, 154);
            this.groupBoxLogare.TabIndex = 0;
            this.groupBoxLogare.TabStop = false;
            this.groupBoxLogare.Text = "Logare";
            // 
            // buttonLogare
            // 
            this.buttonLogare.Location = new System.Drawing.Point(124, 105);
            this.buttonLogare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogare.Name = "buttonLogare";
            this.buttonLogare.Size = new System.Drawing.Size(121, 34);
            this.buttonLogare.TabIndex = 4;
            this.buttonLogare.Text = "Logare";
            this.buttonLogare.UseVisualStyleBackColor = true;
            this.buttonLogare.Click += new System.EventHandler(this.buttonLogare_Click);
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(124, 70);
            this.textBoxParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(147, 22);
            this.textBoxParola.TabIndex = 3;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(124, 38);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(147, 22);
            this.textBoxUser.TabIndex = 2;
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Location = new System.Drawing.Point(71, 70);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(47, 16);
            this.labelParola.TabIndex = 1;
            this.labelParola.Text = "Parola";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(71, 41);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(36, 16);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User";
            // 
            // buttonAjutorLogare
            // 
            this.buttonAjutorLogare.Location = new System.Drawing.Point(224, 284);
            this.buttonAjutorLogare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjutorLogare.Name = "buttonAjutorLogare";
            this.buttonAjutorLogare.Size = new System.Drawing.Size(121, 34);
            this.buttonAjutorLogare.TabIndex = 1;
            this.buttonAjutorLogare.Text = "Ajutor";
            this.buttonAjutorLogare.UseVisualStyleBackColor = true;
            this.buttonAjutorLogare.Click += new System.EventHandler(this.buttonAjutorLogare_Click);
            // 
            // buttonIesireLogare
            // 
            this.buttonIesireLogare.Location = new System.Drawing.Point(394, 284);
            this.buttonIesireLogare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIesireLogare.Name = "buttonIesireLogare";
            this.buttonIesireLogare.Size = new System.Drawing.Size(121, 34);
            this.buttonIesireLogare.TabIndex = 2;
            this.buttonIesireLogare.Text = "Iesire";
            this.buttonIesireLogare.UseVisualStyleBackColor = true;
            this.buttonIesireLogare.Click += new System.EventHandler(this.buttonIesireLogare_Click);
            // 
            // FormLogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.buttonIesireLogare);
            this.Controls.Add(this.buttonAjutorLogare);
            this.Controls.Add(this.groupBoxLogare);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogare";
            this.Text = "Logare";
            this.groupBoxLogare.ResumeLayout(false);
            this.groupBoxLogare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogare;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonLogare;
        private System.Windows.Forms.Button buttonAjutorLogare;
        private System.Windows.Forms.Button buttonIesireLogare;
    }
}