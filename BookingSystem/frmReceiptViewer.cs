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
    public partial class frmReceiptViewer : Form
    {
        private String p;

        public frmReceiptViewer()
        {
            InitializeComponent();
        }

        public frmReceiptViewer(String p)
        {
            this.p = p;
            InitializeComponent();
        }

        private void frmReceiptViewer_Load(object sender, EventArgs e)
        {
            classOrderDetail od = new classOrderDetail();
            classTransaction t = new classTransaction();

            GenerateReceipt ob = new GenerateReceipt();
            ob.SetParameterValue("orno",t.getORNO);
            ob.SetParameterValue("Name", t.getName);
            ob.SetParameterValue("date" , od.getDate);
            ob.SetParameterValue("time", od.getTime );
            ob.SetParameterValue("screen", od.getScreen );
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();

        }

        private void frmReceiptViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            classOrderDetail c = new classOrderDetail();
            c.ResetData();

            classTransaction t = new classTransaction();
            c.ResetData();

            Refresh r = new Refresh();
            r.GetRefreshFrame(0);

        }
    }
}
