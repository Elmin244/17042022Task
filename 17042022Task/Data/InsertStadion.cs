using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _17042022Task.Data
{
    class InsertStadion
    {
        public static void AllStadion()
        {
            string connectionstring = @"Server=DESKTOP-LJN6KSR\SQLEXPRESS;Database=Football;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query1 = $"Insert INTO *From Stadion";
                using (SqlCommand cmd1 = new SqlCommand(query1, con))
                {

                    string name = Console.ReadLine();
                    string hourprice = Console.ReadLine();
                    string capacity = Console.ReadLine();
                    con.Open();

                    string query = $"Insert Into Stadion(Name,HourPrice,Capacity)Values('{name}',{hourprice},{capacity})";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
