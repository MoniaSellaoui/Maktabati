
using System.Windows.Forms;

public partial class MainFormAdmin : Form
{
    public MainFormAdmin()
    {
        InitializeComponent();
    }

    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private PictureBox pictureBox1;
    private Panel panelSidebar;
    private Button btnStatistiques;
    private Button btnPenalites;
    private Button btnCatalog;
    private Button btnDashboard;
    private Button btnExport;
    private Button btnEmprunts;
    private Button btnReservation;
    private Button btnDeconnexion;
    private Button btnMembresAdmin;
    private Panel panelMain;
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
        btnStatistiques = new Button();
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
        pictureBox1.Image = Maktabati.Properties.Resources.library;
        pictureBox1.Location = new Point(30, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(103, 101);
        pictureBox1.TabIndex = 29;
        pictureBox1.TabStop = false;
        // 
        // panelSidebar
        // 
        panelSidebar.BackColor = Color.Thistle;
        panelSidebar.Controls.Add(btnMembresAdmin);
        panelSidebar.Controls.Add(btnStatistiques);
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
        // 
        // btnMembresAdmin
        // 
        btnMembresAdmin.Location = new Point(10, 315);
        btnMembresAdmin.Name = "btnMembresAdmin";
        btnMembresAdmin.Size = new Size(150, 40);
        btnMembresAdmin.TabIndex = 34;
        btnMembresAdmin.Text = "Membres";
        btnMembresAdmin.UseVisualStyleBackColor = true;
        // 
        // btnStatistiques
        // 
        btnStatistiques.Location = new Point(12, 453);
        btnStatistiques.Name = "btnStatistiques";
        btnStatistiques.Size = new Size(150, 40);
        btnStatistiques.TabIndex = 33;
        btnStatistiques.Text = "Statistiques";
        btnStatistiques.UseVisualStyleBackColor = true;
        // 
        // btnPenalites
        // 
        btnPenalites.Location = new Point(10, 361);
        btnPenalites.Name = "btnPenalites";
        btnPenalites.Size = new Size(150, 40);
        btnPenalites.TabIndex = 32;
        btnPenalites.Text = "Pénalités";
        btnPenalites.UseVisualStyleBackColor = true;
        // 
        // btnCatalog
        // 
        btnCatalog.Location = new Point(10, 177);
        btnCatalog.Name = "btnCatalog";
        btnCatalog.Size = new Size(150, 40);
        btnCatalog.TabIndex = 31;
        btnCatalog.Text = "Catalogue Livres";
        btnCatalog.UseVisualStyleBackColor = true;
        // 
        // btnDashboard
        // 
        btnDashboard.Location = new Point(12, 131);
        btnDashboard.Name = "btnDashboard";
        btnDashboard.Size = new Size(150, 40);
        btnDashboard.TabIndex = 30;
        btnDashboard.Text = "Dashboard Biblio";
        btnDashboard.UseVisualStyleBackColor = true;
        // 
        // btnExport
        // 
        btnExport.Location = new Point(12, 407);
        btnExport.Name = "btnExport";
        btnExport.Size = new Size(150, 40);
        btnExport.TabIndex = 2;
        btnExport.Text = "Export / Import";
        btnExport.UseVisualStyleBackColor = true;
        // 
        // btnEmprunts
        // 
        btnEmprunts.Location = new Point(10, 223);
        btnEmprunts.Name = "btnEmprunts";
        btnEmprunts.Size = new Size(150, 40);
        btnEmprunts.TabIndex = 3;
        btnEmprunts.Text = "Emprunt / Retour";
        btnEmprunts.UseVisualStyleBackColor = true;
        // 
        // btnReservation
        // 
        btnReservation.Location = new Point(10, 269);
        btnReservation.Name = "btnReservation";
        btnReservation.Size = new Size(150, 40);
        btnReservation.TabIndex = 4;
        btnReservation.Text = "Réservations";
        btnReservation.UseVisualStyleBackColor = true;
        // 
        // btnDeconnexion
        // 
        btnDeconnexion.Location = new Point(12, 525);
        btnDeconnexion.Name = "btnDeconnexion";
        btnDeconnexion.Size = new Size(150, 40);
        btnDeconnexion.TabIndex = 6;
        btnDeconnexion.Text = "Déconnexion";
        btnDeconnexion.UseVisualStyleBackColor = true;
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
        Text = "App Book Track";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panelSidebar.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }


}
