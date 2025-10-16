using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using static System.Net.WebRequestMethods;
using System.Data.SqlClient;


namespace Saufillkirch
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Text = "Form2";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ActualiserLabelMission();
            Date.Text = "D\u00e9clench\u00e9e le : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            RemplirComboBox("SELECT libelle FROM NatureSinistre", cmbBox_Nature_sinistre);
            RemplirComboBox("SELECT nom FROM Caserne", cmbBox_Caserne_Mobiliser);
            RemplirComboBox("SELECT id, motifAppel FROM Mission", Supp_mission);
        }

        private void RemplirDataGridView(string requete, DataGridView dgv)
        {
            try
            {
                using (var adapter = new SQLiteDataAdapter(requete, Connexion.Connec))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des donn\u00e9es : {ex.Message}");
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
                    comboBox.Items.Add(row[0].ToString());
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

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Constituer_equipe_Click(object sender, EventArgs e)
        {
            if (cmbBox_Nature_sinistre.SelectedItem == null || cmbBox_Caserne_Mobiliser.SelectedItem == null)
            {
                MessageBox.Show("Veuillez s\u00e9lectionner une nature de sinistre et une caserne.", "S\u00e9lection incompl\u00e8te", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nature = cmbBox_Nature_sinistre.SelectedItem.ToString().Replace("'", "''");
            string caserne = cmbBox_Caserne_Mobiliser.SelectedItem.ToString().Replace("'", "''");

            bool CaserneCompatible(string nomCaserne)
            {
                string requete = $@"
                    SELECT COUNT(DISTINCT n.codeTypeEngin) = (
                        SELECT COUNT(DISTINCT n2.codeTypeEngin)
                        FROM Necessiter n2
                        JOIN NatureSinistre ns2 ON ns2.id = n2.idNatureSinistre
                        WHERE ns2.libelle = '{nature}'
                    ) AS Compatible
                    FROM Necessiter n
                    JOIN NatureSinistre ns ON ns.id = n.idNatureSinistre
                    JOIN Engin e ON e.codeTypeEngin = n.codeTypeEngin
                    JOIN Caserne c ON e.idCaserne = c.id
                    WHERE ns.libelle = '{nature}' AND c.nom = '{nomCaserne}'";

                DataTable dt = new DataTable();
                using (var adapter = new SQLiteDataAdapter(requete, Connexion.Connec))
                {
                    adapter.Fill(dt);
                }
                return dt.Rows.Count > 0 && Convert.ToBoolean(dt.Rows[0][0]);
            }

            string caserneCompatible = caserne;

            if (!CaserneCompatible(caserne))
            {
                string recherche = $@"
                    SELECT DISTINCT c.nom
                    FROM Caserne c
                    JOIN Engin e ON e.idCaserne = c.id
                    JOIN Necessiter n ON e.codeTypeEngin = n.codeTypeEngin
                    JOIN NatureSinistre ns ON ns.id = n.idNatureSinistre
                    WHERE ns.libelle = '{nature}'";

                DataTable dtRecherche = new DataTable();
                using (var adapter = new SQLiteDataAdapter(recherche, Connexion.Connec))
                {
                    adapter.Fill(dtRecherche);
                }

                foreach (DataRow row in dtRecherche.Rows)
                {
                    string candidate = row[0].ToString();
                    if (CaserneCompatible(candidate))
                    {
                        caserneCompatible = candidate;
                        break;
                    }
                }

                if (caserneCompatible != caserne)
                {
                    MessageBox.Show($"La caserne \u00ab {caserne} \u00bb ne peut pas intervenir. La caserne \u00ab {caserneCompatible} \u00bb a \u00e9t\u00e9 s\u00e9lectionn\u00e9e \u00e0 la place.");
                }
                else
                {
                    MessageBox.Show("Aucune caserne compatible trouv\u00e9e pour ce sinistre.");
                    return;
                }
            }

            RemplirDataGridView($@"
                SELECT po.matricule as 'Matricule', p.idHabilitation as 'Habilitation' 
                FROM Pompier po 
                JOIN Passer p ON po.matricule = p.matriculePompier 
                JOIN Affectation a ON po.matricule = a.matriculePompier 
                JOIN Caserne c ON a.idCaserne = c.id 
                WHERE c.nom = '{caserneCompatible}'",
                dataGridView2);

            RemplirDataGridView($@"
                SELECT e.codeTypeEngin as 'Type engin', e.numero as 'Numéro' 
                FROM Engin e 
                JOIN Necessiter n ON e.codeTypeEngin = n.codeTypeEngin 
                JOIN NatureSinistre ns ON n.idNatureSinistre = ns.id 
                JOIN Caserne c ON e.idCaserne = c.id
                WHERE ns.libelle = '{nature}' AND c.nom = '{caserneCompatible}'",
                dataGridView1);

            grp_pompiers.Visible = true;
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            cmbBox_Caserne_Mobiliser.SelectedIndex = -1;
            cmbBox_Nature_sinistre.SelectedIndex = -1;
            grp_pompiers.Visible = false;
        }





        private void btn_GenererPDF_Click(object sender, EventArgs e)
        {
            string motif = richTxtBox_Motif.Text;
            string rue = txtBox_Rue.Text;
            string codePostal = txtBox_Postal.Text;
            string ville = txtBox_Ville.Text;
            string nature = cmbBox_Nature_sinistre.SelectedItem?.ToString() ?? "Non sélectionnée";
            string caserne = cmbBox_Caserne_Mobiliser.SelectedItem?.ToString() ?? "Non sélectionnée";
            string compteRendu = compte_Rendu.Text;

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Fichier PDF|*.pdf",
                Title = "Enregistrer le récapitulatif"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        Document doc = new Document(PageSize.A4);
                        PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        // Titre
                        Paragraph titre = new Paragraph("Rapport de mission")
                        {
                            Alignment = Element.ALIGN_CENTER,
                            SpacingAfter = 20f
                        };
                        doc.Add(titre);

                        Font fontTitre = FontFactory.GetFont(FontFactory.HELVETICA, 18);


                        // Contenu
                        doc.Add(new Paragraph($"{Date.Text}"));
                        doc.Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------------------"));
                        doc.Add(new Paragraph(" "));
                        Paragraph Type_sinistre = new Paragraph($"Type de Sinistre : {cmbBox_Nature_sinistre.Text}", fontTitre);
                        doc.Add(Type_sinistre); doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph($"Motif : {motif}"));
                        doc.Add(new Paragraph($"Adresse : {rue} {codePostal} {ville}"));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph($"Compte-rendu : {compteRendu}"));
                        doc.Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------------------"));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph(" "));
                        Paragraph Caserne = new Paragraph($"Caserne : {caserne}", fontTitre);
                        doc.Add(Caserne); doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph(" "));
                        Paragraph Pompiers = new Paragraph("Pompiers affectés : ", fontTitre);
                        doc.Add(Pompiers); doc.Add(new Paragraph(" "));

                        string caserne2 = cmbBox_Caserne_Mobiliser.SelectedItem.ToString().Replace("'", "''");

                        List<PompierInfo> pompiers = RemplirListePompiers($@"
                        SELECT DISTINCT po.prenom as 'Prenom', g.libelle as 'Grade', po.nom as 'Nom', h.libelle as 'Libelle' 
                        FROM Pompier po
                        JOIN Passer p ON po.matricule = p.matriculePompier 
                        JOIN Affectation a ON po.matricule = a.matriculePompier 
                        JOIN Caserne c ON a.idCaserne = c.id 
                        JOIN Grade g ON g.code = po.codeGrade
                        JOIN Habilitation h ON p.idHabilitation = h.id
                        WHERE c.nom = '{caserne2}'");

                        List<string> list_libelle = new List<string>();

                        foreach (var pompier in pompiers)
                        {
                            if (!list_libelle.Contains(pompier.Libelle)) {
                                doc.Add(new Paragraph($"--> {pompier.Grade} {pompier.Prenom} {pompier.Nom} ({pompier.Libelle})"));
                                list_libelle.Add(pompier.Libelle);
                            }
                        }

                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph(" "));

                        Paragraph Engins = new Paragraph("Engins utilisés : ", fontTitre);
                        doc.Add(Engins); doc.Add(new Paragraph(" "));

                        string nature2 = cmbBox_Nature_sinistre.SelectedItem?.ToString() ?? "Non sélectionnée";

                        List<EnginInfo> engins = RemplirListeEngins($@"SELECT 
                            t.nom AS 'Nom',
                            e.codeTypeEngin AS 'Type',
                            e.numero AS 'Numéro',
	                        e.idCaserne AS 'idCaserne',
                            MAX(p.reparationsEventuelles) AS 'Réparation'
                        FROM Engin e
                        JOIN Necessiter n ON e.codeTypeEngin = n.codeTypeEngin
                        JOIN NatureSinistre ns ON n.idNatureSinistre = ns.id
                        JOIN Caserne c ON e.idCaserne = c.id
                        LEFT JOIN PartirAvec p ON p.codeTypeEngin = e.codeTypeEngin AND p.numeroEngin = e.numero
                        JOIN TypeEngin t ON t.code = e.codeTypeEngin
                        WHERE ns.libelle = '{nature2}'
                          AND c.nom = '{caserne2}'
                        GROUP BY t.nom, e.codeTypeEngin;");

                        foreach (var engin in engins)
                        {
                            if (engin.Réparation == "")
                            {
                                doc.Add(new Paragraph($"-->{engin.Nom} {engin.Numéro}-{engin.Type}-{engin.idCaserne} (Pas de réparations prévues)"));
                            }
                            else
                            {
                                doc.Add(new Paragraph($"-->{engin.Nom} {engin.Type} ({engin.Réparation})"));
                            }
                        }


                        doc.Close();
                    }

                    MessageBox.Show("PDF généré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la génération du PDF : " + ex.Message);
                }
            }
        }

        public class PompierInfo
        {
            public string Prenom { get; set; }
            public string Grade { get; set; }
            public string Nom { get; set; }
            public string Libelle { get; set; }
        }


        private List<PompierInfo> RemplirListePompiers(string requete)
        {
            List<PompierInfo> liste = new List<PompierInfo>();
            try
            {
                using (var cmd = new SQLiteCommand(requete, Connexion.Connec))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var info = new PompierInfo
                        {
                            Prenom = reader["Prenom"].ToString(),
                            Grade = reader["Grade"].ToString(),
                            Nom = reader["Nom"].ToString(),
                            Libelle = reader["Libelle"].ToString()
                        };
                        liste.Add(info);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur RemplirListePompiers : " + ex.Message);
            }
            return liste;
        }


        public class EnginInfo
        {
            public string Nom { get; set; }
            public string Numéro { get; set; }
            public string Type { get; set; }
            public string idCaserne { get; set; }
            public string Réparation { get; set; }
        }


        private List<EnginInfo> RemplirListeEngins(string requete)
        {
            List<EnginInfo> liste = new List<EnginInfo>();
            try
            {
                using (var cmd = new SQLiteCommand(requete, Connexion.Connec))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var info = new EnginInfo
                        {
                            Nom = reader["Nom"].ToString(),
                            Numéro = reader["Numéro"].ToString(),
                            Type = reader["Type"].ToString(),
                            idCaserne = reader["idCaserne"].ToString(),
                            Réparation = reader["Réparation"].ToString(),
                        };
                        liste.Add(info);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur RemplirListeEngins : " + ex.Message);
            }
            return liste;
        }




        private void AjouterNouvelleMission(string motif, string rue, string codePostal, string ville, string natureSinistreNom, string caserneNom, string compteRendu)
        {
            try
            {
                // Adapter les noms de colonnes selon ta base de données réelle :
                int idNatureSinistre = GetIdFromNom("NatureSinistre", "libelle", natureSinistreNom);
                int idCaserne = GetIdFromNom("Caserne", "nom", caserneNom);

                if (idNatureSinistre == -1 || idCaserne == -1)
                {
                    MessageBox.Show("Nature de sinistre ou caserne non trouvée. Vérifie les noms dans la base.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string requete = @"
            INSERT INTO Mission (motifAppel, adresse, cp, ville, dateHeureDepart, idNatureSinistre, idCaserne, compteRendu)
            VALUES (@motif, @adresse, @cp, @ville, @date, @idNature, @idCaserne, @compteRendu);
            SELECT last_insert_rowid();";

                using (var cmd = new SQLiteCommand(requete, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@motif", motif);
                    cmd.Parameters.AddWithValue("@adresse", rue);
                    cmd.Parameters.AddWithValue("@cp", codePostal);
                    cmd.Parameters.AddWithValue("@ville", ville);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@idNature", idNatureSinistre);
                    cmd.Parameters.AddWithValue("@idCaserne", idCaserne);
                    cmd.Parameters.AddWithValue("@compteRendu", compteRendu);

                    object result = cmd.ExecuteScalar();
                    long idMission = (result != null && long.TryParse(result.ToString(), out long id)) ? id : -1;

                    if (idMission != -1) {
                        MessageBox.Show($"Mission ajoutée avec succès ! (ID = {idMission})", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        MessageBox.Show("Mission ajoutée mais l'ID n'a pas pu être récupéré.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la mission : " + ex.Message);
            }
        }




        private int GetIdFromNom(string table, string champTexte, string valeur)
        {
            try
            {
                string requete = $"SELECT id FROM {table} WHERE {champTexte} = @valeur LIMIT 1";

                using (var cmd = new SQLiteCommand(requete, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@valeur", valeur);
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int id))
                        return id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur SQL pour {table}.{champTexte} : " + ex.Message);
            }

            return -1; // Valeur non trouvée
        }



        private void btn_AjouterMission_Click(object sender, EventArgs e)
        {
            // Ajouter la mission
            AjouterNouvelleMission(
                richTxtBox_Motif.Text,
                txtBox_Rue.Text,
                txtBox_Postal.Text,
                txtBox_Ville.Text,
                cmbBox_Nature_sinistre.SelectedItem?.ToString() ?? "",
                cmbBox_Caserne_Mobiliser.SelectedItem?.ToString() ?? "",
                compte_Rendu.Text
            );

            // Nettoyer tous les champs
            richTxtBox_Motif.Clear();
            txtBox_Rue.Clear();
            txtBox_Postal.Clear();
            txtBox_Ville.Clear();
            compte_Rendu.Clear();
            cmbBox_Nature_sinistre.SelectedIndex = -1;
            cmbBox_Caserne_Mobiliser.SelectedIndex = -1;
            grp_pompiers.Visible = false;

            // Actualiser les labels et le ComboBox
            ActualiserLabelMission(); // Utilise la nouvelle méthode
            Date.Text = "D\u00e9clench\u00e9e le : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            // Actualiser le ComboBox des missions à supprimer
            ActualiserComboBoxSuppMission();
        }

        private void btn_supp_mission_Click(object sender, EventArgs e)
        {
            if (Supp_mission.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une mission à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extraire l'ID de la mission à supprimer (le premier élément avant le '-')
            string selectedText = Supp_mission.SelectedItem.ToString();
            string idStr = selectedText.Split('-')[0].Trim();

            if (int.TryParse(idStr, out int idMission))
            {
                try
                {
                    using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Mission WHERE id = @id", Connexion.Connec))
                    {
                        cmd.Parameters.AddWithValue("@id", idMission);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mission supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualiserComboBoxSuppMission(); // Cette méthode actualise maintenant aussi le label Mission
                        }
                        else
                        {
                            MessageBox.Show("Aucune mission trouvée avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID de mission invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualiserComboBoxSuppMission()
        {
            try
            {
                // Sauvegarder l'élément sélectionné actuel
                var selectedItem = Supp_mission.SelectedItem;

                // Vider le ComboBox
                Supp_mission.Items.Clear();

                // Remplir à nouveau avec les données de la base
                RemplirComboBox("SELECT id, motifAppel FROM Mission", Supp_mission);

                // Restaurer la sélection si possible
                if (selectedItem != null && Supp_mission.Items.Contains(selectedItem))
                {
                    Supp_mission.SelectedItem = selectedItem;
                }

                // Actualiser aussi le label Mission avec le prochain ID disponible
                ActualiserLabelMission();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'actualisation du ComboBox : {ex.Message}");
            }
        }

        private void ActualiserLabelMission()
        {
            // Deux méthodes pour obtenir le prochain ID:
            // 1. MAX(id)+1 (si les IDs sont séquentiels)
            // 2. La dernière valeur de la séquence (plus fiable si des IDs ont été supprimés)
            string requete = "SELECT COALESCE(MAX(id), 0) + 1 FROM Mission";
            RemplirLabel(requete, Mission, "Mission n\u00b0 ");
        }


    }
}