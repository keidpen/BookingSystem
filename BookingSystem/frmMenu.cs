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
            //timeClock.Interval = 550;
            //timeClock.Tick += new EventHandler(TimeClock);
            //timeClock.Start();
        }

        Color col = Color.WhiteSmoke;
        Color colBlack = Color.Black;

        private void lblHome_Click(object sender, EventArgs e)
        {
            DisableBookings();
            DisableFeatures();
            DisableReport();

            lblMovie.ForeColor = col;
            lblHome.ForeColor = Color.DarkViolet;
            lblBooking.ForeColor = col;
            lblFeatures.ForeColor = col;
            lblReport.ForeColor = col;

            TabSel1.Visible = true;
            TabSel2.Visible = false;
            TabSel3.Visible = false;
            TabSel4.Visible = false;
            TabSel5.Visible = false;


            pnlMenu.Controls.Clear();
            frmHome frm = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblMovie_Click(object sender, EventArgs e)
        {
            DisableBookings();
            DisableFeatures();
            DisableReport();

            lblMovie.ForeColor = Color.DarkViolet;
            lblHome.ForeColor = col;
            lblBooking.ForeColor = col;
            lblFeatures.ForeColor = col;
            lblReport.ForeColor = col;

            lblAddMov.ForeColor = Color.DarkViolet;
            lblUpdateMov.ForeColor = colBlack;
            lblSearchMovie.ForeColor = colBlack;
            lblSchedule.ForeColor = colBlack;

            lblAddMov.Visible = true;
            lblUpdateMov.Visible = true;
            lblSearchMovie.Visible = true;
            lblSchedule.Visible = true;

            TabSel1.Visible = false;
            TabSel2.Visible = true;
            TabSel3.Visible = false;
            TabSel4.Visible = false;
            TabSel5.Visible = false;

            pnlMenu.Controls.Clear();
            frmAddMov frm = new frmAddMov() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();

        }


        private void lblBooking_Click(object sender, EventArgs e)
        {
            DisableMovie();
            DisableFeatures();
            DisableReport();

            TabSel1.Visible = false;
            TabSel2.Visible = false;
            TabSel3.Visible = true;
            TabSel4.Visible = false;
            TabSel5.Visible = false;

            lblMovie.ForeColor = col;
            lblHome.ForeColor = col;
            lblBooking.ForeColor = Color.DarkViolet;
            lblFeatures.ForeColor = col;
            lblReport.ForeColor = col;

            lblSeats.ForeColor = Color.DarkViolet;
            lblCustomer.ForeColor = colBlack;

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
            lblSeats.ForeColor = colBlack;

            pnlMenu.Controls.Clear();
            frmCustomer frm = new frmCustomer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblSchedule_Click(object sender, EventArgs e)
        {
            lblAddMov.ForeColor = colBlack;
            lblUpdateMov.ForeColor = colBlack;
            lblSearchMovie.ForeColor = colBlack;
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
            lblAddMov.ForeColor = colBlack;
            lblUpdateMov.ForeColor = Color.DarkViolet;
            lblSearchMovie.ForeColor = colBlack;
            lblSchedule.ForeColor = colBlack;

            pnlMenu.Controls.Clear();
            frmUpdateMov frm = new frmUpdateMov() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblSearchMovie_Click(object sender, EventArgs e)
        {
            lblAddMov.ForeColor = colBlack;
            lblUpdateMov.ForeColor = colBlack;
            lblSearchMovie.ForeColor = Color.DarkViolet;
            lblSchedule.ForeColor = colBlack;

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
            DisableReport();

            TabSel1.Visible = false;
            TabSel2.Visible = false;
            TabSel3.Visible = false;
            TabSel4.Visible = true;
            TabSel5.Visible = false;

            lblMovie.ForeColor = col;
            lblHome.ForeColor = col;
            lblBooking.ForeColor = col;
            lblFeatures.ForeColor = Color.DarkViolet;
            lblReport.ForeColor = col;

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

        private void DisableReport()
        {
            lblContactTracing.Visible = false;
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Want to Exit the Program?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblReport_Click(object sender, EventArgs e)
        {
            DisableBookings();
            DisableFeatures();
            DisableMovie();

            lblContactTracing.Visible = true;

            lblMovie.ForeColor = col;
            lblHome.ForeColor = col;
            lblBooking.ForeColor = col;
            lblFeatures.ForeColor = col;
            lblReport.ForeColor = Color.DarkViolet;

            TabSel1.Visible = false;
            TabSel2.Visible = false;
            TabSel3.Visible = false;
            TabSel4.Visible = false;
            TabSel5.Visible = true;

            lblContactTracing.ForeColor = Color.DarkViolet;

            lblContactTracing_Click(sender,e);
        }
    }
}
