using System;

namespace _005Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch statement example
            Console.WriteLine("=== Switch Statement Example ===");

            // Ask user for a number between 1 and 7
            Console.Write("Enter a number for the day of the week (1–7): ");

            // Convert input to an integer
            int dayOfWeek = int.Parse(Console.ReadLine());

            // Decide message based on number entered
            switch (dayOfWeek)
            {
                case 1:// Runs if user enters 1
                    Console.WriteLine("Today is Monday – Boo!");
                    break;
                case 2:// Runs if user enters 2
                    Console.WriteLine("Today is Tuesday – getting better!");
                    break;
                case 3:// Runs if user enters 3
                    Console.WriteLine("Today is Wednesday – halfway there!");
                    break;
                case 4:// Runs if user enters 4
                    Console.WriteLine("Today is Thursday – almost the weekend!");
                    break;
                case 5:// Runs if user enters 5
                    Console.WriteLine("Today is Friday – finally!");
                    break;
                case 6:// Runs if user enters 6
                    Console.WriteLine("Today is Saturday – yeh!");
                    break;
                case 7:// Runs if user enters 7
                    Console.WriteLine("Today is Sunday – relax day.");
                    break;
                default:// Here if input doesn’t match 1–7
                    Console.WriteLine("That’s not a valid day! Please enter 1–7.");
                    break;
            }

            // Wait for user before closing
            Console.WriteLine("Program finished. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
