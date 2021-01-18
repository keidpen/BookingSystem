using LiveCharts;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadChart();
            CountCancel();
            CountBooking();
            target();
        }


        private void target()
        {
            solidGauge1.From = 0;
            solidGauge1.To = 15000;

            try
            {
                String dateNow = DateTime.UtcNow.ToString("yyyy-MM-dd");

                Database db = new Database();
                db.conn.Open();
                String query = "SELECT SUM(Ammount) FROM tbltransaction WHERE Date = '" + dateNow + "' GROUP BY 'Ammount'";
                MySqlCommand cmd = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    solidGauge1.Value = int.Parse(reader[0].ToString());
                }


                cmd.Dispose();
                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }


        private void CountCancel()
        {
            try
            {
                String dateNow = DateTime.UtcNow.ToString("yyyy-MM-dd");

                Database db = new Database();
                db.conn.Open();
                String query = "SELECT COUNT(Status) FROM tblseatno WHERE Status ='canceled' AND Date = '"+dateNow+"'";
                MySqlCommand cmd = new MySqlCommand(query,db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblCancel.Text = reader[0].ToString();
                }


                cmd.Dispose();
                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }


        public void CountBooking()
        {
            try
            {
                String dateNow = DateTime.UtcNow.ToString("yyyy-MM-dd");

                Database db = new Database();
                db.conn.Open();
                String query = "SELECT COUNT(Status) FROM tblseatno WHERE Status ='occupied' AND Date = '" + dateNow + "'";
                MySqlCommand cmd = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblbookings.Text = reader[0].ToString();
                    lblAvail.Text =( 924 - int.Parse(reader[0].ToString()) + "");
                }


                cmd.Dispose();
                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }






        List<lvSalesReport> list = new List<lvSalesReport>();
        public void LoadChart()
        {
            lvSalesReportBindingSource.DataSource = list;
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

            ///////////////////
            try
            {

                Database db = new Database();
                String query1 = "SELECT Date,YEAR(Date) AS Year, MONTH(Date) AS Month, SUM(Ammount) AS 'Total Ammount' FROM tbltransaction GROUP BY DATE_FORMAT(Date, '%m.%Y') ORDER BY Date DESC";

                db.conn.Open();
                ArrayList AL = new ArrayList();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(command1);

                DataTable tb = new DataTable();
                da.Fill(tb);

                DataTable dtCloned = tb.Clone();
                dtCloned.Columns[0].DataType = typeof(string);
                dtCloned.Columns[1].DataType = typeof(Int32);
                dtCloned.Columns[2].DataType = typeof(Int32);
                dtCloned.Columns[3].DataType = typeof(Int32);



                foreach (DataRow row in tb.Rows)
                {
                    dtCloned.ImportRow(row);
                }
                dtCloned.Columns[1].ColumnName = "Year";
                dtCloned.Columns[2].ColumnName = "Month";
                dtCloned.Columns[3].ColumnName = "Ammount";

                list.Clear();
                for (int i = 0; i < dtCloned.Rows.Count; i++)
                {
                    lvSalesReport sales = new lvSalesReport();
                    sales.Date = dtCloned.Rows[i][0].ToString();
                    sales.Year = int.Parse(dtCloned.Rows[i][1].ToString());
                    sales.Month = int.Parse(dtCloned.Rows[i][2].ToString());
                    sales.Ammount = int.Parse(dtCloned.Rows[i][3].ToString());
                    list.Add(sales);
                }

                command1.Dispose();
                db.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //////////////////////////////////

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in lvSalesReportBindingSource.DataSource as List<lvSalesReport>
                         select new { Year = o.Year }).Distinct();
            foreach (var year in years)
            {
                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in lvSalesReportBindingSource.DataSource as List<lvSalesReport>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Ammount, o.Month };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().Ammount;
                    values.Add(value);
                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChart1.Series = series;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCancel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
