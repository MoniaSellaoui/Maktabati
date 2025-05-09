namespace AppBookTrack
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private TextBox txtSearch;
        private Button btnModifier;
        private Button btnSupprimer;
        private DataGridView dgvBooks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtSearch = new TextBox();
            btnModifier = new Button();
            btnSupprimer = new Button();
            dgvBooks = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            imgCol = new DataGridViewImageColumn();
            btnReservations = new Button();
            pictureBox1 = new PictureBox();
            btnDashboard = new Button();
            btnMembres = new Button();
            btnParametres = new Button();
            btnExport = new Button();
            btnEmprunt = new Button();
            btnPenalites = new Button();
            btnStatistiques = new Button();
            btnCatalogue = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(334, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(264, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Gestion des livres";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(277, 111);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Rechercher";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(518, 102);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(104, 44);
            btnModifier.TabIndex = 3;
            btnModifier.Text = "Modifier...";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(653, 102);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(99, 44);
            btnSupprimer.TabIndex = 4;
            btnSupprimer.Text = "Supprimer";
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeight = 29;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, imgCol });
            dgvBooks.Location = new Point(225, 167);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.RowTemplate.Height = 60;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(600, 300);
            dgvBooks.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Titre";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Auteur";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Catégorie";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Disponible";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // imgCol
            // 
            imgCol.HeaderText = "";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.MinimumWidth = 6;
            imgCol.Name = "imgCol";
            // 
            // btnReservations
            // 
            btnReservations.BackColor = Color.CornflowerBlue;
            btnReservations.BackgroundImageLayout = ImageLayout.None;
            btnReservations.FlatAppearance.BorderSize = 0;
            btnReservations.FlatStyle = FlatStyle.Flat;
            btnReservations.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservations.ForeColor = Color.Lavender;
            btnReservations.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservations.Location = new Point(12, 364);
            btnReservations.Name = "btnReservations";
            btnReservations.Size = new Size(170, 30);
            btnReservations.TabIndex = 14;
            btnReservations.Text = "Reservations";
            btnReservations.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Maktabati.Properties.Resources.library;
            pictureBox1.Location = new Point(37, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 101);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.CornflowerBlue;
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Lavender;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(12, 148);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(170, 30);
            btnDashboard.TabIndex = 16;
            btnDashboard.Text = "Dashboard Biblio";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnMembres
            // 
            btnMembres.BackColor = Color.CornflowerBlue;
            btnMembres.BackgroundImageLayout = ImageLayout.None;
            btnMembres.FlatAppearance.BorderSize = 0;
            btnMembres.FlatStyle = FlatStyle.Flat;
            btnMembres.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMembres.ForeColor = Color.Lavender;
            btnMembres.ImageAlign = ContentAlignment.MiddleLeft;
            btnMembres.Location = new Point(12, 256);
            btnMembres.Name = "btnMembres";
            btnMembres.Size = new Size(170, 30);
            btnMembres.TabIndex = 18;
            btnMembres.Text = "Membres";
            btnMembres.UseVisualStyleBackColor = false;
            // 
            // btnParametres
            // 
            btnParametres.BackColor = Color.CornflowerBlue;
            btnParametres.BackgroundImageLayout = ImageLayout.None;
            btnParametres.FlatAppearance.BorderSize = 0;
            btnParametres.FlatStyle = FlatStyle.Flat;
            btnParametres.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParametres.ForeColor = Color.Lavender;
            btnParametres.ImageAlign = ContentAlignment.MiddleLeft;
            btnParametres.Location = new Point(12, 292);
            btnParametres.Name = "btnParametres";
            btnParametres.Size = new Size(170, 30);
            btnParametres.TabIndex = 10;
            btnParametres.Text = "Parametres";
            btnParametres.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.CornflowerBlue;
            btnExport.BackgroundImageLayout = ImageLayout.None;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.Lavender;
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(12, 400);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(170, 30);
            btnExport.TabIndex = 15;
            btnExport.Text = "Export / Import";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // btnEmprunt
            // 
            btnEmprunt.BackColor = Color.CornflowerBlue;
            btnEmprunt.BackgroundImageLayout = ImageLayout.None;
            btnEmprunt.FlatAppearance.BorderSize = 0;
            btnEmprunt.FlatStyle = FlatStyle.Flat;
            btnEmprunt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmprunt.ForeColor = Color.Lavender;
            btnEmprunt.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmprunt.Location = new Point(12, 220);
            btnEmprunt.Name = "btnEmprunt";
            btnEmprunt.Size = new Size(170, 30);
            btnEmprunt.TabIndex = 12;
            btnEmprunt.Text = "Emprunt / Retour";
            btnEmprunt.UseVisualStyleBackColor = false;
            // 
            // btnPenalites
            // 
            btnPenalites.BackColor = Color.CornflowerBlue;
            btnPenalites.BackgroundImageLayout = ImageLayout.None;
            btnPenalites.FlatAppearance.BorderSize = 0;
            btnPenalites.FlatStyle = FlatStyle.Flat;
            btnPenalites.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPenalites.ForeColor = Color.Lavender;
            btnPenalites.ImageAlign = ContentAlignment.MiddleLeft;
            btnPenalites.Location = new Point(12, 328);
            btnPenalites.Name = "btnPenalites";
            btnPenalites.Size = new Size(170, 30);
            btnPenalites.TabIndex = 11;
            btnPenalites.Text = "Penalites";
            btnPenalites.UseVisualStyleBackColor = false;
            // 
            // btnStatistiques
            // 
            btnStatistiques.BackColor = Color.CornflowerBlue;
            btnStatistiques.BackgroundImageLayout = ImageLayout.None;
            btnStatistiques.FlatAppearance.BorderSize = 0;
            btnStatistiques.FlatStyle = FlatStyle.Flat;
            btnStatistiques.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatistiques.ForeColor = Color.Lavender;
            btnStatistiques.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistiques.Location = new Point(12, 436);
            btnStatistiques.Name = "btnStatistiques";
            btnStatistiques.Size = new Size(170, 30);
            btnStatistiques.TabIndex = 17;
            btnStatistiques.Text = "Statistiques";
            btnStatistiques.UseVisualStyleBackColor = false;
            // 
            // btnCatalogue
            // 
            btnCatalogue.BackColor = Color.CornflowerBlue;
            btnCatalogue.BackgroundImageLayout = ImageLayout.None;
            btnCatalogue.FlatAppearance.BorderSize = 0;
            btnCatalogue.FlatStyle = FlatStyle.Flat;
            btnCatalogue.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCatalogue.ForeColor = Color.Lavender;
            btnCatalogue.ImageAlign = ContentAlignment.MiddleLeft;
            btnCatalogue.Location = new Point(12, 184);
            btnCatalogue.Name = "btnCatalogue";
            btnCatalogue.Size = new Size(170, 30);
            btnCatalogue.TabIndex = 13;
            btnCatalogue.Text = "Catalogue livres";
            btnCatalogue.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            ClientSize = new Size(850, 500);
            Controls.Add(btnReservations);
            Controls.Add(pictureBox1);
            Controls.Add(btnDashboard);
            Controls.Add(btnMembres);
            Controls.Add(btnParametres);
            Controls.Add(btnExport);
            Controls.Add(btnEmprunt);
            Controls.Add(btnPenalites);
            Controls.Add(btnStatistiques);
            Controls.Add(btnCatalogue);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Controls.Add(dgvBooks);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App Book Track";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewImageColumn imgCol;
        private Button btnReservations;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnMembres;
        private Button btnParametres;
        private Button btnExport;
        private Button btnEmprunt;
        private Button btnPenalites;
        private Button btnStatistiques;
        private Button btnCatalogue;
    }
}
