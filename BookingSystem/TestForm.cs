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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            test();
            test2();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }



        public void test2()
        {
            try
            {
                listView1.Items.Clear();
                Database db = new Database();
                String query1 = "SELECT DATE_FORMAT(Date,'%Y-%m-%d') FROM tblsocialdistancing WHERE sdmode ='true'";
                db.conn.Open();
                ArrayList AL = new ArrayList();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    Label l = new Label();
                    String dext = reader[0].ToString();
                    listView1.Items.Add(dext);
                }

            }catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void test3(String date)
        {
            try
            {
                Database db = new Database();
                String query1 = "INSERT INTO bookingdb.tblsocialdistancing(sdmode,Date) VALUES('true','"+date+"')";
                db.conn.Open();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                if (command1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Success");
                    test2();
                    listView1.Refresh();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
         }

        public void test()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "ORNo.";
                dataGridView1.Columns[1].Name = "Name";
                dataGridView1.Columns[2].Name = "Seat No.";
                dataGridView1.Columns[3].Name = "Date";
                dataGridView1.Columns[4].Name = "Time";
                dataGridView1.Columns[5].Name = "Screen";

                Database db = new Database();
                String query1 = "SELECT * FROM bookedseats";

                db.conn.Open();
                ArrayList AL = new ArrayList();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    AL = new ArrayList();
                    AL.Add(reader[0].ToString());
                    AL.Add(reader[1].ToString());
                    AL.Add(reader[2].ToString().Trim());
                    AL.Add(reader[3].ToString());
                    AL.Add(reader[4].ToString());
                    AL.Add(reader[5].ToString());
                   // AL.Add(reader[6].ToString());
                   // AL.Add(reader[7].ToString());
                    dataGridView1.Rows.Add(AL.ToArray());
                }
                reader.Close();
                command1.Dispose();

                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                db.conn.Close();


                if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows == null)
                {
                    MessageBox.Show("No Result Found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("Helo "+monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
            test3(monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
