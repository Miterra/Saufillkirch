using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saufillkirch
{
    public partial class Mission : UserControl
    {
        private string m_num = "0";
        private string m_dateDepart = "01/01/1990";
        private string m_dateFin = null;
        private string m_caserne = "caserne_générique";
        private string m_sinistre = "Sinistre générique";
        private string m_raison = "Raison générique";

        public Mission(string num, string dateDep, string dateFin, string caserne, string sinistre, string raison)
        {
            InitializeComponent();
            m_num = num;
            m_dateDepart = dateDep;
            m_dateFin = dateFin;
            m_caserne = caserne;
            m_sinistre = sinistre;
            m_raison = raison;
        }

        private void Mission_Load(object sender, EventArgs e)
        {
            lblID.Text = "ID : " + m_num;
            lblDateDep.Text = "Date Départ : " + m_dateDepart;
            if (m_dateFin != null)
            {
                lblDateFin.Text = "Date Fin : " + m_dateFin;
            }
            else
            {
                lblDateFin.Text = "En cours";
                lblDateFin.BackColor = Color.Green;
            }
            txtBxCaserne.Text = "Caserne : " + m_caserne;
            lblSinistre.Text = "--> " + m_sinistre;
            txtBxRaison.Text = m_raison;
        }
    }
}
