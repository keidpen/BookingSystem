﻿using MySql.Data.MySqlClient;
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
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void frmData_Load(object sender, EventArgs e)
        {
            //String query = "SELECT * FROM tblcostumer";
            //Database db = new Database();
            ////MySqlCommand cmd = new MySqlCommand(query, db.conn);
            ////MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            ////db.conn.Open();
            //DataSet set = new DataSet("bookingdbDataSet");
            ////sda.Fill(set);
            ////this.crystalReportViewer1.F


            //CrystalReport11.SetDataSource(sr);
            //CrystalReport1 rpt = new CrystalReport1();
            //rpt.DataSourceConnections(set);

            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();


        }

    }
}
