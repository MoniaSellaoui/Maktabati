namespace AppBookTrack
{
    partial class acceuil
    {
        private System.ComponentModel.IContainer components = null;
        private Panel sidebar;
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
            sidebar = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(40, 40, 40);
            sidebar.Dock = DockStyle.Left;
            sidebar.ForeColor = SystemColors.ActiveCaptionText;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(180, 500);
            sidebar.TabIndex = 0;
            sidebar.Paint += sidebar_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(200, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(264, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Gestion des livres";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(200, 79);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Rechercher";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(441, 70);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(104, 44);
            btnModifier.TabIndex = 3;
            btnModifier.Text = "Modifier...";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(576, 70);
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
            dgvBooks.Location = new Point(200, 120);
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
            // acceuil
            // 
            ClientSize = new Size(850, 500);
            Controls.Add(sidebar);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Controls.Add(dgvBooks);
            Name = "acceuil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App Book Track";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewImageColumn imgCol;
    }
}
