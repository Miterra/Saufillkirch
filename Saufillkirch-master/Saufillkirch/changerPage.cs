using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Saufillkirch
{
    public partial class changerPage : UserControl
    {
        public string texte;
        public Form cible;

        public changerPage(string txt, Form cib)
        {
            InitializeComponent();
            texte = txt;
            cible = cib;
            rtxtBxTitre.Text = texte;

        }

        private void changerPage_Click(object sender, EventArgs e)
        {
            cible.ShowDialog();
        }

        private void picBxIcone_Click(object sender, EventArgs e)
        {
            cible.ShowDialog();
        }

        private void rtxtBxTitre_Click(object sender, EventArgs e)
        {
            cible.ShowDialog();
        }

        private void changerPage_Load(object sender, EventArgs e)
        {

        }
    }
}
