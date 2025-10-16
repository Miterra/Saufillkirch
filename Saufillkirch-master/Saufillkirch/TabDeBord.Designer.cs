namespace Saufillkirch
{
    partial class TabDeBord
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabDeBord));
            this.label1 = new System.Windows.Forms.Label();
            this.ckbxEnCours = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlTblDeBord = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(419, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tableau de bord";
            // 
            // ckbxEnCours
            // 
            this.ckbxEnCours.AutoSize = true;
            this.ckbxEnCours.BackColor = System.Drawing.Color.OldLace;
            this.ckbxEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ckbxEnCours.ForeColor = System.Drawing.Color.IndianRed;
            this.ckbxEnCours.Location = new System.Drawing.Point(39, 26);
            this.ckbxEnCours.Name = "ckbxEnCours";
            this.ckbxEnCours.Size = new System.Drawing.Size(83, 21);
            this.ckbxEnCours.TabIndex = 0;
            this.ckbxEnCours.Text = "En cours";
            this.ckbxEnCours.UseVisualStyleBackColor = false;
            this.ckbxEnCours.CheckedChanged += new System.EventHandler(this.ckbxEnCours_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 92);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(957, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.PnlTblDeBord);
            this.panel2.Controls.Add(this.ckbxEnCours);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 427);
            this.panel2.TabIndex = 6;
            // 
            // PnlTblDeBord
            // 
            this.PnlTblDeBord.AutoScroll = true;
            this.PnlTblDeBord.BackColor = System.Drawing.Color.Wheat;
            this.PnlTblDeBord.Font = new System.Drawing.Font("Symap", 8.25F);
            this.PnlTblDeBord.Location = new System.Drawing.Point(19, 61);
            this.PnlTblDeBord.Name = "PnlTblDeBord";
            this.PnlTblDeBord.Size = new System.Drawing.Size(1007, 349);
            this.PnlTblDeBord.TabIndex = 5;
            // 
            // TabDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1086, 580);
            this.MinimumSize = new System.Drawing.Size(1086, 580);
            this.Name = "TabDeBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tableau de bord";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbxEnCours;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel PnlTblDeBord;
        private changerPage cP;
    }
}

