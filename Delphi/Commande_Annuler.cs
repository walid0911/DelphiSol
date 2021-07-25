using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Delphi
{
    public partial class Commande_Annuler : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Authetification;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Commande_Annuler()
        {
            InitializeComponent();
        }

        private void lnk_menu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Commande_Menu commande_Menu = new Commande_Menu();

            commande_Menu.Show();
            this.Hide();
        }

        private void btn_remove_commande_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM dbo.commande WHERE DPN = '"+ txt_dpn.Text.Trim() +"';", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message);
                }
            }
        }
    }
}
