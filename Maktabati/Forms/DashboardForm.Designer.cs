namespace Maktabati.Forms
{
    partial class DashboardForm
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
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(238, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(304, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tableau de bord";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(205, 85);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(415, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Bienvenue dans votre espace d'administration.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.etre_visible_internet_librairie;
            pictureBox2.Location = new Point(169, 162);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(462, 292);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(pictureBox2);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private PictureBox pictureBox2;
    }
}
