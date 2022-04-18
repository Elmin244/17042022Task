using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using _17042022Task.Models;
namespace _17042022Task.Data
{
    class SelectReservation
    {
        
        public static void AllReservations()
        {
            string conStr = @"SERVER=DESKTOP-LJN6KSR\SQLEXPRESS;DATABASE=Football;Trusted_Connection=true";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = "SELECT * FROM Reservations";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        int id = result.GetInt32(0);
                        int stadionid = result.GetInt32(1);
                        int userid = result.GetInt32(2);
                        DateTime startdate = result.GetDateTime(3);
                        DateTime enddate = result.GetDateTime(4);
                        Reservation reservation = new Reservation()
                        {
                            ID = id,
                            StadionID = stadionid,
                            UserID = userid,
                            StartDate = startdate,
                            EndDate = enddate
                        };
                        reservation.ShowInfo();
                    }
                }
            }
        }
        public static void GetReservationForStadionId(int getstadionid)
        {
            string conStr = @"SERVER=DESKTOP-LJN6KSR\SQLEXPRESS;DATABASE=Football;Trusted_Connection=true";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = "SELECT * FROM Reservations WHERE StadionID = @stadionId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("stadionId", getstadionid);
                    SqlDataReader result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        int id = result.GetInt32(0);
                        int stadionid = result.GetInt32(1);
                        int userid = result.GetInt32(2);
                        DateTime startdate = result.GetDateTime(3);
                        DateTime enddate = result.GetDateTime(4);
                        Reservation reservation = new Reservation()
                        {
                            ID = id,
                            StadionID = stadionid,
                            UserID = userid,
                            StartDate = startdate,
                            EndDate = enddate
                        };
                        reservation.ShowInfo();
                    }
                }
            }
        }
    }
}
