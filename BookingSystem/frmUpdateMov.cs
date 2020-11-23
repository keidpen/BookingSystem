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
    public partial class frmUpdateMov : Form
    {
        public frmUpdateMov()
        {
            InitializeComponent();
        }

        private void frmUpdateMov_Load(object sender, EventArgs e)
        {
            dbSelect();
        }

        List<string> sortList = new List<string>();


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE?", "Delete Movie?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UpdateOrDeleteMovieInfo("true");
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Update?", "Update Movie?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UpdateOrDeleteMovieInfo("false");
            }
        }


        public void dbSelect()
        {
            try
            {
                sortList.Clear();
                cbUpdTitle.Items.Clear();

                String query1 = "";
                query1 = "SELECT Title FROM movieinfo WHERE isDeleted ='false' ORDER BY movieID DESC";

                Database db = new Database();
                db.conn.Open();
                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();

                while (reader.Read())
                {
                    sortList.Add(reader[0].ToString());
                }


                reader.Close();
                command1.Dispose();
                db.conn.Close();

                foreach (String str in sortList)
                {
                    cbUpdTitle.Items.Add(str);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        ///  dito magseach ng movie
        /// </summary>

        String movieInfoID = "";
        public void dbDisplayAfterSelect()
        {
            try
            {
                Database db = new Database();
                String query1 = "SELECT * FROM movieinfo WHERE Title = '" + cbUpdTitle.Text + "'";
                db.conn.Open();
                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command1);
                DataTable table = new DataTable();

                adapter.Fill(table);
                // dito check Genre
                movieInfoID = table.Rows[0][0].ToString();
                tbUpdDirector.Text = table.Rows[0][2].ToString();
                String[] gen = { "Adventure", "Action", "Drama", "Documentary", "Comedy", "Fantasy", "Horror", "Romance", "Sci-Fi", "Sports", "Thriller" };
                for (int i = 0; i < gen.Length; i++)
                {
                    if (table.Rows[0][3].ToString().Contains(gen[i].ToString()))
                    {
                        cbUpdGenre.SetItemCheckState(i, (true ? CheckState.Checked : CheckState.Unchecked));
                    }
                }
                tbUpdDuration.Text = table.Rows[0][4].ToString();
                tbUpdSynopsis.Text = table.Rows[0][5].ToString();
                tbUpdPrice.Text = table.Rows[0][6].ToString();
                var imgs = table.Rows[0][8].ToString();

                picBoxUpdate.Image = Image.FromFile(imgs);
                String replace = imgs.Replace("\\", "\\\\");
                imgUpdate = replace;

                adapter.Dispose();
                db.conn.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "Wlalang lumabas");
            }
        }


        //set


        //////////update or remove

        public void UpdateOrDeleteMovieInfo(String isDeleted)
        {
            String genre = "", check = "";
            foreach (string s in cbUpdGenre.CheckedItems)
            {
                genre += s + ", ";
                check += s;
            }

            if (imgUpdate == null || (check.Equals("") && isDeleted.Equals("false")) || cbUpdTitle.Text.Equals(null) || tbUpdDirector.Text.Equals(null) || tbUpdDuration.Text.Equals(null) || tbUpdSynopsis.Text.Equals(null) || tbUpdPrice.Text.Equals(null))
            {
                MessageBox.Show("Everything is not fill");
            }
            else
            {
                try
                {
                    Database db = new Database();

                    String query1 = "";

                    if (isDeleted.Equals("false"))
                    {
                        query1 = "UPDATE bookingdb.movieinfo " +
                                 "SET Title ='" + cbUpdTitle.Text + "',Director ='" + tbUpdDirector.Text + "' , Genre= '" + genre + "'  , Duration = '" + tbUpdDuration.Text + "' , Synopsis = '" + tbUpdSynopsis.Text + "' , Price = '" + tbUpdPrice.Text + "' , isDeleted = 'false' , imgPath = '" + imgUpdate + "' " +
                                 "WHERE movieID = '" + movieInfoID + "'";
                    }
                    else if (isDeleted.Equals("true"))
                    {
                        query1 = "UPDATE bookingdb.movieinfo " +
                                 "SET isDeleted = 'true'" +
                                 "WHERE movieID = '" + movieInfoID + "'";
                    }

                    db.conn.Open();
                    MySqlCommand command = new MySqlCommand(query1, db.conn);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        if (isDeleted.Equals("false"))
                        {
                            MessageBox.Show("Movie info updated");
                        }
                        else if (isDeleted.Equals("true"))
                        {
                            MessageBox.Show("Movie info is Deleted");
                        }

                        movieInfoID = "";
                        cbUpdTitle.Text = "";
                        tbUpdDirector.Text = "";
                        tbUpdDuration.Text = "";
                        tbUpdSynopsis.Text = "";
                        tbUpdPrice.Text = "";
                        imgUpdate = "";
                        picBoxUpdate.Image = null;
                        for (int i = 0; i < cbUpdGenre.Items.Count; i++)
                        {
                            cbUpdGenre.SetItemCheckState(i, (false ? CheckState.Checked : CheckState.Unchecked));
                        }
                        dbSelect();

                    }
                    else
                    {
                        MessageBox.Show("Movie info update failed");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        //


        ////////// DB END

        String imgUpdate = "";

        private void btnUpdSelectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *png)|*.jpg; *png";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picBoxUpdate.Image = Image.FromFile(opf.FileName);
                String replace = opf.FileName;
                imgUpdate = replace.Replace("\\", "\\\\");
            }
        }

        private void btnSearchIdMov_Click(object sender, EventArgs e)
        {
            dbDisplayAfterSelect();
        }

        private void tbUpdDirector_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
