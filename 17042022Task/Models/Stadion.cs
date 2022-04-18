using System;
using System.Collections.Generic;
using System.Text;

namespace _17042022Task.Models
{
    class Stadion
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int HourPrice { get; set; }
        public int Capacity { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"ID:{ID}---Name:{Name}---HourPrice:{HourPrice}---Capacity:{Capacity}");
        }
    }
}
