using System;
using System.Windows.Forms;

namespace Maktabati.Forms
{
    public partial class MainFormMembre : Form
    {
        public MainFormMembre()
        {
            InitializeComponent();
        }
        private void MainFormMembre_Load(object sender, EventArgs e)
        {
            LoadForm(new FormAccueilMembre());
        }

        private void LoadForm(Form form)
        {
            panelContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            LoadForm(new FormAccueilMembre());
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            LoadForm(new FormProfilMembre());
        }

        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            LoadForm(new FormCatalogueMembre());
        }

        private void btnEmprunts_Click(object sender, EventArgs e)
        {
            LoadForm(new FormMesEmprunts());
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            LoadForm(new FormReservationsMembre());
        }

        private void btnRecommandations_Click(object sender, EventArgs e)
        {
            LoadForm(new FormRecommandations());
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close(); // Ou retourner à un LoginForm
        }
    }
}