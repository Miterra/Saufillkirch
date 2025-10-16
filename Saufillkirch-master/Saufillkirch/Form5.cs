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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            RemplirComboBox("SELECT nom FROM Caserne", cbx_caserne);
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

        private void btn_choix_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = true;
            btn_choix.Visible = false;
            btn_ensemble.Visible = false;
            cbx_caserne.Visible = true;
        }

        private void cbx_caserne_SelectedIndexChanged(object sender, EventArgs e)
        {           
            int idCaserne = cbx_caserne.SelectedIndex + 1;

            string caserne = $@"SELECT codeTypeEngin, COUNT(*) AS nombre_utilisations
                                FROM Engin
                                WHERE idCaserne = {idCaserne}
                                GROUP BY codeTypeEngin
                                ORDER BY nombre_utilisations DESC;";

            string heure = $@"SELECT e.codeTypeEngin, SUM(JULIANDAY(m.dateHeureRetour) - JULIANDAY(m.dateHeureDepart)) * 24 AS heures_utilisation
                                FROM Engin e
                                JOIN Mission m ON m.idCaserne = e.idCaserne
                                WHERE e.idCaserne = {idCaserne}
                                GROUP BY e.codeTypeEngin
                                ORDER BY heures_utilisation DESC;";

            RemplirRichTextBox(caserne, rtbx_enginsUtil);
            RemplirRichTextBox(heure, rtbx_nbHeures);

            label3.Visible = true;
            label4.Visible = true;
            rtbx_enginsUtil.Visible = true;
            rtbx_nbHeures.Visible = true;


        }

        private void btn_ensemble_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            btn_choix.Visible = false;
            btn_ensemble.Visible = false;
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;
            richTextBox3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            string intervention = $@"SELECT ns.libelle AS type_sinistre, COUNT(*) AS nombre_interventions
                                     FROM Mission m
                                     JOIN NatureSinistre ns ON ns.id = m.idNatureSinistre
                                     GROUP BY ns.libelle
                                     ORDER BY nombre_interventions DESC;";
            RemplirRichTextBox(intervention, richTextBox1);

            string habilitations = $@"SELECT h.libelle, COUNT(*) AS nombre_solicitations
                                      FROM Mobiliser mo
                                      JOIN Habilitation h ON h.id = mo.idHabilitation
                                      GROUP BY h.libelle
                                      ORDER BY nombre_solicitations DESC;";
            RemplirRichTextBox(habilitations, richTextBox2);

            string habilitationsPompier = $@"SELECT h.libelle AS habilitation, p.nom || ' ' || p.prenom AS pompier
                                             FROM Habilitation h
                                             LEFT JOIN Mobiliser mo ON mo.idHabilitation = h.id
                                             LEFT JOIN Pompier p ON p.matricule = mo.matriculePompier
                                             ORDER BY h.libelle, pompier;";
            RemplirRichTextBox(habilitationsPompier, richTextBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            richTextBox2.Text = "";
            richTextBox2.Visible = false;
            richTextBox3.Text = "";
            richTextBox3.Visible = false;

            label1.Visible = true;
            btn_choix.Visible = true;
            btn_ensemble.Visible = true;
            label2.Visible = false;
            cbx_caserne.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            rtbx_enginsUtil.Text = "";
            rtbx_enginsUtil.Visible = false;
            rtbx_nbHeures.Text = "";
            rtbx_nbHeures.Visible = false;

        }
    }
}
