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

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            TestForm frm = new TestForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblMovie_Click(object sender, EventArgs e)
        {

        }


        private void lblBooking_Click(object sender, EventArgs e)
        {
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
            pnlMenu.Controls.Clear();
            frmCustomer frm = new frmCustomer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblSchedule_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            frmSchedule frm = new frmSchedule() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblAddMov_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            frmAddMov frm = new frmAddMov() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblUpdateMov_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            frmUpdateMov frm = new frmUpdateMov() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblSearchMovie_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            frmSearchMov frm = new frmSearchMov() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }
    }
}
