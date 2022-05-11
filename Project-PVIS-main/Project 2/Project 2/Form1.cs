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

namespace Project_2
{
    public partial class FormLogin : Form
    {
        connection con = new connection();
        string ID_USER, NAMA_USER, PW;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {

                    con.open();
                    string query = "select ID_USER,NAMA_USER,PW from data_user WHERE ID_USER ='" + txtUsername.Text + "' AND PW ='" + txtPassword.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            ID_USER = row["ID_USER"].ToString();
                            NAMA_USER = row["NAMA_USER"].ToString();
                            PW = row["PW"].ToString();
                        }
                        FormHome frmHome = new FormHome();
                        frmHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }



        }
    }
}
