using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Harap Masukkan Username dan Password!");
            }
            else if(UidTb.Text == "Admin" && PassTb.Text == "Admin")
            {
                Home hom = new Home();
                hom.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah!");
            }
        }
    }
}
