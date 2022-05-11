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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin frmLgn = new FormLogin();
            frmLgn.Show();
            this.Close();
        }

        private void btnInputDataTas_Click(object sender, EventArgs e)
        {
            FormInputData frmInputData = new FormInputData();
            frmInputData.Show();
            this.Close();
        }

        private void btnCekDataTas_Click(object sender, EventArgs e)
        {
            FormCekData frmCekData = new FormCekData();
            frmCekData.Show();
            this.Close();
        }
    }
}
