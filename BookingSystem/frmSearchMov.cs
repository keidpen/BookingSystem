using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class frmSearchMov : Form
    {
        public frmSearchMov()
        {
            InitializeComponent();
        }

        private void SearchMov_Load(object sender, EventArgs e)
        {
            cbCategoryMovieInfo.SelectedIndex = 0;
            FetchMovieInfo("");
        }

        public void FetchMovieInfo(String query)
        {
            try
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();

                Database db = new Database();
                String sel = "SELECT movieID,Title,Director,Genre,Duration,Synopsis,imgPath,isDeleted FROM bookingdb.movieinfo";
                String column = "";
                if (query == "ID")
                {
                    query = sel + " WHERE movieID = '" + tbSearchMovieInfo.Text + "%'";
                    column = "movieID";
                }
                else if (query == "Title")
                {
                    query = sel + " WHERE Title LIKE '" + tbSearchMovieInfo.Text + "%'";
                    column = "Title";
                }
                else if (query == "Director")
                {
                    query = sel + " WHERE Director LIKE '" + tbSearchMovieInfo.Text + "%' ";
                    column = "Director";
                }
                else if (query == "Genre")
                {
                    query = sel + " WHERE Genre Like '%" + tbSearchMovieInfo.Text + "%'";
                    column = "Genre";
                }
                else
                {
                    query = "SELECT movieID,Title,Director,Genre,Duration,Synopsis,imgPath,isDeleted FROM bookingdb.movieinfo";
                    if (cbCategoryMovieInfo.Text == "ID")
                    {
                        column = "movieID";
                    }
                    else
                    {
                        column = cbCategoryMovieInfo.Text;
                    }

                }
                db.conn.Open();

                ArrayList AL = new ArrayList();

                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataAdapter ad = new MySqlDataAdapter(command);


                DataTable dt = new DataTable();

                dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
                ad.Fill(dt);

                foreach (DataRow drow in dt.Rows)
                {
                    Image img = new Bitmap(Image.FromFile(drow["imgPath"].ToString()), new Size(210, 150));
                    drow["Image"] = imageToByteArray(img);
                    if (drow["isDeleted"].ToString() == "true")
                    {
                        drow["isDeleted"] = "Deleted";
                    }
                    else
                    {
                        drow["isDeleted"] = "Available";
                    }
                }

                AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
                foreach (DataRow drow in dt.Rows)
                {
                    autotext.Add(drow[column].ToString());
                }
                tbSearchMovieInfo.AutoCompleteCustomSource = autotext;
                command.Dispose();


                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = "Image";
                dataGridView2.Columns[1].HeaderText = "ID";
                dataGridView2.Columns[8].HeaderText = "Status";
                dataGridView2.Columns[7].Visible = false;

                dataGridView2.RowTemplate.Height = 150;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                db.conn.Close();

                if (dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show("No Result Found.");
                    FetchMovieInfo("");
                    tbSearchMovieInfo.Text = "";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Fetch" + err.Message);
            }
        }



        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }


        private void btnSearchMovieInfo_Click(object sender, EventArgs e)
        {

        }


        private void cbCategoryMovieInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoryMovieInfo.SelectedIndex > 0)
            {
                btnSearchMovieInfo_Click(sender, e);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchMovieInfo_Click_1(object sender, EventArgs e)
        {
            if (cbCategoryMovieInfo.SelectedItem.ToString() == "ID")
            {
                FetchMovieInfo("ID");
            }
            else if (cbCategoryMovieInfo.SelectedItem.ToString() == "Title")
            {
                FetchMovieInfo("Title");
            }
            else if (cbCategoryMovieInfo.SelectedItem.ToString() == "Director")
            {
                FetchMovieInfo("Director");
            }
            else if (cbCategoryMovieInfo.SelectedItem.ToString() == "Genre")
            {
                FetchMovieInfo("Genre");
            }
            else
            {
                FetchMovieInfo("");
            }
        }
    }
}
