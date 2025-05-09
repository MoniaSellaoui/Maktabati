using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppBookTrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add any initialization logic if needed
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];

                // Here you can add logic to modify the selected row data
                // Example: Open a new form to edit the details of the selected book

                MessageBox.Show("Modification clicked for: " + selectedRow.Cells["Titre"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un livre à modifier.");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];

                // Here you can add logic to delete the selected row from the DataGridView and database
                // Example: Delete the selected book from the DataGridView
                dgvBooks.Rows.Remove(selectedRow);

                MessageBox.Show("Livre supprimé avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un livre à supprimer.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Simple search logic based on book title
            string searchText = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                if (row.Cells["Titre"].Value != null && row.Cells["Titre"].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Visible = true;  // Show row if it matches search
                }
                else
                {
                    row.Visible = false;  // Hide row if it doesn't match search
                }
            }
        }

    
    }
}
