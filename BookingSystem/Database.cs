using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookingSystem
{
    class Database
    {
        public MySqlConnection conn;
        public Database()
        {
             conn = new MySqlConnection("server = localhost; user id = root; database = bookingdb");

        }

    }
}//Bobo mo noli
