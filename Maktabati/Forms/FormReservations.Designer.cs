namespace Maktabati
{
    partial class FormReservations
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
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            dataGridView1 = new DataGridView();
            membre = new DataGridViewTextBoxColumn();
            livre = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            statut = new DataGridViewTextBoxColumn();
            btnDeleteResv = new Button();
            btnConfirm = new Button();
            groupBoxFilAtt = new GroupBox();
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
            lblTitle.Size = new Size(353, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Espace Reservation";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(297, 81);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(197, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Reservation en cours!";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { membre, livre, date, statut });
            dataGridView1.Location = new Point(12, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(591, 184);
            dataGridView1.TabIndex = 2;
            // 
            // membre
            // 
            membre.HeaderText = "Membre";
            membre.MinimumWidth = 6;
            membre.Name = "membre";
            membre.Width = 125;
            // 
            // livre
            // 
            livre.HeaderText = "Livre";
            livre.MinimumWidth = 6;
            livre.Name = "livre";
            livre.Width = 125;
            // 
            // date
            // 
            date.HeaderText = "Date reservation";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 160;
            // 
            // statut
            // 
            statut.HeaderText = "Statut";
            statut.MinimumWidth = 6;
            statut.Name = "statut";
            statut.Width = 125;
            // 
            // btnDeleteResv
            // 
            btnDeleteResv.Location = new Point(647, 228);
            btnDeleteResv.Name = "btnDeleteResv";
            btnDeleteResv.Size = new Size(117, 29);
            btnDeleteResv.TabIndex = 15;
            btnDeleteResv.Text = "🗑️ Supprimer";
            btnDeleteResv.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(613, 193);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(175, 29);
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "✅ Valider réservation";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // groupBoxFilAtt
            // 
            groupBoxFilAtt.Location = new Point(39, 328);
            groupBoxFilAtt.Name = "groupBoxFilAtt";
            groupBoxFilAtt.Size = new Size(725, 143);
            groupBoxFilAtt.TabIndex = 16;
            groupBoxFilAtt.TabStop = false;
            groupBoxFilAtt.Text = "File d attente";
            // 
            // FormReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(groupBoxFilAtt);
            Controls.Add(btnDeleteResv);
            Controls.Add(btnConfirm);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReservations";
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
        private DataGridViewTextBoxColumn membre;
        private DataGridViewTextBoxColumn livre;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn statut;
        private Button btnDeleteResv;
        private Button btnConfirm;
        private GroupBox groupBoxFilAtt;
    }
}