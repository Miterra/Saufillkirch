namespace Saufillkirch
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_choix = new System.Windows.Forms.Button();
            this.btn_ensemble = new System.Windows.Forms.Button();
            this.cbx_caserne = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbx_enginsUtil = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbx_nbHeures = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(308, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisissez une option :";
            // 
            // btn_choix
            // 
            this.btn_choix.Location = new System.Drawing.Point(270, 82);
            this.btn_choix.Name = "btn_choix";
            this.btn_choix.Size = new System.Drawing.Size(130, 67);
            this.btn_choix.TabIndex = 1;
            this.btn_choix.Text = "Choix d\'une caserne";
            this.btn_choix.UseVisualStyleBackColor = true;
            this.btn_choix.Click += new System.EventHandler(this.btn_choix_Click);
            // 
            // btn_ensemble
            // 
            this.btn_ensemble.Location = new System.Drawing.Point(406, 82);
            this.btn_ensemble.Name = "btn_ensemble";
            this.btn_ensemble.Size = new System.Drawing.Size(130, 67);
            this.btn_ensemble.TabIndex = 2;
            this.btn_ensemble.Text = "Ensemble des casernes";
            this.btn_ensemble.UseVisualStyleBackColor = true;
            this.btn_ensemble.Click += new System.EventHandler(this.btn_ensemble_Click);
            // 
            // cbx_caserne
            // 
            this.cbx_caserne.FormattingEnabled = true;
            this.cbx_caserne.Location = new System.Drawing.Point(329, 82);
            this.cbx_caserne.Name = "cbx_caserne";
            this.cbx_caserne.Size = new System.Drawing.Size(153, 21);
            this.cbx_caserne.TabIndex = 3;
            this.cbx_caserne.Visible = false;
            this.cbx_caserne.SelectedIndexChanged += new System.EventHandler(this.cbx_caserne_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(292, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choisissez une caserne :";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(199, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Engins les plus utilisés";
            this.label3.Visible = false;
            // 
            // rtbx_enginsUtil
            // 
            this.rtbx_enginsUtil.Font = new System.Drawing.Font("Arial", 14F);
            this.rtbx_enginsUtil.Location = new System.Drawing.Point(144, 177);
            this.rtbx_enginsUtil.Name = "rtbx_enginsUtil";
            this.rtbx_enginsUtil.Size = new System.Drawing.Size(256, 109);
            this.rtbx_enginsUtil.TabIndex = 6;
            this.rtbx_enginsUtil.Text = "";
            this.rtbx_enginsUtil.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(402, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre total d\'heures";
            this.label4.Visible = false;
            // 
            // rtbx_nbHeures
            // 
            this.rtbx_nbHeures.Font = new System.Drawing.Font("Arial", 14F);
            this.rtbx_nbHeures.Location = new System.Drawing.Point(406, 177);
            this.rtbx_nbHeures.Name = "rtbx_nbHeures";
            this.rtbx_nbHeures.Size = new System.Drawing.Size(256, 109);
            this.rtbx_nbHeures.TabIndex = 8;
            this.rtbx_nbHeures.Text = "";
            this.rtbx_nbHeures.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 14F);
            this.richTextBox1.Location = new System.Drawing.Point(22, 189);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(254, 128);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Arial", 14F);
            this.richTextBox2.Location = new System.Drawing.Point(282, 189);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(254, 128);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Arial", 14F);
            this.richTextBox3.Location = new System.Drawing.Point(542, 189);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(254, 128);
            this.richTextBox3.TabIndex = 11;
            this.richTextBox3.Text = "";
            this.richTextBox3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Réinitialiser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(68, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nb interventions";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(278, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Habilitations les plus sollicitées";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(545, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Liste pompier par habilitation";
            this.label7.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(824, 329);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rtbx_nbHeures);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbx_enginsUtil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_caserne);
            this.Controls.Add(this.btn_ensemble);
            this.Controls.Add(this.btn_choix);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_choix;
        private System.Windows.Forms.Button btn_ensemble;
        private System.Windows.Forms.ComboBox cbx_caserne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbx_enginsUtil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbx_nbHeures;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}