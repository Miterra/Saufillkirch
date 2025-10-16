namespace Saufillkirch
{
    partial class Form4
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
            this.cbx_caserne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_pompier = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_bip = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_grade = new System.Windows.Forms.ComboBox();
            this.lbl_telephone = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_grade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_embauche = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_sexe = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_matricule = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sauvegarder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_caserne
            // 
            this.cbx_caserne.FormattingEnabled = true;
            this.cbx_caserne.Location = new System.Drawing.Point(92, 125);
            this.cbx_caserne.Name = "cbx_caserne";
            this.cbx_caserne.Size = new System.Drawing.Size(203, 21);
            this.cbx_caserne.TabIndex = 0;
            this.cbx_caserne.SelectedIndexChanged += new System.EventHandler(this.cbx_caserne_SelectedIndexChanged);
            this.cbx_caserne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_caserne_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(59, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veuillez sélectionner une caserne :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(59, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veuillez sélectionner un pompier : ";
            this.label2.Visible = false;
            // 
            // cbx_pompier
            // 
            this.cbx_pompier.FormattingEnabled = true;
            this.cbx_pompier.Location = new System.Drawing.Point(92, 224);
            this.cbx_pompier.Name = "cbx_pompier";
            this.cbx_pompier.Size = new System.Drawing.Size(203, 21);
            this.cbx_pompier.TabIndex = 3;
            this.cbx_pompier.Visible = false;
            this.cbx_pompier.SelectedIndexChanged += new System.EventHandler(this.cbx_pompier_SelectedIndexChanged);
            this.cbx_pompier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_pompier_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbl_embauche);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_date);
            this.groupBox1.Controls.Add(this.lbl_sexe);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_prenom);
            this.groupBox1.Controls.Add(this.lbl_nom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_matricule);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(384, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 402);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(538, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 99);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_sauvegarder);
            this.groupBox2.Controls.Add(this.lbl_bip);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbx_grade);
            this.groupBox2.Controls.Add(this.lbl_telephone);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbx_grade);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14F);
            this.groupBox2.Location = new System.Drawing.Point(54, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 115);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carrière";
            // 
            // lbl_bip
            // 
            this.lbl_bip.AutoSize = true;
            this.lbl_bip.Location = new System.Drawing.Point(486, 74);
            this.lbl_bip.Name = "lbl_bip";
            this.lbl_bip.Size = new System.Drawing.Size(46, 22);
            this.lbl_bip.TabIndex = 16;
            this.lbl_bip.Text = "[bip]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 22);
            this.label11.TabIndex = 15;
            this.label11.Text = "Bip :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Changer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_grade
            // 
            this.cbx_grade.FormattingEnabled = true;
            this.cbx_grade.Location = new System.Drawing.Point(211, 32);
            this.cbx_grade.Name = "cbx_grade";
            this.cbx_grade.Size = new System.Drawing.Size(152, 30);
            this.cbx_grade.TabIndex = 13;
            this.cbx_grade.Visible = false;
            this.cbx_grade.SelectedIndexChanged += new System.EventHandler(this.cbx_grade_SelectedIndexChanged);
            this.cbx_grade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_grade_KeyPress);
            // 
            // lbl_telephone
            // 
            this.lbl_telephone.AutoSize = true;
            this.lbl_telephone.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_telephone.Location = new System.Drawing.Point(145, 74);
            this.lbl_telephone.Name = "lbl_telephone";
            this.lbl_telephone.Size = new System.Drawing.Size(200, 22);
            this.lbl_telephone.TabIndex = 12;
            this.lbl_telephone.Text = "[numéro de téléphone]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Téléphone :";
            // 
            // tbx_grade
            // 
            this.tbx_grade.Enabled = false;
            this.tbx_grade.Location = new System.Drawing.Point(131, 33);
            this.tbx_grade.Name = "tbx_grade";
            this.tbx_grade.Size = new System.Drawing.Size(69, 29);
            this.tbx_grade.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Grade :";
            // 
            // lbl_embauche
            // 
            this.lbl_embauche.AutoSize = true;
            this.lbl_embauche.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_embauche.Location = new System.Drawing.Point(264, 227);
            this.lbl_embauche.Name = "lbl_embauche";
            this.lbl_embauche.Size = new System.Drawing.Size(166, 22);
            this.lbl_embauche.TabIndex = 11;
            this.lbl_embauche.Text = "[date d\'embauche]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(50, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Date d\'embauche :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_date.Location = new System.Drawing.Point(264, 186);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(174, 22);
            this.lbl_date.TabIndex = 9;
            this.lbl_date.Text = "[date de naissance]";
            // 
            // lbl_sexe
            // 
            this.lbl_sexe.AutoSize = true;
            this.lbl_sexe.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_sexe.Location = new System.Drawing.Point(184, 147);
            this.lbl_sexe.Name = "lbl_sexe";
            this.lbl_sexe.Size = new System.Drawing.Size(61, 22);
            this.lbl_sexe.TabIndex = 8;
            this.lbl_sexe.Text = "[sexe]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(50, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date de naissance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(50, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sexe :";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_prenom.Location = new System.Drawing.Point(184, 106);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(85, 22);
            this.lbl_prenom.TabIndex = 5;
            this.lbl_prenom.Text = "[prénom]";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_nom.Location = new System.Drawing.Point(184, 61);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(57, 22);
            this.lbl_nom.TabIndex = 4;
            this.lbl_nom.Text = "[nom]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(50, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(50, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nom :";
            // 
            // lbl_matricule
            // 
            this.lbl_matricule.AutoSize = true;
            this.lbl_matricule.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_matricule.Location = new System.Drawing.Point(330, 26);
            this.lbl_matricule.Name = "lbl_matricule";
            this.lbl_matricule.Size = new System.Drawing.Size(41, 22);
            this.lbl_matricule.TabIndex = 1;
            this.lbl_matricule.Text = "[nb]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(239, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Matricule";
            // 
            // btn_sauvegarder
            // 
            this.btn_sauvegarder.Location = new System.Drawing.Point(367, 32);
            this.btn_sauvegarder.Name = "btn_sauvegarder";
            this.btn_sauvegarder.Size = new System.Drawing.Size(63, 30);
            this.btn_sauvegarder.TabIndex = 17;
            this.btn_sauvegarder.Text = "SAV";
            this.btn_sauvegarder.UseVisualStyleBackColor = true;
            this.btn_sauvegarder.Visible = false;
            this.btn_sauvegarder.Click += new System.EventHandler(this.btn_sauvegarder_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button2.Location = new System.Drawing.Point(973, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Plus d\'informations";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 14F);
            this.groupBox3.Location = new System.Drawing.Point(384, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(695, 268);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informations carrière";
            this.groupBox3.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14F);
            this.label12.Location = new System.Drawing.Point(20, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "Caserne de rattachement :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(299, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 29);
            this.textBox1.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14F);
            this.label13.Location = new System.Drawing.Point(21, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 22);
            this.label13.TabIndex = 13;
            this.label13.Text = "Habilitations";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(643, 91);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1094, 701);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbx_pompier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_caserne);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form4";
            this.Text = "Gestion du personnel";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_caserne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_pompier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_matricule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_sexe;
        private System.Windows.Forms.Label lbl_embauche;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbx_grade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_telephone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_grade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_bip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sauvegarder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}