using System;
using System.Collections.Generic;
using System.Text;

namespace _17042022Task.Models
{
    class Users
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"ID:{ID}---FullName:{FullName}---Email:{Email}");
        }
    }
}
