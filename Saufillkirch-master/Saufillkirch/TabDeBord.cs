using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Saufillkirch
{
    public partial class TabDeBord : Form
    {
        public TabDeBord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshTab();
            setTopButtons();
        }

        private void refreshTab()
        {
            try
            {
                PnlTblDeBord.Controls.Clear();
                // Requête SQL pour récupérer les IDs
                string requete = "SELECT m.id, m.dateHeureDepart, m.dateHeureRetour, m.motifAppel, c.nom, s.libelle " +
                    "FROM Mission m, Caserne c, NatureSinistre s " +
                    "WHERE m.idCaserne = c.id AND m.idNatureSinistre = s.id";

                SQLiteCommand cd = new SQLiteCommand(requete, Connexion.Connec);
                cd.CommandType = CommandType.Text;

                SQLiteDataReader data = cd.ExecuteReader();
                while (data.Read())
                {

                    string id = data.GetInt32(0).ToString();
                    string dateDep = data.GetString(1).ToString();
                    string dateFin;
                    try
                    {
                        dateFin = data.GetString(2).ToString(); // si il y a une date, la mettre
                    }
                    catch
                    {
                        dateFin = null; // sinon, afficher null (.toString() dans une date renvoie une erreur)
                    }
                    string motif = data.GetString(3).ToString();
                    string caserne = data.GetString(4).ToString();
                    string sinistre = data.GetString(5).ToString();

                    Mission btnMission = new Mission(id, dateDep, dateFin, caserne, sinistre, motif);

                    // bien positionner le bouton
                    if (ckbxEnCours.CheckState == CheckState.Checked)
                    {
                        if (dateFin == null)
                        {
                            PnlTblDeBord.Controls.Add(btnMission);
                        }
                    }
                    else
                    {
                        PnlTblDeBord.Controls.Add(btnMission);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }

        private void setTopButtons()
        {
            try
            {
                Dictionary<Form, string> dicForm = new Dictionary<Form, string> {
                    { new Form2(), "Créer Mission" },
                    { new Form3(), "Liste Engins" },
                    { new Form4(), "Fiche Pompiers" },
                    { new Form5(), "Statistique" }
                };

                int i = 0;
                foreach (var frm in dicForm)
                {
                    changerPage cp = new changerPage(frm.Value, frm.Key);
                    cp.Left = i*cp.Width;

                    panel1.Controls.Add(cp);
                    i++;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Il faut bien set la liste des forms dans 'setTopButtons'! (TabDeBord.cs)");
                MessageBox.Show(err.ToString());
            }
        }

        private void ckbxEnCours_CheckedChanged(object sender, EventArgs e)
        {
            refreshTab();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
