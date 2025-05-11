namespace Maktabati
{
    partial class FormPenalites
    {
        /// <summary>FormPenalites
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            dataGridView1 = new DataGridView();
            btnPenalite = new Button();
            Membre = new DataGridViewTextBoxColumn();
            EmpruntId = new DataGridViewTextBoxColumn();
            EstPayee = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(222, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(305, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Espace Penalites";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(291, 84);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(181, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Penalites Membres!";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Membre, EmpruntId, EstPayee, Date });
            dataGridView1.Location = new Point(101, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(579, 236);
            dataGridView1.TabIndex = 2;
            // 
            // btnPenalite
            // 
            btnPenalite.Location = new Point(291, 392);
            btnPenalite.Name = "btnPenalite";
            btnPenalite.Size = new Size(204, 29);
            btnPenalite.TabIndex = 3;
            btnPenalite.Text = "🔓 Débloquer membre";
            btnPenalite.UseVisualStyleBackColor = true;
            // 
            // Membre
            // 
            Membre.HeaderText = "Membre";
            Membre.MinimumWidth = 6;
            Membre.Name = "Membre";
            Membre.Width = 94;
            // 
            // EmpruntId
            // 
            EmpruntId.HeaderText = "Reference emprunte";
            EmpruntId.MinimumWidth = 6;
            EmpruntId.Name = "EmpruntId";
            EmpruntId.Width = 172;
            // 
            // EstPayee
            // 
            EstPayee.HeaderText = "statut penalite";
            EstPayee.MinimumWidth = 6;
            EstPayee.Name = "EstPayee";
            EstPayee.Width = 133;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // FormPenalites
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(btnPenalite);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPenalites";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        private Label lblTitle;
        private Label lblSubtitle;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private DataGridView dataGridView1;
        private Button btnPenalite;
        private DataGridViewTextBoxColumn Membre;
        private DataGridViewTextBoxColumn EmpruntId;
        private DataGridViewTextBoxColumn EstPayee;
        private DataGridViewTextBoxColumn Date;
    }
}