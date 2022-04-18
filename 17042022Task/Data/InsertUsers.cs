using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _17042022Task.Data
{
    class InsertUsers
    {
        public static void AllUsers()
        {
            string connectionstring = @"Server=DESKTOP-LJN6KSR\SQLEXPRESS;Database=Football;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query1 = $"Insert INTO *From Users";
                using (SqlCommand cmd1 = new SqlCommand(query1, con))
                {

                    string fullname = Console.ReadLine();
                    string email = Console.ReadLine();
                    con.Open();
                    string query2 = $"Insert Into Users(FullName,Email,)Values('{fullname}',{email})";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.ExecuteNonQuery();
                    
                }
            }
        }
    }
}
