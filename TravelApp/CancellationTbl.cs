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
    public partial class CancellationTbl : Form
    {
        public CancellationTbl()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\Documents\ArlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillTicketId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TId  from TicketTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TId", typeof(string));
            dt.Load(rdr);
            TidCb.ValueMember = "TId";
            TidCb.DataSource = dt;
            Con.Close();
        }
        private void fetchfcode()
        {
            Con.Open();
            string query = "select * from TicketTbl where TId = " + TidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FcodeTb.Text = dr["Fcode"].ToString();
            }
            Con.Close();
        }
        private void CancellationTbl_Load(object sender, EventArgs e)
        {
            fillTicketId();
            populate();
        }

        private void TidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchfcode();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CanId.Text = "";
            FcodeTb.Text = "";
        }

        private void deleteTicket()
        {
            try
            {
                Con.Open();
                string query = "delete from TicketTbl where TId = " + TidCb.SelectedValue.ToString() + ";";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (CanId.Text == "" || FcodeTb.Text == "")
            {
                MessageBox.Show("Informasi Tidak Ditemukan!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CancelTbl values(" + CanId.Text + "," + TidCb.SelectedValue.ToString() + ",'" + FcodeTb.Text + "','" + CancDate.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pembatalan Tiket Telah Diproses!");
                    Con.Close();
                    populate();
                    deleteTicket();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CancelDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
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
