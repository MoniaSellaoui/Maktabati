namespace Maktabati
{
    partial class FormSauvegarde
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
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(235, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(353, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Espace Sauvegarde";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(357, 121);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(121, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sauvegarde!";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(621, 214);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(117, 29);
            btnSupprimer.TabIndex = 16;
            btnSupprimer.Text = "Restaurer BD";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(255, 329);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(124, 29);
            btnModifier.TabIndex = 15;
            btnModifier.Text = "exporter";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(255, 214);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(125, 29);
            btnAjouter.TabIndex = 14;
            btnAjouter.Text = "Save BD";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(621, 329);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 17;
            button1.Text = "importer";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 218);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 18;
            label1.Text = "💾 Sauvegarder base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 333);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 19;
            label2.Text = "⇅ Exporter JSON/CSV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 218);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 20;
            label3.Text = "📂 Restaurer base";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(438, 338);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 21;
            label4.Text = "⬇️ Importer JSON/CSV";
            // 
            // FormSauvegarde
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSauvegarde";
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

        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}