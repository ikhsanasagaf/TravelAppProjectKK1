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

namespace TravelApp
{
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\Documents\ArlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (PassId.Text == "" || PassAd.Text == "" || PassName.Text == "" || PassportTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Informasi Tidak Ditemukan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PassengerTbl values(" + PassId.Text + ",'" + PassName.Text + "','" + PassportTb.Text + "','" + PassAd.Text + "','" + NationalityCb.SelectedItem.ToString() + "','" + GenderCb.SelectedItem.ToString() + "','" + PhoneTb.Text + "')";     
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Penumpang Berhasil di Tambahkan");
                    Con.Close();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewPassenger viewpass = new ViewPassenger();
            viewpass.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            PassId.Text = "";
            PassName.Text = "";
            PassportTb.Text = "";
            PassAd.Text = "";
            NationalityCb.SelectedItem = " ";
            GenderCb.SelectedItem = " ";
            PhoneTb.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
