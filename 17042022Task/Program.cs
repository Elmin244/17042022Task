using System;
using System.Text;
using _17042022Task.Data;
namespace _17042022Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // ə hərfi ucun
            Console.OutputEncoding = Encoding.UTF8;
            bool active = true;
            while (active)
            {
                Menu();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        InsertStadion.AllStadion();
                        break;
                    case "2":
                        SelectStadion.AllStadions();
                        break;
                    case "3":
                        InsertUsers.AllUsers();
                        break;
                    case "4":
                        SelectUsers.AllUsers();
                        break;
                    case "5":
                        SelectReservation.AllReservations();
                        break;
                    case "6":
                        break;
                    case "7":
                        SelectReservation.GetReservationForStadionId(1);
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    case "10":
                        active = false;
                        break;

                    default:
                        break;
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("1. Stadion əlavə et\n2. Stadionları göstər\n3. İstifadəçi əlavə et\n4. İstifadəçiləri göstər\n5. Rezervasiyaları göstər");
            Console.WriteLine("6. Rezervasiya yarat\n7. Verilmiş id-li stadionun rezervasiyalarını göstər\n8. Verilmiş id-li userin rezervasiyalarını göstər");
            Console.WriteLine("9. Verilmiş id-li rezervasiyanı sil\n10-Quit");
        }
    }
}


