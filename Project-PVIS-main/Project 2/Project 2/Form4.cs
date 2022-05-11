using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Project_2
{
    public partial class FormCekData : Form
    {
        connection con = new connection();
        string ID_TAS, foto_tas, MERK_TAS, JENIS_TAS;
        int HARGA_TAS;
        DateTime TGL_MASUK;

        //arraylist to getter and setter data  
        private static ArrayList ListID = new ArrayList();
        private static ArrayList ListFoto = new ArrayList();
        private static ArrayList ListJenis = new ArrayList();
        private static ArrayList ListMerk = new ArrayList();
        private static ArrayList ListHarga = new ArrayList();
        private static ArrayList ListTanggal = new ArrayList();
        public FormCekData()
        {
            InitializeComponent();
            GetData();
            if (ListID.Count > 0)
            {
                updateDatagrid();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHome frmHome = new FormHome();
            frmHome.Show();
            this.Close();
        }

        private void FormCekData_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
  
        }

        private void updateDatagrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < ListID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                dataGridView1.ColumnCount = 6;
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = ListID[i];
                newRow.Cells[1].Value = ListFoto[i];
                newRow.Cells[2].Value = ListJenis[i];
                newRow.Cells[3].Value = ListMerk[i];
                newRow.Cells[4].Value = ListHarga[i];
                newRow.Cells[5].Value = ListTanggal[i];
                dataGridView1.Rows.Add(newRow);
            }
        }

         public Image ConvertByteArrayToImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }

        private void GetData()
        {
            try
            {
                con.open();
                string query = "SELECT ID_TAS, FOTO, JENIS_TAS, MERK_TAS, HARGA_TAS, TGL_MASUK FROM data_tas";

                //MySqlDataReader row;  
                MySqlDataReader row;
                row = con.ExecuteReader(query);

                if (row.HasRows)
                {
                    while (row.Read())
                    {


                        ListID.Add(row["ID_TAS"].ToString());
                        ListFoto.Add(row["FOTO"].ToString());
                        ListJenis.Add(row["JENIS_TAS"].ToString());
                        ListMerk.Add(row["MERK_TAS"].ToString());
                        ListHarga.Add(row["HARGA_TAS"].ToString());
                        ListTanggal.Add(row["TGL_MASUK"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds, "data_tas");
            dataGridView1.DataSource = ds.Tables["data_tas"].DefaultView;
            con.Close();
        }
    }
}
