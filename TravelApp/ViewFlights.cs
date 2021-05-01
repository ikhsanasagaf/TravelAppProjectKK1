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
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\Documents\ArlineDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FlightTbl Addfl = new FlightTbl();
            Addfl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            DstCb.SelectedItem = " ";
            SrcCb.SelectedItem = " ";
            Seatnum.Text = "";
        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FcodeTb.Text = FlightDGV.SelectedRows[0].Cells[0].Value.ToString();
            SrcCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[1].Value.ToString();
            DstCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[2].Value.ToString();
            Seatnum.Text = FlightDGV.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "")
            {
                MessageBox.Show("Mohon Masukkan Data Penerbangan Terlebih Dahulu!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from FlightTbl where Fcode = '" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Menghapus Data Penerbangan");
                    Con.Close();
                    populate();
                }
                    
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || Seatnum.Text == "")
            {
                MessageBox.Show("Mohon Masukkan Data Penerbangan Terlebih Dahulu!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update FlightTbl set Fsrc='" + SrcCb.SelectedItem.ToString() + "', FDest='" + DstCb.SelectedItem.ToString() + "', FDate ='" + FDate.Value.ToString() + "', FCap='" + Seatnum.Text + "' where Fcode='" + FcodeTb.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Penerbangan Berhasil Di Ubah");
                    Con.Close();
                    populate();
                }

                catch (Exception)
                {
                    MessageBox.Show("Informasi Tidak Ditemukan!");
                }
            }
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
