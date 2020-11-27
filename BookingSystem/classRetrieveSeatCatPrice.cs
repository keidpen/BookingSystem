using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    class classRetrieveSeatCatPrice
    {

        public classRetrieveSeatCatPrice()
        {
            Database db = new Database();
            db.conn.Open();
            String query = "SELECT * FROM tblseatcategory";
            MySqlCommand cmd = new MySqlCommand(query,db.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                if (reader[1].ToString() == "A")
                    CatSeat_A = double.Parse(reader[2].ToString());
                else if (reader[1].ToString() == "B")
                    CatSeat_B = double.Parse(reader[2].ToString());
                else if (reader[1].ToString() == "C")
                    CatSeat_C = double.Parse(reader[2].ToString());
                else if (reader[1].ToString() == "D")
                    CatSeat_D = double.Parse(reader[2].ToString());
                else if (reader[1].ToString() == "E")
                    CatSeat_E = double.Parse(reader[2].ToString());
                else if (reader[1].ToString() == "F")
                    CatSeat_F = double.Parse(reader[2].ToString());
                else if (reader[1].ToString() == "G")
                    CatSeat_G = double.Parse(reader[2].ToString());
            }
            cmd.Dispose();
            db.conn.Close();

        }

   
        public double CatSeat_A{ get; set; }
        public double CatSeat_B { get; set; }
        public double CatSeat_C { get; set; }
        public double CatSeat_D { get; set; }
        public double CatSeat_E { get; set; }
        public double CatSeat_F { get; set; }
        public double CatSeat_G { get; set; }


    }
}
