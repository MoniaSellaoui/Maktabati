using System;
using System.Windows.Forms;

namespace Maktabati.Forms
{
    public partial class MainFormMembre : Form
    {
        public MainFormMembre()

        { InitializeComponent(); }


    private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnCatalogue;
        private System.Windows.Forms.Button btnEmprunts;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnRecommandations;
        private System.Windows.Forms.Button btnDeconnexion;

        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            pictureBox1 = new PictureBox();
            btnAccueil = new Button();
            btnProfil = new Button();
            btnCatalogue = new Button();
            btnEmprunts = new Button();
            btnReservations = new Button();
            btnRecommandations = new Button();
            btnDeconnexion = new Button();
            panelContent = new Panel();
            lblTitle = new Label();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Thistle;
            panelSidebar.Controls.Add(pictureBox1);
            panelSidebar.Controls.Add(btnAccueil);
            panelSidebar.Controls.Add(btnProfil);
            panelSidebar.Controls.Add(btnCatalogue);
            panelSidebar.Controls.Add(btnEmprunts);
            panelSidebar.Controls.Add(btnReservations);
            panelSidebar.Controls.Add(btnRecommandations);
            panelSidebar.Controls.Add(btnDeconnexion);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(170, 500);
            panelSidebar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.library;
            pictureBox1.Location = new Point(34, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnAccueil
            // 
            btnAccueil.Location = new Point(10, 146);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(150, 40);
            btnAccueil.TabIndex = 0;
            btnAccueil.Text = "Accueil";
            btnAccueil.UseVisualStyleBackColor = true;
            btnAccueil.Click += btnAccueil_Click;
            // 
            // btnProfil
            // 
            btnProfil.Location = new Point(9, 192);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(150, 40);
            btnProfil.TabIndex = 1;
            btnProfil.Text = "Mon Profil";
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnCatalogue
            // 
            btnCatalogue.Location = new Point(9, 238);
            btnCatalogue.Name = "btnCatalogue";
            btnCatalogue.Size = new Size(150, 40);
            btnCatalogue.TabIndex = 2;
            btnCatalogue.Text = "📚 Catalogue";
            btnCatalogue.UseVisualStyleBackColor = true;
            btnCatalogue.Click += btnCatalogue_Click;
            // 
            // btnEmprunts
            // 
            btnEmprunts.Location = new Point(10, 284);
            btnEmprunts.Name = "btnEmprunts";
            btnEmprunts.Size = new Size(150, 40);
            btnEmprunts.TabIndex = 3;
            btnEmprunts.Text = "Mes Emprunts";
            btnEmprunts.UseVisualStyleBackColor = true;
            btnEmprunts.Click += btnEmprunts_Click;
            // 
            // btnReservations
            // 
            btnReservations.Location = new Point(9, 330);
            btnReservations.Name = "btnReservations";
            btnReservations.Size = new Size(150, 40);
            btnReservations.TabIndex = 4;
            btnReservations.Text = "🔖 Réservations";
            btnReservations.UseVisualStyleBackColor = true;
            btnReservations.Click += btnReservations_Click;
            // 
            // btnRecommandations
            // 
            btnRecommandations.Location = new Point(9, 376);
            btnRecommandations.Name = "btnRecommandations";
            btnRecommandations.Size = new Size(150, 40);
            btnRecommandations.TabIndex = 5;
            btnRecommandations.Text = "Recommandations";
            btnRecommandations.UseVisualStyleBackColor = true;
            btnRecommandations.Click += btnRecommandations_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Location = new Point(10, 448);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(150, 40);
            btnDeconnexion.TabIndex = 6;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(lblTitle);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(170, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(630, 500);
            panelContent.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Andalus", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(141, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(367, 61);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Bonjour , Membre !";
            // 
            // MainFormMembre
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Name = "MainFormMembre";
            Text = "Espace Membre - Maktabati";
            Load += MainFormMembre_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }
        private PictureBox pictureBox1;
        private Label lblTitle;
    }
}