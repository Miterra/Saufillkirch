namespace Saufillkirch
{
    partial class changerPage
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBxIcone = new System.Windows.Forms.PictureBox();
            this.rtxtBxTitre = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // picBxIcone
            // 
            this.picBxIcone.Location = new System.Drawing.Point(3, 3);
            this.picBxIcone.Name = "picBxIcone";
            this.picBxIcone.Size = new System.Drawing.Size(63, 62);
            this.picBxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxIcone.TabIndex = 0;
            this.picBxIcone.TabStop = false;
            this.picBxIcone.Click += new System.EventHandler(this.picBxIcone_Click);
            // 
            // rtxtBxTitre
            // 
            this.rtxtBxTitre.BackColor = System.Drawing.Color.IndianRed;
            this.rtxtBxTitre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtBxTitre.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F);
            this.rtxtBxTitre.ForeColor = System.Drawing.Color.Wheat;
            this.rtxtBxTitre.Location = new System.Drawing.Point(74, 5);
            this.rtxtBxTitre.MaxLength = 50;
            this.rtxtBxTitre.Name = "rtxtBxTitre";
            this.rtxtBxTitre.ReadOnly = true;
            this.rtxtBxTitre.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtBxTitre.Size = new System.Drawing.Size(101, 60);
            this.rtxtBxTitre.TabIndex = 1;
            this.rtxtBxTitre.Text = "TEXT TEST FORM";
            this.rtxtBxTitre.Click += new System.EventHandler(this.rtxtBxTitre_Click);
            // 
            // changerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtxtBxTitre);
            this.Controls.Add(this.picBxIcone);
            this.Name = "changerPage";
            this.Size = new System.Drawing.Size(178, 68);
            this.Load += new System.EventHandler(this.changerPage_Load);
            this.Click += new System.EventHandler(this.changerPage_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picBxIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxIcone;
        private System.Windows.Forms.RichTextBox rtxtBxTitre;
    }
}
