using System;
using System.IO;

namespace _021RandomNum
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Number Generator");
                Console.WriteLine("Please pick an option:");
                Console.WriteLine("1. Take a Guess");
                Console.WriteLine("2. Admin - View Records");
                Console.WriteLine("3. Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        num();
                        break;

                    case "2":
                        viewRecords();
                        break;

                    case "3":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void num()
        {
            Console.Clear();

            Random rand = new Random();
            int random = rand.Next(1, 101);

            Console.WriteLine("Please guess the number between 1 and 100:");

            int score = 0;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                score++;

                if (random == num)
                {
                    Console.WriteLine("Congratulations on guessing the number");
                    Console.WriteLine("Your total number of guesses was: " + score);
                    break;
                }
                else if (num < random)
                {
                    Console.WriteLine("Too low, try again:");
                }
                else
                {
                    Console.WriteLine("Too high, try again:");
                }
            }

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            StreamWriter writer = new StreamWriter("scores.txt", true);
            writer.WriteLine(name + " | Guesses: " + score);
            writer.Close();

            Console.WriteLine("Score saved.");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }

        static void viewRecords()
        {
            Console.Clear();

            if (File.Exists("scores.txt"))
            {
                StreamReader reader = new StreamReader("scores.txt");

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }

                reader.Close();
            }
            else
            {
                Console.WriteLine("No records found.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
    }
}