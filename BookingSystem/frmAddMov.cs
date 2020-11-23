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
    public partial class frmAddMov : Form
    {
        public frmAddMov()
        {
            InitializeComponent();
        }

        private void frmAddMov_Load(object sender, EventArgs e)
        {

        }

        String img = "";
        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *png)|*.jpg; *png";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picBoxMovie.Image = Image.FromFile(opf.FileName);
                String replace = opf.FileName;
                img = replace.Replace("\\", "\\\\");
            }

        }


        private void btnAddMovie_Click(object sender, EventArgs e)
        {

            String genre = "", check = "";
            foreach (string s in cbGenre.CheckedItems)
            {
                genre += s + ", ";
                check += s;
            }


            if (img == null || check.Equals("") || tbTitle.Text.Equals(null) || tbDirector.Text.Equals(null) || tbDuration.Text.Equals(null) || tbSynopsis.Text.Equals(null) || tbPrice.Text.Equals(null))
            {
                MessageBox.Show("Everything is empty");
            }
            else
            {

                try
                {
                    Database db = new Database();
                    String query1 = "INSERT INTO bookingdb.movieinfo(Title,Director,Genre,Duration,Synopsis,Price,isDeleted,imgPath) " +
                                    "VALUES('" + tbTitle.Text + "' , '" + tbDirector.Text + "' , '" + genre + "'  , '" + tbDuration.Text + "' , '" + tbSynopsis.Text + "' ,'" + tbPrice.Text + "' , '" + "false" + "' , '" + img + "')";
                    db.conn.Open();

                    MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Added new Movie");
                        tbTitle.Text = "";
                        tbDirector.Text = "";
                        tbSynopsis.Text = "";
                        tbDuration.Text = "";
                        tbPrice.Text = "";
                        img = "";
                        picBoxMovie.Image = null;
                        for (int i = 0; i < cbGenre.Items.Count; i++)
                        {
                            cbGenre.SetItemCheckState(i, (false ? CheckState.Checked : CheckState.Unchecked));
                        }
                    }
                    command1.Dispose();
                    db.conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

    }
}
