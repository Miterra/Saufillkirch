namespace Saufillkirch
{
    partial class Form2
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
            this.btn_fermer = new System.Windows.Forms.Button();
            this.grp_info = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTxtBox_Motif = new System.Windows.Forms.RichTextBox();
            this.txtBox_Ville = new System.Windows.Forms.TextBox();
            this.txtBox_Postal = new System.Windows.Forms.TextBox();
            this.txtBox_Rue = new System.Windows.Forms.TextBox();
            this.grp_decision = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBox_Caserne_Mobiliser = new System.Windows.Forms.ComboBox();
            this.cmbBox_Nature_sinistre = new System.Windows.Forms.ComboBox();
            this.btn_Constituer_equipe = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.grp_pompiers = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mission = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.btn_GenererPDF = new System.Windows.Forms.Button();
            this.compte_Rendu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_AjouterMission = new System.Windows.Forms.Button();
            this.Supp_mission = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_supp_mission = new System.Windows.Forms.Button();
            this.grp_info.SuspendLayout();
            this.grp_decision.SuspendLayout();
            this.grp_pompiers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(725, 414);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(63, 25);
            this.btn_fermer.TabIndex = 0;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // grp_info
            // 
            this.grp_info.BackColor = System.Drawing.Color.OldLace;
            this.grp_info.Controls.Add(this.label9);
            this.grp_info.Controls.Add(this.label8);
            this.grp_info.Controls.Add(this.label7);
            this.grp_info.Controls.Add(this.label6);
            this.grp_info.Controls.Add(this.label5);
            this.grp_info.Controls.Add(this.richTxtBox_Motif);
            this.grp_info.Controls.Add(this.txtBox_Ville);
            this.grp_info.Controls.Add(this.txtBox_Postal);
            this.grp_info.Controls.Add(this.txtBox_Rue);
            this.grp_info.Location = new System.Drawing.Point(92, 38);
            this.grp_info.Name = "grp_info";
            this.grp_info.Size = new System.Drawing.Size(618, 128);
            this.grp_info.TabIndex = 1;
            this.grp_info.TabStop = false;
            this.grp_info.Text = "Informations usager";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ville";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Code Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adresse sinistre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Motif";
            // 
            // richTxtBox_Motif
            // 
            this.richTxtBox_Motif.Location = new System.Drawing.Point(54, 20);
            this.richTxtBox_Motif.Name = "richTxtBox_Motif";
            this.richTxtBox_Motif.Size = new System.Drawing.Size(168, 63);
            this.richTxtBox_Motif.TabIndex = 4;
            this.richTxtBox_Motif.Text = "";
            // 
            // txtBox_Ville
            // 
            this.txtBox_Ville.Location = new System.Drawing.Point(324, 91);
            this.txtBox_Ville.Name = "txtBox_Ville";
            this.txtBox_Ville.Size = new System.Drawing.Size(270, 20);
            this.txtBox_Ville.TabIndex = 3;
            // 
            // txtBox_Postal
            // 
            this.txtBox_Postal.Location = new System.Drawing.Point(324, 63);
            this.txtBox_Postal.Name = "txtBox_Postal";
            this.txtBox_Postal.Size = new System.Drawing.Size(72, 20);
            this.txtBox_Postal.TabIndex = 2;
            // 
            // txtBox_Rue
            // 
            this.txtBox_Rue.Location = new System.Drawing.Point(324, 37);
            this.txtBox_Rue.Name = "txtBox_Rue";
            this.txtBox_Rue.Size = new System.Drawing.Size(270, 20);
            this.txtBox_Rue.TabIndex = 1;
            // 
            // grp_decision
            // 
            this.grp_decision.BackColor = System.Drawing.Color.OldLace;
            this.grp_decision.Controls.Add(this.label4);
            this.grp_decision.Controls.Add(this.label3);
            this.grp_decision.Controls.Add(this.cmbBox_Caserne_Mobiliser);
            this.grp_decision.Controls.Add(this.cmbBox_Nature_sinistre);
            this.grp_decision.Controls.Add(this.btn_Constituer_equipe);
            this.grp_decision.Controls.Add(this.btn_Annuler);
            this.grp_decision.Location = new System.Drawing.Point(92, 172);
            this.grp_decision.Name = "grp_decision";
            this.grp_decision.Size = new System.Drawing.Size(618, 65);
            this.grp_decision.TabIndex = 2;
            this.grp_decision.TabStop = false;
            this.grp_decision.Text = "Décisions du régulateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Caserne à mobiliser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nature du sinistre";
            // 
            // cmbBox_Caserne_Mobiliser
            // 
            this.cmbBox_Caserne_Mobiliser.DisplayMember = "salut";
            this.cmbBox_Caserne_Mobiliser.FormattingEnabled = true;
            this.cmbBox_Caserne_Mobiliser.Location = new System.Drawing.Point(460, 15);
            this.cmbBox_Caserne_Mobiliser.Name = "cmbBox_Caserne_Mobiliser";
            this.cmbBox_Caserne_Mobiliser.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Caserne_Mobiliser.TabIndex = 5;
            // 
            // cmbBox_Nature_sinistre
            // 
            this.cmbBox_Nature_sinistre.FormattingEnabled = true;
            this.cmbBox_Nature_sinistre.Location = new System.Drawing.Point(122, 15);
            this.cmbBox_Nature_sinistre.Name = "cmbBox_Nature_sinistre";
            this.cmbBox_Nature_sinistre.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Nature_sinistre.TabIndex = 4;
            // 
            // btn_Constituer_equipe
            // 
            this.btn_Constituer_equipe.Location = new System.Drawing.Point(496, 42);
            this.btn_Constituer_equipe.Name = "btn_Constituer_equipe";
            this.btn_Constituer_equipe.Size = new System.Drawing.Size(98, 23);
            this.btn_Constituer_equipe.TabIndex = 1;
            this.btn_Constituer_equipe.Text = "Constituer équipe";
            this.btn_Constituer_equipe.UseVisualStyleBackColor = true;
            this.btn_Constituer_equipe.Click += new System.EventHandler(this.btn_Constituer_equipe_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(380, 42);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(98, 23);
            this.btn_Annuler.TabIndex = 0;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // grp_pompiers
            // 
            this.grp_pompiers.BackColor = System.Drawing.Color.OldLace;
            this.grp_pompiers.Controls.Add(this.dataGridView2);
            this.grp_pompiers.Controls.Add(this.dataGridView1);
            this.grp_pompiers.Controls.Add(this.label2);
            this.grp_pompiers.Controls.Add(this.label1);
            this.grp_pompiers.Location = new System.Drawing.Point(92, 243);
            this.grp_pompiers.Name = "grp_pompiers";
            this.grp_pompiers.Size = new System.Drawing.Size(618, 152);
            this.grp_pompiers.TabIndex = 3;
            this.grp_pompiers.TabStop = false;
            this.grp_pompiers.Text = "Mobilisation des engins et des pompiers";
            this.grp_pompiers.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(324, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(257, 98);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(248, 98);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pompiers mobilisés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Engins mobilisés";
            // 
            // Mission
            // 
            this.Mission.AutoSize = true;
            this.Mission.Location = new System.Drawing.Point(143, 13);
            this.Mission.Name = "Mission";
            this.Mission.Size = new System.Drawing.Size(42, 13);
            this.Mission.TabIndex = 4;
            this.Mission.Text = "Mission";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(472, 12);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 5;
            this.Date.Text = "Date";
            // 
            // btn_GenererPDF
            // 
            this.btn_GenererPDF.Location = new System.Drawing.Point(12, 401);
            this.btn_GenererPDF.Name = "btn_GenererPDF";
            this.btn_GenererPDF.Size = new System.Drawing.Size(92, 37);
            this.btn_GenererPDF.TabIndex = 6;
            this.btn_GenererPDF.Text = "Génération du PDF";
            this.btn_GenererPDF.UseVisualStyleBackColor = true;
            this.btn_GenererPDF.Click += new System.EventHandler(this.btn_GenererPDF_Click);
            // 
            // compte_Rendu
            // 
            this.compte_Rendu.Location = new System.Drawing.Point(319, 410);
            this.compte_Rendu.Name = "compte_Rendu";
            this.compte_Rendu.Size = new System.Drawing.Size(192, 20);
            this.compte_Rendu.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Compte rendu :";
            // 
            // btn_AjouterMission
            // 
            this.btn_AjouterMission.Location = new System.Drawing.Point(110, 401);
            this.btn_AjouterMission.Name = "btn_AjouterMission";
            this.btn_AjouterMission.Size = new System.Drawing.Size(109, 37);
            this.btn_AjouterMission.TabIndex = 9;
            this.btn_AjouterMission.Text = "Ajouter Mission";
            this.btn_AjouterMission.UseVisualStyleBackColor = true;
            this.btn_AjouterMission.Click += new System.EventHandler(this.btn_AjouterMission_Click);
            // 
            // Supp_mission
            // 
            this.Supp_mission.FormattingEnabled = true;
            this.Supp_mission.Location = new System.Drawing.Point(528, 417);
            this.Supp_mission.Name = "Supp_mission";
            this.Supp_mission.Size = new System.Drawing.Size(121, 21);
            this.Supp_mission.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Supprimer la mission :";
            // 
            // btn_supp_mission
            // 
            this.btn_supp_mission.Location = new System.Drawing.Point(655, 415);
            this.btn_supp_mission.Name = "btn_supp_mission";
            this.btn_supp_mission.Size = new System.Drawing.Size(64, 23);
            this.btn_supp_mission.TabIndex = 12;
            this.btn_supp_mission.Text = "Supprimer";
            this.btn_supp_mission.UseVisualStyleBackColor = true;
            this.btn_supp_mission.Click += new System.EventHandler(this.btn_supp_mission_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_supp_mission);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Supp_mission);
            this.Controls.Add(this.btn_AjouterMission);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.compte_Rendu);
            this.Controls.Add(this.btn_GenererPDF);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Mission);
            this.Controls.Add(this.grp_pompiers);
            this.Controls.Add(this.grp_decision);
            this.Controls.Add(this.grp_info);
            this.Controls.Add(this.btn_fermer);
            this.Name = "Form2";
            this.Text = "Gestion d\'une nouvelle mission";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grp_info.ResumeLayout(false);
            this.grp_info.PerformLayout();
            this.grp_decision.ResumeLayout(false);
            this.grp_decision.PerformLayout();
            this.grp_pompiers.ResumeLayout(false);
            this.grp_pompiers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.GroupBox grp_info;
        private System.Windows.Forms.GroupBox grp_decision;
        private System.Windows.Forms.GroupBox grp_pompiers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Constituer_equipe;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Label Mission;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox txtBox_Ville;
        private System.Windows.Forms.TextBox txtBox_Postal;
        private System.Windows.Forms.TextBox txtBox_Rue;
        private System.Windows.Forms.ComboBox cmbBox_Caserne_Mobiliser;
        private System.Windows.Forms.ComboBox cmbBox_Nature_sinistre;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTxtBox_Motif;
        private System.Windows.Forms.Button btn_GenererPDF;
        private System.Windows.Forms.TextBox compte_Rendu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_AjouterMission;
        private System.Windows.Forms.ComboBox Supp_mission;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_supp_mission;
    }
}