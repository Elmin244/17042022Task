using System;
using System.Collections.Generic;
using System.Text;

namespace _17042022Task.Models
{
    class Reservation
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int StadionID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"ID:{ID}---UserID:{UserID}---StadionID:{StadionID}---StartDate:{StartDate}---EndDate{EndDate}");
        }
    }
}
