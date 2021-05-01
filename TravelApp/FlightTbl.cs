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
    public partial class FlightTbl : Form
    {
        public FlightTbl()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\Documents\ArlineDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void FlightTbl_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || Fsrc.Text == "" || FDest.Text == "" || FDate.Text == "" || SeatNum.Text == "")
            {
                MessageBox.Show("Informasi Tidak Ditemukan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FlightTbl values('" + FcodeTb.Text + "','" + Fsrc.SelectedItem.ToString() + "','" + FDest.SelectedItem.ToString() + "','" + FDate.Value.ToString() + "','" + SeatNum.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Penerbangan Berhasil di Tambahkan");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            Fsrc.SelectedItem = " ";
            FDest.SelectedItem = " ";
            SeatNum.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewFlights viewflt = new ViewFlights();
            viewflt.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
