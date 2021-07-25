using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Delphi
{
    public partial class Connection : Form
    {
        private string connectionString = @"server=remotemysql.com;uid=g6ras3ZQEa;pwd=HOR3SPsor3;database=g6ras3ZQEas;";
        public Connection()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sqlStatement = "SELECT * FROM Login WHERE Num_Matricule = @username and password = @password;";

                MySqlCommand command = new MySqlCommand(sqlStatement, connection);

                command.Parameters.AddWithValue("@username",txt_user.Text.Trim());
                command.Parameters.AddWithValue("@password",txt_password.Text.Trim());

                try
                {
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (reader[2].ToString().Trim() == "commande")
                        {
                            Commande_Menu commande_menu = new Commande_Menu();
                            commande_menu.Show();
                        }
                        if (reader[2].ToString().Trim() == "magazin")
                        {
                            MessageBox.Show("magazin");
                        }
                        if (reader[2].ToString().Trim() == "admin")
                        {
                            MessageBox.Show("admin");
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Votre matricule ou mot de passe sont incorrectes !!");
                    }
                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message);
                }
            }
        }
    }
}
