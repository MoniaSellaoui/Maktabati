using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maktabati
{
    public partial class FormReservations : Form
    {
        public FormReservations()
        {
            InitializeComponent();
        }



        private Panel CreateStatPanel(string icon, string label, string value, Point location)
        {
            Panel panel = new Panel();
            panel.Size = new Size(160, 100);
            panel.Location = location;
            panel.BackColor = Color.FromArgb(240, 240, 255);
            panel.BorderStyle = BorderStyle.FixedSingle;

            Label lblIcon = new Label();
            lblIcon.Text = icon;
            lblIcon.Font = new Font("Segoe UI Emoji", 28);
            lblIcon.Location = new Point(10, 10);
            lblIcon.Size = new Size(50, 50);

            Label lblText = new Label();
            lblText.Text = label;
            lblText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblText.Location = new Point(70, 15);
            lblText.AutoSize = true;

            Label lblValue = new Label();
            lblValue.Text = value;
            lblValue.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblValue.ForeColor = Color.MediumSlateBlue;
            lblValue.Location = new Point(70, 45);
            lblValue.AutoSize = true;

            panel.Controls.Add(lblIcon);
            panel.Controls.Add(lblText);
            panel.Controls.Add(lblValue);

            return panel;
        }
    }
}
