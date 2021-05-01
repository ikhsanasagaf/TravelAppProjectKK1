using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelApp
{
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\Documents\ArlineDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddPassenger addpas = new AddPassenger();
            addpas.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(PidTb.Text == "")
            {
                MessageBox.Show("Mohon Masukkan Data Penumpang Terlebih Dahulu!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PassengerTbl where PassId = " + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Menghapus Data Penumpang");
                    Con.Close();
                    populate();
                }
                
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PidTb.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
            PnameTb.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PpassTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PaddTb.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
            natcb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
            GendCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();
            PphoneTb.Text = PassengerDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PidTb.Text = "";
            PnameTb.Text = "";
            PpassTb.Text = "";
            PaddTb.Text = "";
            natcb.SelectedItem = " ";
            GendCb.SelectedItem = " ";
            PphoneTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PidTb.Text == "" || PnameTb.Text == "" || PpassTb.Text == "" || PaddTb.Text == "" || PphoneTb.Text == "")
            {
                MessageBox.Show("Mohon Masukkan Data Penupang Terlebih Dahulu!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PassengerTbl set PassName='" + PnameTb.Text + "', Passport='" + PpassTb.Text + "', PassAd='" + PaddTb.Text + "', PassNat='" + natcb.SelectedItem.ToString() + "', PassGend='" + GendCb.SelectedItem.ToString() + "', PassPhone='" + PphoneTb.Text + "' where PassId=" + PidTb.Text + "; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Penumpang Berhasil Di Ubah");
                    Con.Close();
                    populate();
                }

                catch(Exception)
                {
                    MessageBox.Show("Informasi Tidak Ditemukan!");
                }
            }
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
