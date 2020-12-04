using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    class classOrderDetail
    {
        private static String Date, Screen, Time;
        //private static List<int> SeatNo = new List<int>();
        private static List<String> SeatNo = new List<String>();

        public void ResetData()
        {
            Date = "";
            Screen = "";
            Time = "";
            SeatNo.Clear();
        }

        public void setDate(String date)
        {
            Date = date;
        }
        public void setScreen(String screen)
        {
            Screen = screen;
        }
        public void setTime(String time)
        {
            Time = time;
        }
        public void setSetseatNo(List<String> seatno) {
            foreach (string seat in seatno)
            {
                if (seat != null)
                {
                    //SeatNo.Add(int.Parse(seat));
                    SeatNo.Add(seat);
                }
            }
        }
        public List<String> getseatNo { get { return SeatNo; } }

        //public List<int> getseatNo { get { return SeatNo;} }
        public String getDate{ get{ return Date; } }
        public String getScreen{ get { return Screen; } }
        public String getTime { get { return Time; } }

    }
}
