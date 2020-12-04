using MySql.Data.MySqlClient;
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
    public partial class TestForm2 : Form
    {
        public TestForm2()
        {
            InitializeComponent();
        }

        private void TestForm2_Load(object sender, EventArgs e)
        {
            test();
        }
        private void test()
        {
            try
            {
                String query = "SELECT YEAR(Date) AS Year, MONTH(Date) AS Month, SUM(Ammount) AS 'Total Ammount' " +
                    "FROM tbltransaction " +
                    "WHERE YEAR(Date) = '2020' " +
                    "GROUP BY MONTH(Date)";

                Database db = new Database();
                db.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query,db.conn);
                DataTable tb = new DataTable();
                da.Fill(tb);


                db.conn.Close();

                DataSet ds = new DataSet();
                ds.Tables.Add(tb);
                ds.WriteXmlSchema("MonthSummarySales.xml");

                //dataGridView1.DataSource = tb;
                //dataGridView1.Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT DATE_FORMAT(Date, '%Y') AS Year,DATE_FORMAT(Date, '%m. %b') AS Month, SUM(Ammount) AS 'Total Ammount' " +
                    "FROM tbltransaction " +
                    "WHERE YEAR(Date) = '2020' " +
                    "GROUP BY MONTH(Date)";

            Database db = new Database();
            db.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, db.conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            db.conn.Close();

            DataSet ds = new DataSet();
            ds.Tables.Add(tb);
            ds.WriteXmlSchema("MonthSummarySales.xml");

            reportMonthSales ms = new reportMonthSales();
            ms.SetDataSource(ds);

            FormViewerTesting frm = new FormViewerTesting();
            frm.crystalReportViewer1.ReportSource = ms;
            frm.Show();
        }
    }
}
