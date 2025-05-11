namespace Maktabati.Forms
{
    partial class EmpruntsForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources.
        /// </summary>
        /// <param name="disposing">true si les ressources doivent être libérées</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            comboLivre = new ComboBox();
            comboMembre = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            echeance = new Label();
            btnRetour = new Button();
            btnProlonger = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(173, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(451, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "EmpruntsForm des livres";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(237, 115);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(356, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Bienvenue dans l espaces des emprunts.";
            // 
            // comboLivre
            // 
            comboLivre.FormattingEnabled = true;
            comboLivre.Location = new Point(234, 213);
            comboLivre.Name = "comboLivre";
            comboLivre.Size = new Size(139, 28);
            comboLivre.TabIndex = 8;
            comboLivre.Text = "Livre";
            // 
            // comboMembre
            // 
            comboMembre.FormattingEnabled = true;
            comboMembre.Location = new Point(43, 213);
            comboMembre.Name = "comboMembre";
            comboMembre.Size = new Size(130, 28);
            comboMembre.TabIndex = 7;
            comboMembre.Text = "Membre";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(421, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(162, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // echeance
            // 
            echeance.AutoSize = true;
            echeance.Location = new Point(612, 216);
            echeance.Name = "echeance";
            echeance.Size = new Size(105, 20);
            echeance.TabIndex = 10;
            echeance.Text = "date echeance";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(509, 302);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(117, 29);
            btnRetour.TabIndex = 13;
            btnRetour.Text = "✅ Retour";
            btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnProlonger
            // 
            btnProlonger.Location = new Point(379, 302);
            btnProlonger.Name = "btnProlonger";
            btnProlonger.Size = new Size(124, 29);
            btnProlonger.TabIndex = 12;
            btnProlonger.Text = "🔁 Prolonger";
            btnProlonger.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(163, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(210, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "📥 Enregistrer emprunt";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // EmpruntsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(btnRetour);
            Controls.Add(btnProlonger);
            Controls.Add(btnSave);
            Controls.Add(echeance);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboLivre);
            Controls.Add(comboMembre);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmpruntsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private ComboBox comboLivre;
        private ComboBox comboMembre;
        private DateTimePicker dateTimePicker1;
        private Label echeance;
        private Button btnRetour;
        private Button btnProlonger;
        private Button btnSave;
    }
}
