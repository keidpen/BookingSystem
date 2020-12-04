using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BookingSystem
{
    class Database
    {
        public MySqlConnection conn;
        public Database()
        {
             conn = new MySqlConnection("server = localhost; user id = root; database = bookingdb;convert zero datetime=True");
        }

        public void Backup()
        {
            try
            {
                string constring = "server=localhost;user=root;database=bookingdb;pooling = false;convert zero datetime=True";
                string file = "C:\\backupBookingSql.sql";
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void Restore()
        {
            string constring = "server=localhost;user=root;database=bookingdb;";
            string file = "C:\\backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                    }
                }
            }
        }

    }
}
