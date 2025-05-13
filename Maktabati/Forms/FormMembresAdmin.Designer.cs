namespace Maktabati
{
    partial class FormMembresAdmin
    {
        /// <summary>
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            detailsMembre = new GroupBox();
            dataGridView2 = new DataGridView();
            Historique = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Statut = new DataGridViewTextBoxColumn();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            btnRenouveler = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(222, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(405, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestion des adherants";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nom, Email, Date, Statut });
            dataGridView1.Location = new Point(175, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(594, 180);
            dataGridView1.TabIndex = 1;
            // 
            // detailsMembre
            // 
            detailsMembre.Location = new Point(20, 290);
            detailsMembre.Name = "detailsMembre";
            detailsMembre.Size = new Size(447, 157);
            detailsMembre.TabIndex = 2;
            detailsMembre.TabStop = false;
            detailsMembre.Text = "Details";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Historique });
            dataGridView2.Location = new Point(495, 296);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(274, 151);
            dataGridView2.TabIndex = 3;
            // 
            // Historique
            // 
            Historique.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Historique.HeaderText = "Historique";
            Historique.MinimumWidth = 6;
            Historique.Name = "Historique";
            // 
            // Nom
            // 
            Nom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nom.HeaderText = "Nom";
            Nom.MinimumWidth = 6;
            Nom.Name = "Nom";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date adhesion";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 160;
            // 
            // Statut
            // 
            Statut.HeaderText = "Statut";
            Statut.MinimumWidth = 6;
            Statut.Name = "Statut";
            Statut.Width = 125;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(20, 206);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(117, 29);
            btnSupprimer.TabIndex = 13;
            btnSupprimer.Text = "🗑️ Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(13, 161);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(124, 29);
            btnModifier.TabIndex = 12;
            btnModifier.Text = "✏️ Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(12, 115);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(125, 29);
            btnAjouter.TabIndex = 11;
            btnAjouter.Text = "➕ Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnRenouveler
            // 
            btnRenouveler.Location = new Point(324, 459);
            btnRenouveler.Name = "btnRenouveler";
            btnRenouveler.Size = new Size(210, 29);
            btnRenouveler.TabIndex = 14;
            btnRenouveler.Text = "🔁 Renouveler abonnement";
            btnRenouveler.UseVisualStyleBackColor = true;
            // 
            // FormMembresAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(btnRenouveler);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(dataGridView2);
            Controls.Add(detailsMembre);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMembresAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dataGridView1;
        private GroupBox detailsMembre;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Statut;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Historique;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private Button btnRenouveler;


    }
}