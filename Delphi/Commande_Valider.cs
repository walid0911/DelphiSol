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
    public partial class Commande_Valider : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Authetification;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Commande_Valider()
        {
            InitializeComponent();
        }

        private void lnk_menu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Commande_Menu commande_Menu = new Commande_Menu();

            commande_Menu.Show();
            this.Hide();
        }

        private void txt_dpn_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "SELECT * FROM dbo.commandes WHERE statut = 'LIV' AND DPN LIKE '%" + txt_dpn.Text.Trim() + "%' ;";

                try
                {
                    if (txt_dpn.Text.Trim() != "")
                    {
                        connection.Open();

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStatement, connection);
                        DataTable data = new DataTable();

                        dataAdapter.Fill(data);
                        dgv_livraison.DataSource = data;
                        dgv_livraison.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgv_livraison.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    }
                    else
                    {
                        while (dgv_livraison.Rows.Count > 1)
                        {
                            dgv_livraison.Rows.Remove(dgv_livraison.Rows[0]);
                        }
                    }
                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message);
                }
            }
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_livraison.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                MessageBox.Show(dgv_livraison.SelectedRows[0].Cells[0].FormattedValue.ToString().Trim());
            }
            else
            {
                MessageBox.Show("Selectionnez une commande !!");
            }
        }
    }
}
