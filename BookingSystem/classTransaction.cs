using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    class classTransaction
    {
        private static double TotalAmmount = 0;
        private static String ORNO = "", Date="";


        public classTransaction()
        {

        }

        public void ResetData()
        {
            TotalAmmount = 0;
            ORNO = "";
            Date = "";
        }

        public void setTotalAmmount(double totalAmmount )
        {
            TotalAmmount = totalAmmount;
        }

        public void setORNO(String ORno)
        {
            ORNO = ORno;
        }

        public void setDate(String date)
        {
            Date = date;
        }

        public double getTotalAmmount { get { return TotalAmmount; } }
        public String getORNO { get { return ORNO; } }
        public String getDate { get { return Date; } }

    }
}
