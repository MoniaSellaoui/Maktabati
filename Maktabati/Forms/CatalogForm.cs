using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Maktabati.Forms
{
    public partial class CatalogForm : Form
    {
        private DataGridView dgvBooks;
        private TextBox txtSearch;
        private Button btnAjouter, btnModifier, btnSupprimer;

        public CatalogForm()
        {
            InitializeComponent();
            InitializeControls();
            LoadSampleData();
        }

        private void InitializeControls()
        {
            // DataGridView
            dgvBooks = new DataGridView
            {
                AllowUserToAddRows = false,
                ColumnHeadersHeight = 29,
                Location = new Point(50, 180),
                Name = "dgvBooks",
                ReadOnly = true,
                RowHeadersWidth = 51,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                Size = new Size(700, 250),
                TabIndex = 0
            };

            // Zone de recherche
            txtSearch = new TextBox
            {
                Location = new Point(420, 130),
                Name = "txtSearch",
                PlaceholderText = "Recherche par titre...",
                Size = new Size(300, 27),
                TabIndex = 1
            };
            txtSearch.TextChanged += txtSearch_TextChanged;

            // Boutons
            btnAjouter = new Button
            {
                Location = new Point(270, 125),
                Name = "btnAjouter",
                Size = new Size(88, 38),
                Text = "Ajouter"
            };

            btnModifier = new Button
            {
                Location = new Point(170, 125),
                Name = "btnModifier",
                Size = new Size(94, 38),
                Text = "Modifier"
            };

            btnSupprimer = new Button
            {
                Location = new Point(65, 125),
                Name = "btnSupprimer",
                Size = new Size(99, 38),
                Text = "Supprimer"
            };

            // Ajouter les contrôles au formulaire
            Controls.Add(dgvBooks);
            Controls.Add(txtSearch);
            Controls.Add(btnAjouter);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
        }

        private void LoadSampleData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("StatutColor");
            table.Columns.Add("Titre");
            table.Columns.Add("Auteur");
            table.Columns.Add("Categorie");
            table.Columns.Add("Statut");

            table.Rows.Add("●", "1984", "George Orwell", "Science-fiction", "Disponible");
            table.Rows.Add("●", "Le Petit Prince", "Antoine de Saint-Exupéry", "Jeunesse", "Emprunté");
            table.Rows.Add("●", "Les Misérables", "Victor Hugo", "Classique", "Disponible");
            table.Rows.Add("●", "Harry Potter", "J.K. Rowling", "Fantasy", "Emprunté");

            dgvBooks.DataSource = table;

            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                string statut = row.Cells["Statut"].Value?.ToString();
                row.Cells["StatutColor"].Style.Font = new Font("Arial", 12, FontStyle.Bold);
                row.Cells["StatutColor"].Style.ForeColor = (statut == "Disponible") ? Color.Green : Color.Red;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                if (row.Cells["Titre"].Value != null &&
                    row.Cells["Titre"].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
    }
}
