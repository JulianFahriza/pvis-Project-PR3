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
    public partial class FormInputData : Form
    {
        ArrayList _daftarTas = new System.Collections.ArrayList();
        string ID_TAS, FOTO, JENIS_TAS, MERK_TAS, HARGA_TAS, TGL_MASUK;

        connection con = new connection();

        private void comboJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private DateTimePicker GetDateTimePickerTglMasuk()
        {
            return tglInput;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {

            Image img = PictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            string connectionString = @"server=localhost;userid=root;password=;database=db_thriftmeandu";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                con.open();
                MySqlCommand cmd = new MySqlCommand(); 
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO data_tas (ID_TAS, FOTO, JENIS_TAS, MERK_TAS, HARGA_TAS, TGL_MASUK) VALUES(@ID_TAS, @img, @JENIS_TAS, @MERK_TAS, @HARGA_TAS, @TGL_MASUK)";


                cmd.Parameters.AddWithValue("@ID_TAS", txtId.Text);
                cmd.Parameters.AddWithValue("@img", arr);
                cmd.Parameters.AddWithValue("@JENIS_TAS", comboJenis.Text);
                cmd.Parameters.AddWithValue("@MERK_TAS", txtMerk.Text);
                cmd.Parameters.AddWithValue("@HARGA_TAS", txtHarga.Text);
                cmd.Parameters.AddWithValue("@TGL_MASUK", tglInput.Value.Date.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("sukseks");

            }
            finally
            {
                if (connection != null)
                    connection.Close();
                con.Close();
                FormHome frmHome = new FormHome();
                frmHome.Show();
                this.Close();
            }

        }
        public FormInputData()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHome frmHome = new FormHome();
            frmHome.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPG Files (*.jpg;*.png)| *.jpg;*.png";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.Image = Image.FromFile(fileOpen.FileName);
                PictureBox1.Image = new Bitmap(fileOpen.FileName);
                PictureBox1.ImageLocation = fileOpen.FileName;
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }
    }
}
