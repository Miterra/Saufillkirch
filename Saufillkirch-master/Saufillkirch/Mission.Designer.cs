namespace Saufillkirch
{
    partial class Mission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mission));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBxFinish = new System.Windows.Forms.PictureBox();
            this.picBxPDF = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDateDep = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.txtBxRaison = new System.Windows.Forms.RichTextBox();
            this.txtBxCaserne = new System.Windows.Forms.RichTextBox();
            this.lblSinistre = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picBxFinish
            // 
            this.picBxFinish.Image = ((System.Drawing.Image)(resources.GetObject("picBxFinish.Image")));
            this.picBxFinish.Location = new System.Drawing.Point(777, 60);
            this.picBxFinish.Name = "picBxFinish";
            this.picBxFinish.Size = new System.Drawing.Size(60, 60);
            this.picBxFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxFinish.TabIndex = 2;
            this.picBxFinish.TabStop = false;
            // 
            // picBxPDF
            // 
            this.picBxPDF.Image = ((System.Drawing.Image)(resources.GetObject("picBxPDF.Image")));
            this.picBxPDF.Location = new System.Drawing.Point(777, 0);
            this.picBxPDF.Name = "picBxPDF";
            this.picBxPDF.Size = new System.Drawing.Size(60, 60);
            this.picBxPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxPDF.TabIndex = 3;
            this.picBxPDF.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(123, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 17);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID NUMBER";
            // 
            // lblDateDep
            // 
            this.lblDateDep.AutoSize = true;
            this.lblDateDep.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F);
            this.lblDateDep.Location = new System.Drawing.Point(240, 12);
            this.lblDateDep.Name = "lblDateDep";
            this.lblDateDep.Size = new System.Drawing.Size(91, 17);
            this.lblDateDep.TabIndex = 5;
            this.lblDateDep.Text = "Date Depart :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F);
            this.lblDateFin.Location = new System.Drawing.Point(240, 34);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(67, 17);
            this.lblDateFin.TabIndex = 6;
            this.lblDateFin.Text = "Date Fin :";
            // 
            // txtBxRaison
            // 
            this.txtBxRaison.BackColor = System.Drawing.Color.IndianRed;
            this.txtBxRaison.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxRaison.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxRaison.ForeColor = System.Drawing.Color.Navy;
            this.txtBxRaison.Location = new System.Drawing.Point(503, 60);
            this.txtBxRaison.MaximumSize = new System.Drawing.Size(243, 57);
            this.txtBxRaison.MinimumSize = new System.Drawing.Size(243, 57);
            this.txtBxRaison.Name = "txtBxRaison";
            this.txtBxRaison.ReadOnly = true;
            this.txtBxRaison.Size = new System.Drawing.Size(243, 57);
            this.txtBxRaison.TabIndex = 9;
            this.txtBxRaison.Text = "alors oui eurrw";
            // 
            // txtBxCaserne
            // 
            this.txtBxCaserne.BackColor = System.Drawing.Color.IndianRed;
            this.txtBxCaserne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxCaserne.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F);
            this.txtBxCaserne.ForeColor = System.Drawing.Color.Black;
            this.txtBxCaserne.Location = new System.Drawing.Point(534, 12);
            this.txtBxCaserne.Name = "txtBxCaserne";
            this.txtBxCaserne.ReadOnly = true;
            this.txtBxCaserne.Size = new System.Drawing.Size(212, 39);
            this.txtBxCaserne.TabIndex = 10;
            this.txtBxCaserne.Text = "Caserne :";
            // 
            // lblSinistre
            // 
            this.lblSinistre.BackColor = System.Drawing.Color.IndianRed;
            this.lblSinistre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSinistre.Font = new System.Drawing.Font("Franklin Gothic Demi", 14F);
            this.lblSinistre.ForeColor = System.Drawing.Color.Ivory;
            this.lblSinistre.Location = new System.Drawing.Point(123, 60);
            this.lblSinistre.Name = "lblSinistre";
            this.lblSinistre.Size = new System.Drawing.Size(284, 57);
            this.lblSinistre.TabIndex = 11;
            this.lblSinistre.Text = "blabla blublub blobloblo";
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.lblSinistre);
            this.Controls.Add(this.txtBxCaserne);
            this.Controls.Add(this.txtBxRaison);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDep);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.picBxPDF);
            this.Controls.Add(this.picBxFinish);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(840, 120);
            this.MinimumSize = new System.Drawing.Size(840, 120);
            this.Name = "Mission";
            this.Size = new System.Drawing.Size(840, 120);
            this.Load += new System.EventHandler(this.Mission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBxFinish;
        private System.Windows.Forms.PictureBox picBxPDF;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDateDep;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.RichTextBox txtBxRaison;
        private System.Windows.Forms.RichTextBox txtBxCaserne;
        private System.Windows.Forms.RichTextBox lblSinistre;
    }
}
