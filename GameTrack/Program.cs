using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game_Score_Track
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the IQ Test");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1.Player Registration");
                Console.WriteLine("2.Game Records");
                Console.WriteLine("3.View Score History");
                Console.WriteLine("4.View Leaderboard");
                Console.WriteLine("5.View Player Statistics");
                Console.WriteLine("6.Achievement System");
                Console.WriteLine("7.Admin Mode");
                Console.WriteLine("8.Exit Program");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        register();
                        break;

                    case "2":
                        record();
                        break;

                    case "3":
                        History();
                        break;

                    case "4":
                        Leaderboard();
                        break;

                    case "5":
                        Stats();
                        break;

                    case "6":
                        Achieve();
                        break;

                    case "7":
                        Admin();
                        break;

                    case "8":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
        static void register()
        {
            Console.WriteLine("Please enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your Surname");
            string surname = Console.ReadLine();
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

        }

        static void record()
        {

        }

        static void History()
        {

        }

        static void Leaderboard()
        {

        }

        static void Stats()
        {

        }

        static void Achieve()
        {

        }

        static void Admin()
        {

        }
    }
}

