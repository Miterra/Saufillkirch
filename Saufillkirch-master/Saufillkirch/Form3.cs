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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            RemplirComboBox("SELECT nom FROM Caserne", cbx_caserne);

            pbx_premier.SizeMode = PictureBoxSizeMode.Zoom;

            pbx_precedent.SizeMode = PictureBoxSizeMode.Zoom;

            pbx_suivant.SizeMode = PictureBoxSizeMode.Zoom;

            pbx_dernier.SizeMode = PictureBoxSizeMode.Zoom;
        }

        List<string> typesEngins = new List<string>();
        int indexType = 0;
        int numero = 1;
        private ErrorProvider errSaisie = new ErrorProvider();

        private void Form3_Load(object sender, EventArgs e)
        {
            
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

        private void AfficherEnginsDansLabel(string requete, Label label)
        {
            try
            {
                StringBuilder resultats = new StringBuilder();

                using (var cmd = new SQLiteCommand(requete, Connexion.Connec))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string idCaserne = reader["idCaserne"].ToString();
                        string codeTypeEngin = reader["codeTypeEngin"].ToString();
                        string numero = reader["numero"].ToString();

                        
                        resultats.AppendLine($"{idCaserne} - {codeTypeEngin} - {numero}");
                    }
                }

                label.Text = resultats.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur affichage Label : " + ex.Message);
            }
        }

        private void RemplirCheckBox(string requete, CheckBox checkbox, string prefixe = "")
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
                    checkbox.Checked = true;
                }
                else
                {
                    checkbox.Checked = false;
                }

                // On empêche l'utilisateur de modifier la case
                checkbox.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur checkbox : {ex.Message}");
            }
        }

        private int GetMaxNumeroForType(int idCaserne, string typeEngin)
        {
            string requete = $@"SELECT COUNT(*) FROM Engin WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeEngin}'";
            using (var cmd = new SQLiteCommand(requete, Connexion.Connec))
            {
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
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

        private void cbx_caserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            typesEngins.Clear();
            indexType = 0;
            numero = 1;

            int idCaserne = cbx_caserne.SelectedIndex + 1;

            string reqTypes = $@"SELECT DISTINCT codeTypeEngin FROM Engin WHERE idCaserne = {idCaserne}";

            using (var cmd = new SQLiteCommand(reqTypes, Connexion.Connec))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    typesEngins.Add(reader.GetString(0));
                }
            }

            if (typesEngins.Count == 0)
            {
                MessageBox.Show("Aucun type d'engin trouvé pour cette caserne.");
                return;
            }

            // Chargement du premier engin directement
            string typeActuel = typesEngins[indexType];

            string requete1 = $@"SELECT idCaserne, codeTypeEngin, numero 
                         FROM Engin 
                         WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeActuel}' AND numero = {numero} 
                         LIMIT 1";
            AfficherEnginsDansLabel(requete1, lbl_id);

            string requete2 = $@"SELECT dateReception 
                         FROM Engin 
                         WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeActuel}' AND numero = {numero} 
                         LIMIT 1";
            RemplirLabel(requete2, lbl_date);

            string enMission = $@"SELECT enMission FROM engin WHERE idCaserne = {idCaserne} and codeTypeEngin = '{typeActuel}' and numero = {numero} and enMission = 1";
            string enPanne = $@"SELECT enMission FROM engin WHERE idCaserne = {idCaserne} and codeTypeEngin = '{typeActuel}' and numero = {numero} and enPanne = 1";

            RemplirCheckBox(enMission, chxbx_mission);
            RemplirCheckBox(enPanne, chxbx_panne);

            groupBox2.Visible = true;
            pbx_dernier.Visible = true;
            pbx_precedent.Visible = true;
            pbx_premier.Visible = true;
            pbx_suivant.Visible = true;
        }

        private void pbx_premier_Click(object sender, EventArgs e)
        {
            if (cbx_caserne.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez d'abord sélectionner une caserne.");
                return;
            }

            int idCaserne = cbx_caserne.SelectedIndex + 1;
            string typeActuel = typesEngins[indexType];

            indexType = 0;

            typeActuel = typesEngins[indexType];

            // Trouver le plus grand numéro pour ce type
            string requeteMax = $@"SELECT MIN(numero) FROM Engin 
                   WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeActuel}'";

            using (var cmd = new SQLiteCommand(requeteMax, Connexion.Connec))
            {
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    numero = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Aucun engin trouvé pour ce type.");
                    return;
                }
            }

            // Les labels se mettent à jour pour afficher le bon engin et la bonne date
            string requete1 = $@"SELECT idCaserne, codeTypeEngin, numero, enMission
                         FROM Engin 
                         WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeActuel}' AND numero = {numero} 
                         LIMIT 1";
            AfficherEnginsDansLabel(requete1, lbl_id);

            string requete2 = $@"SELECT dateReception 
                         FROM Engin 
                         WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeActuel}' AND numero = {numero} 
                         LIMIT 1";
            RemplirLabel(requete2, lbl_date);

            // Reqûetes pour voir si l'engin est en mission ou en panne
            string enMission = $@"SELECT enMission FROM engin WHERE idCaserne = {idCaserne} and codeTypeEngin = '{typeActuel}' and numero = {numero} and enMission = 1";
            string enPanne = $@"SELECT enMission FROM engin WHERE idCaserne = {idCaserne} and codeTypeEngin = '{typeActuel}' and numero = {numero} and enPanne = 1";

            RemplirCheckBox(enMission, chxbx_mission);
            RemplirCheckBox(enPanne, chxbx_panne);
        }

        private void pbx_precedent_Click(object sender, EventArgs e)
        {
            if (cbx_caserne.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez d'abord sélectionner une caserne.");
                return;
            }

            int idCaserne = cbx_caserne.SelectedIndex + 1;
            string typeActuel = typesEngins[indexType];

            if (numero > 1)
            {
                numero--;
            }
            else
            {
                // On passe au type précédent
                if (indexType > 0)
                {
                    indexType--;
                }
                else
                {
                    MessageBox.Show("Premier engin atteint.");
                    return;
                }

                typeActuel = typesEngins[indexType];

                string requeteMax = $@"SELECT MAX(numero) FROM Engin 
                               WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeActuel}'";

                using (var cmd = new SQLiteCommand(requeteMax, Connexion.Connec))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        numero = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Aucun engin trouvé pour ce type.");
                        return;
                    }
                }
            }

            // Les labels se mettent à jour pour afficher le bon engin et la bonne date
            string requete1 = $@"SELECT idCaserne, codeTypeEngin, numero, enMission
                         FROM Engin 
                         WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeActuel}' AND numero = {numero} 
                         LIMIT 1";
            AfficherEnginsDansLabel(requete1, lbl_id);

            string requete2 = $@"SELECT dateReception 
                         FROM Engin 
                         WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeActuel}' AND numero = {numero} 
                         LIMIT 1";
            RemplirLabel(requete2, lbl_date);

            // Reqûetes pour voir si l'engin est en mission ou en panne
            string enMission = $@"SELECT enMission FROM engin WHERE idCaserne = {idCaserne} and codeTypeEngin = '{typeActuel}' and numero = {numero} and enMission = 1";
            string enPanne = $@"SELECT enMission FROM engin WHERE idCaserne = {idCaserne} and codeTypeEngin = '{typeActuel}' and numero = {numero} and enPanne = 1";

            RemplirCheckBox(enMission, chxbx_mission);
            RemplirCheckBox(enPanne, chxbx_panne);

        }

        private void pbx_suivant_Click(object sender, EventArgs e)
        {
            int idCaserne = cbx_caserne.SelectedIndex + 1;

            if (typesEngins.Count == 0)
            {
                MessageBox.Show("Aucun type d'engin trouvé.");
                return;
            }

            string typeActuel = typesEngins[indexType];
            int maxNumero = GetMaxNumeroForType(idCaserne, typeActuel);

            if (numero < maxNumero)
            {
                numero++;
            }
            else
            {
                // On passe au type suivant
                if (indexType < typesEngins.Count - 1)
                {
                    indexType++;
                    numero = 1;
                }
                else
                {
                    MessageBox.Show("Tous les engins ont été parcourus.");
                    return;
                }
            }

            string nouveauType = typesEngins[indexType];

            // Les labels se mettent à jour pour afficher le bon engin et la bonne date
            string requete1 = $@"SELECT idCaserne, codeTypeEngin, numero 
                         FROM Engin 
                         WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{nouveauType}' AND numero = {numero} 
                         LIMIT 1";
            AfficherEnginsDansLabel(requete1, lbl_id);

            string requete2 = $@"SELECT dateReception 
                         FROM Engin 
                         WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{nouveauType}' AND numero = {numero} 
                         LIMIT 1";
            RemplirLabel(requete2, lbl_date);

            // Reqûetes pour voir si l'engin est en mission ou en panne
            string enMission = $@"SELECT enMission FROM engin WHERE idCaserne = {idCaserne} and codeTypeEngin = '{nouveauType}' and numero = {numero} and enMission = 1";
            string enPanne = $@"SELECT enMission FROM engin WHERE idCaserne = {idCaserne} and codeTypeEngin = '{typeActuel}' and numero = {numero} and enPanne = 1";

            RemplirCheckBox(enMission, chxbx_mission);
            RemplirCheckBox(enPanne, chxbx_panne);
        }

        private void pbx_dernier_Click(object sender, EventArgs e)
        {
            if (cbx_caserne.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez d'abord sélectionner une caserne.");
                return;
            }

            int idCaserne = cbx_caserne.SelectedIndex + 1;
            string typeActuel = typesEngins[indexType];

            // On sélectionne l'index 9 car il y a 10 engins différents
            indexType = 9;

            typeActuel = typesEngins[indexType];

            string requeteMax = $@"SELECT MAX(numero) FROM Engin 
                   WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeActuel}'";

            using (var cmd = new SQLiteCommand(requeteMax, Connexion.Connec))
            {
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    numero = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Aucun engin trouvé pour ce type.");
                    return;
                }
            }

            // Les labels se mettent à jour pour afficher le bon engin et la bonne date
            string requete1 = $@"SELECT idCaserne, codeTypeEngin, numero, enMission
                         FROM Engin 
                         WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeActuel}' AND numero = {numero} 
                         LIMIT 1";
            AfficherEnginsDansLabel(requete1, lbl_id);

            string requete2 = $@"SELECT dateReception 
                         FROM Engin 
                         WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{typeActuel}' AND numero = {numero} 
                         LIMIT 1";
            RemplirLabel(requete2, lbl_date);

            // Reqûetes pour voir si l'engin est en mission ou en panne
            string enMission = $@"SELECT enMission FROM engin WHERE idCaserne = {idCaserne} and codeTypeEngin = '{typeActuel}' and numero = {numero} and enMission = 1";
            string enPanne = $@"SELECT enMission FROM engin WHERE idCaserne = {idCaserne} and codeTypeEngin = '{typeActuel}' and numero = {numero} and enPanne = 1";

            RemplirCheckBox(enMission, chxbx_mission);
            RemplirCheckBox(enPanne, chxbx_panne);
        }
    }
}
