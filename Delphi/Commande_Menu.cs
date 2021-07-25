using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delphi
{
    public partial class Commande_Menu : Form
    {
        public Commande_Menu()
        {
            InitializeComponent();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            Commande_Liste commande_liste = new Commande_Liste();

            commande_liste.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Commande_placer commande_placer = new Commande_placer();

            commande_placer.Show();
            this.Hide();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Commande_Annuler commande_annuler = new Commande_Annuler();

            commande_annuler.Show();
            this.Hide();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            Commande_Valider commande_valider = new Commande_Valider();

            commande_valider.Show();
            this.Hide();
        }
    }
}
