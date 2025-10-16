using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saufillkirch
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private ErrorProvider errSaisie = new ErrorProvider();

        private void Form4_Load(object sender, EventArgs e)
        {
            RemplirComboBox("SELECT nom FROM Caserne", cbx_caserne);
        }

        private void RemplirComboBox(string requete, ComboBox comboBox)
        {
            try
            {
                DataTable dt = new DataTable();
                using (var adapter = new SQLiteDataAdapter(requete, Connexion.Connec))
                {
                    adapter.Fill(dt);
                }

                foreach (DataRow row in dt.Rows)
                {
                    if (dt.Columns.Contains("prenom") && dt.Columns.Contains("nom"))
                    {
                        string prenom = row["prenom"].ToString();
                        string nom = row["nom"].ToString();
                        comboBox.Items.Add($"{prenom} {":"} {nom}");
                    }
                    else
                    {
                        comboBox.Items.Add(row[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur combo : {ex.Message}");
            }
        }

        private void RemplirLabel(string requete, Label label, string prefixe = "")
        {
            try
            {
                DataTable dt = new DataTable();
                using (var adapter = new SQLiteDataAdapter(requete, Connexion.Connec))
                {
                    adapter.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    label.Text = prefixe + dt.Rows[0][0].ToString();
                }
                else
                {
                    label.Text = prefixe + "Aucune donn\u00e9e.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur label : {ex.Message}");
            }
        }

        private void RemplirTextBox(string requete, TextBox textBox)
        {
            try
            {
                using (var cmd = new SQLiteCommand(requete, Connexion.Connec))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        textBox.Text = result.ToString();
                    }
                    else
                    {
                        textBox.Text = "Aucune donnée.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur textbox : {ex.Message}");
            }
        }

        private void RemplirRichTextBox(string requete, RichTextBox richTextBox)
        {
            try
            {
                DataTable dt = new DataTable();
                using (var adapter = new SQLiteDataAdapter(requete, Connexion.Connec))
                {
                    adapter.Fill(dt);
                }

                richTextBox.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    richTextBox.AppendText(row[0].ToString() + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur RichTextBox : " + ex.Message);
            }
        }


        private void cbx_caserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_pompier.Items.Clear();
            int idCaserne = cbx_caserne.SelectedIndex + 1;

            label2.Visible = true;
            cbx_pompier.Visible = true;
            btn_sauvegarder.Visible = false;
            button1.Visible = false;
            cbx_grade.Visible = false;

            RemplirComboBox($@"SELECT P.prenom, P.nom
                                FROM Pompier P
                                JOIN Affectation A ON P.matricule = A.matriculePompier
                                WHERE A.idCaserne = {idCaserne}
                                AND A.dateFin IS NULL;", cbx_pompier);
        }

        private void cbx_pompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageList imageGrade = new ImageList();

            imageGrade.Images.Add("SAP", Image.FromFile("ImagesGrades/SAP.png"));
            imageGrade.Images.Add("SAP1", Image.FromFile("ImagesGrades/SAP1.png"));
            imageGrade.Images.Add("CPL", Image.FromFile("ImagesGrades/CPL.png"));
            imageGrade.Images.Add("CCH", Image.FromFile("ImagesGrades/CCH.png"));
            imageGrade.Images.Add("SGT", Image.FromFile("ImagesGrades/SGT.png"));
            imageGrade.Images.Add("SCH", Image.FromFile("ImagesGrades/SCH.png"));
            imageGrade.Images.Add("ADJ", Image.FromFile("ImagesGrades/ADJ.png"));
            imageGrade.Images.Add("ADC", Image.FromFile("ImagesGrades/ADC.png"));
            imageGrade.Images.Add("LTN", Image.FromFile("ImagesGrades/LTN.png"));
            imageGrade.Images.Add("CNE", Image.FromFile("ImagesGrades/CNE.png"));
            imageGrade.Images.Add("CDT", Image.FromFile("ImagesGrades/CDT.png"));
            imageGrade.Images.Add("LCL", Image.FromFile("ImagesGrades/LCL.png"));
            imageGrade.Images.Add("COL", Image.FromFile("ImagesGrades/COL.png"));

            groupBox1.Visible = true;
            cbx_grade.Visible = false;
            cbx_grade.Text = "";
            btn_sauvegarder.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            groupBox3.Visible = false;

            cbx_grade.Items.Clear();
            string prenom = cbx_pompier.Text.ToLower().Split(':')[0].Trim();
            string nom = cbx_pompier.Text.ToLower().Split(':')[1].Trim();

            string matricule = $@"SELECT matricule from pompier where lower(prenom) = '{prenom}'";
            RemplirLabel(matricule, lbl_matricule);

            string demandePrenom = $@"SELECT prenom FROM pompier where lower(prenom) = '{prenom}'";
            RemplirLabel(demandePrenom, lbl_prenom);

            string demandeNom = $@"SELECT nom FROM pompier where lower(nom) = '{nom}'";
            RemplirLabel(demandeNom, lbl_nom);

            string sexe = $@"SELECT sexe FROM pompier where lower(prenom) = '{prenom}' AND lower(nom) = '{nom}'";
            RemplirLabel(sexe, lbl_sexe);

            string date = $@"SELECT dateNaissance FROM pompier where lower(prenom) = '{prenom}' AND lower(nom) = '{nom}'";
            RemplirLabel(date, lbl_date);

            string embauche = $@"SELECT dateEmbauche FROM Pompier where lower(prenom) = '{prenom}' and lower(nom) = '{nom}'";
            RemplirLabel(embauche, lbl_embauche);

            string grade = $@"SELECT codeGrade FROM Pompier where lower(prenom) = '{prenom}' and lower(nom) = '{nom}'";
            RemplirTextBox(grade, tbx_grade);

            string telephone = $@"SELECT portable FROM Pompier where lower(prenom) = '{prenom}' and lower(nom) = '{nom}'";
            RemplirLabel(telephone, lbl_telephone);

            string bip = $@"SELECT bip FROM Pompier where lower(prenom) = '{prenom}' and lower(nom) = '{nom}'";
            RemplirLabel(bip, lbl_bip);

            string cle = tbx_grade.Text.ToUpper();

            if (imageGrade.Images.ContainsKey(cle))
            {
                pictureBox1.Image = imageGrade.Images[cle];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\bebeybena\\Downloads\\imageskk\\Rafael_Leao.png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemplirComboBox("SELECT libelle FROM Grade", cbx_grade);
            cbx_grade.Visible = true;
            btn_sauvegarder.Visible = true;
        }

        private void cbx_grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageList imageGrade = new ImageList();

            imageGrade.Images.Add("SAP", Image.FromFile("ImagesGrades/SAP.png"));
            imageGrade.Images.Add("SAP1", Image.FromFile("ImagesGrades/SAP1.png"));
            imageGrade.Images.Add("CPL", Image.FromFile("ImagesGrades/CPL.png"));
            imageGrade.Images.Add("CCH", Image.FromFile("ImagesGrades/CCH.png"));
            imageGrade.Images.Add("SGT", Image.FromFile("ImagesGrades/SGT.png"));
            imageGrade.Images.Add("SCH", Image.FromFile("ImagesGrades/SCH.png"));
            imageGrade.Images.Add("ADJ", Image.FromFile("ImagesGrades/ADJ.png"));
            imageGrade.Images.Add("ADC", Image.FromFile("ImagesGrades/ADC.png"));
            imageGrade.Images.Add("LTN", Image.FromFile("ImagesGrades/LTN.png"));
            imageGrade.Images.Add("CNE", Image.FromFile("ImagesGrades/CNE.png"));
            imageGrade.Images.Add("CDT", Image.FromFile("ImagesGrades/CDT.png"));
            imageGrade.Images.Add("LCL", Image.FromFile("ImagesGrades/LCL.png"));
            imageGrade.Images.Add("COL", Image.FromFile("ImagesGrades/COL.png"));

            string newGrade = $@"SELECT code FROM Grade where libelle = '{cbx_grade.SelectedItem.ToString()}'";
            RemplirTextBox(newGrade, tbx_grade);

            string cle = tbx_grade.Text.ToUpper();

            if (imageGrade.Images.ContainsKey(cle))
            {
                pictureBox1.Image = imageGrade.Images[cle];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\bebeybena\\Downloads\\imageskk\\Rafael_Leao.png");
            }
        }

        private void cbx_caserne_KeyPress(object sender, KeyPressEventArgs e)
        {
            // savoir qui m'appelle ?
            ComboBox t = (ComboBox)sender;

            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                errSaisie.SetError(t, "Sélectionnez la caserne directement avec la ComboBox ! ");
            }
            else
            {
                e.Handled = false;
                errSaisie.SetError(t, "");
            }
        }

        private void cbx_pompier_KeyPress(object sender, KeyPressEventArgs e)
        {
            // savoir qui m'appelle ?
            ComboBox t = (ComboBox)sender;

            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                errSaisie.SetError(t, "Sélectionnez le pompier directement avec la ComboBox ! ");
            }
            else
            {
                e.Handled = false;
                errSaisie.SetError(t, "");
            }
        }

        private void cbx_grade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // savoir qui m'appelle ?
            ComboBox t = (ComboBox)sender;

            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                errSaisie.SetError(t, "Sélectionnez le grade directement avec la ComboBox ! ");
            }
            else
            {
                e.Handled = false;
                errSaisie.SetError(t, "");
            }
        }



        private void btn_sauvegarder_Click(object sender, EventArgs e)
        {         
            string nouveauGrade = tbx_grade.Text.ToUpper();
            string matricule = lbl_matricule.Text;

            string requete = $@"UPDATE Pompier SET codeGrade = '{nouveauGrade}' WHERE matricule = '{matricule}'";

            using (var cmd = new SQLiteCommand(requete, Connexion.Connec))
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Grade mis à jour avec succès !");
                MessageBox.Show("Vous avez sauvegardé le grade de " + lbl_prenom.Text + " " + lbl_nom.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string prenom = cbx_pompier.Text.ToLower().Split(':')[0].Trim();
            string nom = cbx_pompier.Text.ToLower().Split(':')[1].Trim();

            groupBox3.Visible = true;
            button2.Visible = false;
            textBox1.Text = cbx_caserne.Text;

            string hab = $@"select h.libelle from Habilitation h JOIN Passer P ON h.id = P.idHabilitation JOIN Pompier Po ON Po.matricule = P.matriculePompier WHERE lower(Po.prenom) = '{prenom}' AND lower(Po.nom) = '{nom}';";
            RemplirRichTextBox(hab, richTextBox1);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // savoir qui m'appelle ?
            RichTextBox t = (RichTextBox)sender;

            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                errSaisie.SetError(t, "Vous pouvez seulement visualiser les habilitations !");
            }
            else
            {
                e.Handled = false;
                errSaisie.SetError(t, "");
            }
        }
    }
}
