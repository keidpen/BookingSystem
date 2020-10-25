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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void GetNameMovie(String id)
        {
            try
            {
                Database db = new Database();

                String query = "SELECT Title FROM movieinfo WHERE movieid = '"+ id +"'";
                db.conn.Open();
                MySqlDataAdapter adt = new MySqlDataAdapter(query,db.conn);


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        public void FetchInfo(String id,String screen, String date, String time)
        {
            GetNameMovie(id);
            lblMovieID.Text = id;
            lblScreen.Text = screen;
            lblTime.Text = time;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

        }
    }
}
