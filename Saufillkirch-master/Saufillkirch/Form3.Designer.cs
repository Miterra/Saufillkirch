namespace Saufillkirch
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_caserne = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chxbx_panne = new System.Windows.Forms.CheckBox();
            this.chxbx_mission = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.pbx_dernier = new System.Windows.Forms.PictureBox();
            this.pbx_suivant = new System.Windows.Forms.PictureBox();
            this.pbx_precedent = new System.Windows.Forms.PictureBox();
            this.pbx_premier = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_dernier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_suivant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_precedent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_premier)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(28, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choix de la caserne";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_caserne);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(187, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbx_caserne
            // 
            this.cbx_caserne.FormattingEnabled = true;
            this.cbx_caserne.Location = new System.Drawing.Point(233, 29);
            this.cbx_caserne.Name = "cbx_caserne";
            this.cbx_caserne.Size = new System.Drawing.Size(193, 21);
            this.cbx_caserne.TabIndex = 1;
            this.cbx_caserne.SelectedIndexChanged += new System.EventHandler(this.cbx_caserne_SelectedIndexChanged);
            this.cbx_caserne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_caserne_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(20, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numéro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chxbx_panne);
            this.groupBox2.Controls.Add(this.chxbx_mission);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_date);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbl_id);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(98, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 325);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // chxbx_panne
            // 
            this.chxbx_panne.AutoSize = true;
            this.chxbx_panne.Enabled = false;
            this.chxbx_panne.Location = new System.Drawing.Point(166, 265);
            this.chxbx_panne.Name = "chxbx_panne";
            this.chxbx_panne.Size = new System.Drawing.Size(15, 14);
            this.chxbx_panne.TabIndex = 9;
            this.chxbx_panne.UseVisualStyleBackColor = true;
            // 
            // chxbx_mission
            // 
            this.chxbx_mission.AutoSize = true;
            this.chxbx_mission.Enabled = false;
            this.chxbx_mission.Location = new System.Drawing.Point(166, 210);
            this.chxbx_mission.Name = "chxbx_mission";
            this.chxbx_mission.Size = new System.Drawing.Size(15, 14);
            this.chxbx_mission.TabIndex = 8;
            this.chxbx_mission.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(20, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "En panne";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(20, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "En mission";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_date.Location = new System.Drawing.Point(217, 82);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(135, 22);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "[date a inserer]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(20, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de réception";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_id.Location = new System.Drawing.Point(171, 16);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(119, 22);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "[nb a inserer]";
            // 
            // pbx_dernier
            // 
            this.pbx_dernier.Image = global::Saufillkirch.Properties.Resources.Dernier;
            this.pbx_dernier.Location = new System.Drawing.Point(564, 450);
            this.pbx_dernier.Name = "pbx_dernier";
            this.pbx_dernier.Size = new System.Drawing.Size(70, 44);
            this.pbx_dernier.TabIndex = 7;
            this.pbx_dernier.TabStop = false;
            this.pbx_dernier.Visible = false;
            this.pbx_dernier.Click += new System.EventHandler(this.pbx_dernier_Click);
            // 
            // pbx_suivant
            // 
            this.pbx_suivant.Image = global::Saufillkirch.Properties.Resources.Suivant;
            this.pbx_suivant.Location = new System.Drawing.Point(436, 450);
            this.pbx_suivant.Name = "pbx_suivant";
            this.pbx_suivant.Size = new System.Drawing.Size(70, 44);
            this.pbx_suivant.TabIndex = 6;
            this.pbx_suivant.TabStop = false;
            this.pbx_suivant.Visible = false;
            this.pbx_suivant.Click += new System.EventHandler(this.pbx_suivant_Click);
            // 
            // pbx_precedent
            // 
            this.pbx_precedent.Image = global::Saufillkirch.Properties.Resources.Precedent;
            this.pbx_precedent.Location = new System.Drawing.Point(268, 450);
            this.pbx_precedent.Name = "pbx_precedent";
            this.pbx_precedent.Size = new System.Drawing.Size(70, 44);
            this.pbx_precedent.TabIndex = 5;
            this.pbx_precedent.TabStop = false;
            this.pbx_precedent.Visible = false;
            this.pbx_precedent.Click += new System.EventHandler(this.pbx_precedent_Click);
            // 
            // pbx_premier
            // 
            this.pbx_premier.ErrorImage = null;
            this.pbx_premier.Image = global::Saufillkirch.Properties.Resources.Premier;
            this.pbx_premier.Location = new System.Drawing.Point(151, 450);
            this.pbx_premier.Name = "pbx_premier";
            this.pbx_premier.Size = new System.Drawing.Size(70, 44);
            this.pbx_premier.TabIndex = 4;
            this.pbx_premier.TabStop = false;
            this.pbx_premier.Visible = false;
            this.pbx_premier.Click += new System.EventHandler(this.pbx_premier_Click);
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(802, 535);
            this.Controls.Add(this.pbx_dernier);
            this.Controls.Add(this.pbx_suivant);
            this.Controls.Add(this.pbx_precedent);
            this.Controls.Add(this.pbx_premier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engins enregistrés";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_dernier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_suivant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_precedent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_premier)).EndInit();
            this.ResumeLayout(false);

        }

        private Mission btnFormulaire1;
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_caserne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.CheckBox chxbx_panne;
        private System.Windows.Forms.CheckBox chxbx_mission;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.PictureBox pbx_premier;
        private System.Windows.Forms.PictureBox pbx_precedent;
        private System.Windows.Forms.PictureBox pbx_suivant;
        private System.Windows.Forms.PictureBox pbx_dernier;
    }
}