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
	public partial class Commande_placer : Form
	{
		private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Authetification;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		public Commande_placer()
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
				string sqlStatement = "SELECT * FROM dbo.commandes WHERE DPN LIKE '%"+ txt_dpn.Text.Trim() +"%' ;";

				try
				{
					if(txt_dpn.Text.Trim() != "")
					{
						connection.Open();

						SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStatement, connection);
						DataTable data = new DataTable();

						dataAdapter.Fill(data);
						dgv_commande.DataSource = data;
						dgv_commande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
						dgv_commande.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
					}
                    else
                    {
                        while (dgv_commande.Rows.Count > 1)
                        {
							dgv_commande.Rows.Remove(dgv_commande.Rows[0]);
                        }
                    }
				}
				catch (Exception except)
				{
					MessageBox.Show(except.Message);
				}
			}
		}

		private void btn_add_order_Click(object sender, EventArgs e)
		{
			int selectedRowCount = dgv_commande.Rows.GetRowCount(DataGridViewElementStates.Selected);
			if(selectedRowCount > 0)
			{
				MessageBox.Show(dgv_commande.SelectedRows[0].Cells[0].FormattedValue.ToString().Trim());
			}
			else
			{
				MessageBox.Show("Selectionnez une commande !!");
			}
		}
	}
}
