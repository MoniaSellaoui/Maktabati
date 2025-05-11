using System;
using System.Windows.Forms;
using Maktabati.Forms;

namespace Maktabati
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CatalogForm()); // ← Lancer le bon formulaire
        }
    }
}
