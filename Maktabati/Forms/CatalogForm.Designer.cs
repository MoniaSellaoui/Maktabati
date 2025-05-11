namespace Maktabati.Forms
{
    partial class CatalogForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            textBox1 = new TextBox();
            comboAuteur = new ComboBox();
            comboCateg = new ComboBox();
            comboStatut = new ComboBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Titre = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Statut = new DataGridViewTextBoxColumn();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(222, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(370, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Catalogue des livres";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(232, 59);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(347, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Bienvenue dans le catalogue des livres.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 102);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Rechercher un livre ?";
            textBox1.Size = new Size(430, 27);
            textBox1.TabIndex = 2;
            // 
            // comboAuteur
            // 
            comboAuteur.FormattingEnabled = true;
            comboAuteur.Location = new Point(199, 159);
            comboAuteur.Name = "comboAuteur";
            comboAuteur.Size = new Size(130, 28);
            comboAuteur.TabIndex = 4;
            comboAuteur.Text = "Auteur";
            // 
            // comboCateg
            // 
            comboCateg.FormattingEnabled = true;
            comboCateg.Location = new Point(335, 159);
            comboCateg.Name = "comboCateg";
            comboCateg.Size = new Size(139, 28);
            comboCateg.TabIndex = 5;
            comboCateg.Text = "Category";
            // 
            // comboStatut
            // 
            comboStatut.FormattingEnabled = true;
            comboStatut.Location = new Point(480, 159);
            comboStatut.Name = "comboStatut";
            comboStatut.Size = new Size(139, 28);
            comboStatut.TabIndex = 6;
            comboStatut.Text = "Disponibilite";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Titre, Genre, Statut });
            dataGridView1.Location = new Point(97, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(632, 202);
            dataGridView1.TabIndex = 7;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 53;
            // 
            // Titre
            // 
            Titre.HeaderText = "Titre";
            Titre.MinimumWidth = 6;
            Titre.Name = "Titre";
            Titre.Width = 200;
            // 
            // Genre
            // 
            Genre.HeaderText = "Genre";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.Width = 200;
            // 
            // Statut
            // 
            Statut.HeaderText = "Disponibilite";
            Statut.MinimumWidth = 6;
            Statut.Name = "Statut";
            Statut.Width = 125;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(222, 425);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(125, 29);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "➕ Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(353, 425);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(124, 29);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "✏️ Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(483, 425);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(117, 29);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "🗑️ Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // CatalogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(dataGridView1);
            Controls.Add(comboStatut);
            Controls.Add(comboCateg);
            Controls.Add(comboAuteur);
            Controls.Add(textBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CatalogForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboAuteur;
        private ComboBox comboCateg;
        private ComboBox comboStatut;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titre;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Statut;
    }
}
