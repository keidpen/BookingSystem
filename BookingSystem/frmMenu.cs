using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        Timer timeClock = new Timer();
        private void frmMenu_Load(object sender, EventArgs e)
        {
            timeClock.Interval = 550;
            timeClock.Tick += new EventHandler(TimeClock);
            timeClock.Start();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            lblMovie.ForeColor = Color.Black;
            lblHome.ForeColor = Color.DarkViolet;
            lblBooking.ForeColor = Color.Black;
            lblFeatures.ForeColor = Color.Black;

            pnlMenu.Controls.Clear();
            TestForm frm = new TestForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblMovie_Click(object sender, EventArgs e)
        {
            DisableBookings();
            DisableFeatures();

            lblMovie.ForeColor = Color.DarkViolet;
            lblHome.ForeColor = Color.Black;
            lblBooking.ForeColor = Color.Black;
            lblFeatures.ForeColor = Color.Black;

            lblAddMov.ForeColor = Color.DarkViolet;
            lblUpdateMov.ForeColor = Color.Black;
            lblSearchMovie.ForeColor = Color.Black;
            lblSchedule.ForeColor = Color.Black;

            lblAddMov.Visible = true;
            lblUpdateMov.Visible = true;
            lblSearchMovie.Visible = true;
            lblSchedule.Visible = true;

            pnlMenu.Controls.Clear();
            frmAddMov frm = new frmAddMov() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();

        }


        private void lblBooking_Click(object sender, EventArgs e)
        {
            DisableMovie();
            DisableFeatures();

            lblMovie.ForeColor = Color.Black;
            lblHome.ForeColor = Color.Black;
            lblBooking.ForeColor = Color.DarkViolet;
            lblFeatures.ForeColor = Color.Black;

            lblSeats.ForeColor = Color.DarkViolet;
            lblCustomer.ForeColor = Color.Black;

            lblCustomer.Visible = true;
            lblSeats.Visible = true;
            

            pnlMenu.Controls.Clear();
            frmBooking frm = new frmBooking() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblSocialDistancing_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            frmSocialDistancing frm = new frmSocialDistancing() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            lblCustomer.ForeColor = Color.DarkViolet;
            lblSeats.ForeColor = Color.Black;

            pnlMenu.Controls.Clear();
            frmCustomer frm = new frmCustomer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblSchedule_Click(object sender, EventArgs e)
        {
            lblAddMov.ForeColor = Color.Black;
            lblUpdateMov.ForeColor = Color.Black;
            lblSearchMovie.ForeColor = Color.Black;
            lblSchedule.ForeColor = Color.DarkViolet;

            pnlMenu.Controls.Clear();
            frmSchedule frm = new frmSchedule() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblAddMov_Click(object sender, EventArgs e)
        {
            lblMovie_Click(sender,e);
        }

        private void lblUpdateMov_Click(object sender, EventArgs e)
        {
            lblAddMov.ForeColor = Color.Black;
            lblUpdateMov.ForeColor = Color.DarkViolet;
            lblSearchMovie.ForeColor = Color.Black;
            lblSchedule.ForeColor = Color.Black;

            pnlMenu.Controls.Clear();
            frmUpdateMov frm = new frmUpdateMov() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblSearchMovie_Click(object sender, EventArgs e)
        {
            lblAddMov.ForeColor = Color.Black;
            lblUpdateMov.ForeColor = Color.Black;
            lblSearchMovie.ForeColor = Color.DarkViolet;
            lblSchedule.ForeColor = Color.Black;

            pnlMenu.Controls.Clear();
            frmSearchMov frm = new frmSearchMov() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblContactTracing_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            frmContactTracing frm = new frmContactTracing() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblFeatures_Click(object sender, EventArgs e)
        {
            DisableMovie();
            DisableBookings();

            lblMovie.ForeColor = Color.Black;
            lblHome.ForeColor = Color.Black;
            lblBooking.ForeColor = Color.Black;
            lblFeatures.ForeColor = Color.DarkViolet;

            lblSocialDistancing.ForeColor = Color.DarkViolet;

            lblSocialDistancing.Visible = true;
            lblSocialDistancing_Click(sender,e);
        }

        private void DisableMovie()
        {
            lblAddMov.Visible = false;
            lblUpdateMov.Visible = false;
            lblSearchMovie.Visible = false;
            lblSchedule.Visible = false;
        }

        private void DisableBookings()
        {
            lblSeats.Visible = false;
            lblCustomer.Visible = false;
        }

        private void DisableFeatures()
        {
            lblSocialDistancing.Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log-out?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Visible = true;
                this.Visible = false;
            }
        }

        int countClock = 0;
        public void TimeClock(object sender, EventArgs e)
        {
            DateTime dtClock = DateTime.Now;
            if (countClock % 2 == 0)
            {
                lblTimeClock.Text = dtClock.ToString("MMM dd, yyyy hh:mm:ss tt");
                countClock++;
            }
            else
            {
                lblTimeClock.Text = "";
                countClock--;
            }

        }
    }
}
