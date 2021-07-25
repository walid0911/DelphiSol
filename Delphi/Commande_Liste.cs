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
    public partial class Commande_Liste : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Authetification;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Commande_Liste()
        {
            InitializeComponent();
        }

        private void lnk_menu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Commande_Menu commande_Menu = new Commande_Menu();

            commande_Menu.Show();
            this.Hide();
        }

        private void Commande_Liste_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter_cmd = new SqlDataAdapter("SELECT * FROM dbo.commandes WHERE statut='CMD';", connection);
                    DataTable data_cmd = new DataTable();
                    dataAdapter_cmd.Fill(data_cmd);
                    dgv_commande.DataSource = data_cmd;
                    dgv_commande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv_commande.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    /*for (int i=0; i<dgv_commande.Rows.Count - 1; i++ )
                    {
                        if (dgv_commande.Rows[i].Cells[6].FormattedValue.ToString().Trim() == "LIV") 
                        {
                            dgv_commande.Rows[i].Cells[6].Style.BackColor = Color.Green;
                        }
                        else if (dgv_commande.Rows[i].Cells[6].FormattedValue.ToString().Trim() == "CMD")
                        {
                            dgv_commande.Rows[i].Cells[6].Style.BackColor = Color.Red;
                        }
                    }*/

                    SqlDataAdapter dataAdapter_liv = new SqlDataAdapter("SELECT * FROM dbo.commandes WHERE statut='LIV';", connection);
                    DataTable data_liv = new DataTable();
                    dataAdapter_liv.Fill(data_liv);
                    dgv_livraison.DataSource = data_liv;
                    dgv_livraison.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv_livraison.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    

                    SqlDataAdapter dataAdapter_his = new SqlDataAdapter("SELECT * FROM dbo.commandes;", connection);
                    DataTable data_his = new DataTable();
                    dataAdapter_his.Fill(data_his);
                    dgv_historique.DataSource = data_his;
                    dgv_historique.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv_historique.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    
                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message);
                }
            }
        }

    }
}
