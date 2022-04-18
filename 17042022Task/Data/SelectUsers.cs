using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using _17042022Task.Models;

namespace _17042022Task.Data
{
    class SelectUsers
    {

        public static void AllUsers()
        {
            string connectionstring = @"Server=DESKTOP-LJN6KSR\SQLEXPRESS;Database=Football;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query1 = $"Select *From Users";
                using (SqlCommand cmd1 = new SqlCommand(query1, con))
                {
                    SqlDataReader dataReader = cmd1.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = dataReader.GetInt32(0);
                        string fullname = dataReader.GetString(1);
                        string email = dataReader.GetString(2);
                        
                        Users users = new Users()
                        {
                            ID = id,
                            FullName = fullname,
                            Email = email,
                            

                        };
                        users.ShowInfo();

                    }
                    dataReader.Close();
                }


            }
        }
    }
}
