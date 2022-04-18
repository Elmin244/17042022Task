using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using _17042022Task.Models;

namespace _17042022Task.Data
{
    class SelectStadion
    {
        public static void AllStadions()
        {
            string connectionstring = @"Server=DESKTOP-LJN6KSR\SQLEXPRESS;Database=Football;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query1 = $"Select *From Stadion";
                using (SqlCommand cmd1 = new SqlCommand(query1, con))
                {
                    SqlDataReader dataReader = cmd1.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = dataReader.GetInt32(0);
                        string name = dataReader.GetString(1);
                        int hourPrice = dataReader.GetInt32(2);
                        int capacity = dataReader.GetInt32(3);
                        Stadion stadion = new Stadion()
                        {
                            ID = id,
                            Name = name,
                            HourPrice = hourPrice,
                            Capacity = capacity

                        };
                        stadion.ShowInfo();

                    }
                    dataReader.Close();
                }


                //string name = Console.ReadLine();
                //string hourprice = Console.ReadLine();
                //string capacity = Console.ReadLine();
                //con.Open();

                //string query = $"Insert Into Stadion(Name,HourPrice,Capacity)Values('{name}',{hourprice},{capacity})";
                //SqlCommand cmd = new SqlCommand(query, con);
                //cmd.ExecuteNonQuery();
                //con.Close();
            }


        }
    }
}
