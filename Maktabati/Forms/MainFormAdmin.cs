using System;
using System.Drawing;
using System.Windows.Forms;
using Maktabati.Properties;
using Maktabati.Forms;

namespace Maktabati.Forms
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Panel panelSidebar;
        private Button btnPenalites;
        private Button btnCatalog;
        private Button btnDashboard;
        private Button btnExport;
        private Button btnEmprunts;
        private Button btnReservation;
        private Button btnDeconnexion;
        private Button btnMembresAdmin;
        private Panel panelMain;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            panelSidebar = new Panel();
            btnMembresAdmin = new Button();
            btnPenalites = new Button();
            btnCatalog = new Button();
            btnDashboard = new Button();
            btnExport = new Button();
            btnEmprunts = new Button();
            btnReservation = new Button();
            btnDeconnexion = new Button();
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Andalus", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(488, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(337, 61);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Bonjour , Admin !";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.library;
            pictureBox1.Location = new Point(31, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 101);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Thistle;
            panelSidebar.Controls.Add(btnMembresAdmin);
            panelSidebar.Controls.Add(btnPenalites);
            panelSidebar.Controls.Add(btnCatalog);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(pictureBox1);
            panelSidebar.Controls.Add(btnExport);
            panelSidebar.Controls.Add(btnEmprunts);
            panelSidebar.Controls.Add(btnReservation);
            panelSidebar.Controls.Add(btnDeconnexion);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(170, 577);
            panelSidebar.TabIndex = 30;
            panelSidebar.Paint += panelSidebar_Paint;
            // 
            // btnMembresAdmin
            // 
            btnMembresAdmin.Location = new Point(10, 348);
            btnMembresAdmin.Name = "btnMembresAdmin";
            btnMembresAdmin.Size = new Size(150, 40);
            btnMembresAdmin.TabIndex = 34;
            btnMembresAdmin.Text = "👤 Membres";
            btnMembresAdmin.UseVisualStyleBackColor = true;
            btnMembresAdmin.Click += btnMembresAdmin_Click;
            // 
            // btnPenalites
            // 
            btnPenalites.Location = new Point(10, 394);
            btnPenalites.Name = "btnPenalites";
            btnPenalites.Size = new Size(150, 40);
            btnPenalites.TabIndex = 32;
            btnPenalites.Text = "⚠️ Pénalités";
            btnPenalites.UseVisualStyleBackColor = true;
            btnPenalites.Click += btnPenalites_Click;
            // 
            // btnCatalog
            // 
            btnCatalog.Location = new Point(10, 210);
            btnCatalog.Name = "btnCatalog";
            btnCatalog.Size = new Size(150, 40);
            btnCatalog.TabIndex = 31;
            btnCatalog.Text = "📚Catalogue Livres";
            btnCatalog.UseVisualStyleBackColor = true;
            btnCatalog.Click += btnCatalog_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(12, 164);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(150, 40);
            btnDashboard.TabIndex = 30;
            btnDashboard.Text = "Dashboard Biblio";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(12, 440);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(150, 40);
            btnExport.TabIndex = 2;
            btnExport.Text = "💾 Export / Import";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnEmprunts
            // 
            btnEmprunts.Font = new Font("Segoe UI", 8F);
            btnEmprunts.Location = new Point(10, 256);
            btnEmprunts.Name = "btnEmprunts";
            btnEmprunts.Size = new Size(150, 40);
            btnEmprunts.TabIndex = 3;
            btnEmprunts.Text = "📖Emprunt / Retour";
            btnEmprunts.UseVisualStyleBackColor = true;
            btnEmprunts.Click += btnEmprunts_Click;
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(10, 302);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(150, 40);
            btnReservation.TabIndex = 4;
            btnReservation.Text = "🔖Réservations";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Location = new Point(12, 525);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(150, 40);
            btnDeconnexion.TabIndex = 6;
            btnDeconnexion.Text = "🚪 Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(170, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(953, 577);
            panelMain.TabIndex = 31;
            // 
            // Form1
            // 
            ClientSize = new Size(1123, 577);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin space";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new DashboardForm());
        }

        private void LoadFormInPanel(DashboardForm dashboardForm)
        {
            this.panelMain.Controls.Clear();
            dashboardForm.TopLevel = false;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            dashboardForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }


        private void btnCatalog_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new CatalogForm());
        }

        private void LoadFormInPanel(CatalogForm catalogForm)
        {
            this.panelMain.Controls.Clear();
            catalogForm.TopLevel = false;
            catalogForm.FormBorderStyle = FormBorderStyle.None;
            catalogForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(catalogForm);
            catalogForm.Show();
        }

        private void btnEmprunts_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new EmpruntsForm());
        }

        private void LoadFormInPanel(EmpruntsForm empruntsForm)
        {
            this.panelMain.Controls.Clear();
            empruntsForm.TopLevel = false;
            empruntsForm.FormBorderStyle = FormBorderStyle.None;
            empruntsForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(empruntsForm);
            empruntsForm.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new FormReservations());
        }

        private void LoadFormInPanel(FormReservations formReservations)
        {
            this.panelMain.Controls.Clear();
            formReservations.TopLevel = false;
            formReservations.FormBorderStyle = FormBorderStyle.None;
            formReservations.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(formReservations);
            formReservations.Show();
        }

        private void btnPenalites_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new FormPenalites());
        }

        private void LoadFormInPanel(FormPenalites formPenalites)
        {
            this.panelMain.Controls.Clear();
            formPenalites.TopLevel = false;
            formPenalites.FormBorderStyle = FormBorderStyle.None;
            formPenalites.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(formPenalites);
            formPenalites.Show();
        }

        private void btnMembresAdmin_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new FormMembresAdmin());
        }

        private void LoadFormInPanel(FormMembresAdmin formMembresAdmin)
        {
            this.panelMain.Controls.Clear();
            formMembresAdmin.TopLevel = false;
            formMembresAdmin.FormBorderStyle = FormBorderStyle.None;
            formMembresAdmin.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(formMembresAdmin);
            formMembresAdmin.Show();
        }

     

        private void btnExport_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new FormSauvegarde());
        }

        private void LoadFormInPanel(FormSauvegarde formSauvegarde)
        {
            throw new NotImplementedException();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuthentification form = new FormAuthentification();
            form.ShowDialog();
            this.Close();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
