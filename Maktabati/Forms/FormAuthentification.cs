using System;
using System.Windows.Forms;

using Maktabati.Forms;
namespace Maktabati.Forms
{
    public partial class FormAuthentification : Form
    {
        public FormAuthentification()
        {
            InitializeComponent();
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }



     

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Vérification simple (remplace par ta logique réelle de vérification)
            if (username == "admin" && password == "admin")
            {
                this.Hide(); // Cacher le formulaire de login

                MainFormAdmin adminForm = new MainFormAdmin();
                adminForm.FormClosed += (s, args) => this.Close(); // Fermer l'application quand adminForm est fermé
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
