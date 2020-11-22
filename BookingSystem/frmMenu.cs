﻿using System;
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

        private void lblHome_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            TestForm frm = new TestForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }

        private void lblMovie_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            frmSocialDistancing frm = new frmSocialDistancing() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlMenu.Controls.Add(frm);
            frm.Show();
        }
    }
}
