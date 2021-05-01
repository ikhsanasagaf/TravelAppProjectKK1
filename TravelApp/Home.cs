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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Ticket tiket = new Ticket();
            tiket.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            CancellationTbl cancel = new CancellationTbl();
            cancel.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FlightTbl flight = new FlightTbl();
            flight.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AddPassenger pass = new AddPassenger();
            pass.Show();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
