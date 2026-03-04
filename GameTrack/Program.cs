using System;
using System.IO;

namespace Game_Score_Track
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the IQ Test");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Player Registration");
                Console.WriteLine("2. Game Records");
                Console.WriteLine("3. Admin Mode");
                Console.WriteLine("4. Exit Program");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        int score = test();
                        register(score);
                        break;

                    case "2":
                        record();
                        break;

                    case "3":
                        Admin();
                        break;

                    case "4":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // ================= TEST =================
        static int test()
        {
            Console.Clear();
            int score = 0;

            string correct1 = "b";
            string correct2 = "b";
            string correct3 = "b";
            string correct4 = "b";
            string correct5 = "c";
            string correct6 = "a";
            string correct7 = "b";

            Console.WriteLine("Question 1: Which country has the largest population?");
            Console.WriteLine("A) USA");
            Console.WriteLine("B) India");
            Console.WriteLine("C) China");
            Console.Write("Your answer: ");
            if (Console.ReadLine().ToLower() == correct1) score++;

            Console.WriteLine();

            Console.WriteLine("Question 2: What is the capital of Australia?");
            Console.WriteLine("A) Sydney");
            Console.WriteLine("B) Canberra");
            Console.WriteLine("C) Melbourne");
            Console.Write("Your answer: ");
            if (Console.ReadLine().ToLower() == correct2) score++;

            Console.WriteLine();

            Console.WriteLine("Question 3: Chemical symbol 'Au' is?");
            Console.WriteLine("A) Silver");
            Console.WriteLine("B) Gold");
            Console.WriteLine("C) Aluminium");
            Console.Write("Your answer: ");
            if (Console.ReadLine().ToLower() == correct3) score++;

            Console.WriteLine();

            Console.WriteLine("Question 4: When did WWII end?");
            Console.WriteLine("A) 1944");
            Console.WriteLine("B) 1945");
            Console.WriteLine("C) 1946");
            Console.Write("Your answer: ");
            if (Console.ReadLine().ToLower() == correct4) score++;

            Console.WriteLine();

            Console.WriteLine("Question 5: Square root of 144?");
            Console.WriteLine("A) 10");
            Console.WriteLine("B) 14");
            Console.WriteLine("C) 12");
            Console.Write("Your answer: ");
            if (Console.ReadLine().ToLower() == correct5) score++;

            Console.WriteLine();

            Console.WriteLine("Question 6: Which game made most money?");
            Console.WriteLine("A) GTA V");
            Console.WriteLine("B) Minecraft");
            Console.WriteLine("C) Candy Crush");
            Console.Write("Your answer: ");
            if (Console.ReadLine().ToLower() == correct6) score++;

            Console.WriteLine();

            Console.WriteLine("Question 7: Who won Ligue 1 in 2017?");
            Console.WriteLine("A) PSG");
            Console.WriteLine("B) Monaco");
            Console.WriteLine("C) Lyon");
            Console.Write("Your answer: ");
            if (Console.ReadLine().ToLower() == correct7) score++;

            Console.WriteLine();
            Console.WriteLine("Your final score is: " + score + " out of 7");

            return score;
        }

        // ================= REGISTER =================
        static void register(int score)
        {
            Console.WriteLine();
            Console.WriteLine("Please enter your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your Surname:");
            string surname = Console.ReadLine();

            DateTime today = DateTime.Today;
            string date = today.ToString("dd/MM/yyyy");

            string record = name + " " + surname + " | Score: " + score + " | Date: " + date;

            using (StreamWriter writer = new StreamWriter("scores.txt", true))
            {
                writer.WriteLine(record);
            }

            Console.WriteLine("Score saved successfully.");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        // ================= VIEW RECORDS =================
        static void record()
        {
            Console.Clear();

            if (File.Exists("scores.txt"))
            {
                using (StreamReader reader = new StreamReader("scores.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        Console.WriteLine(reader.ReadLine());
                    }
                }
            }
            else
            {
                Console.WriteLine("No records found.");
            }

            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        // ================= ADMIN =================
        static void Admin()
        {
            Console.Clear();

            string correctPassword = "Admin";
            int attempts = 0;
            bool accessGranted = false;

            while (attempts < 3)
            {
                Console.WriteLine("Enter Admin Password:");
                string userInput = Console.ReadLine();

                if (userInput == correctPassword)
                {
                    accessGranted = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password.");
                    attempts++;
                }
            }

            if (!accessGranted)
            {
                Console.WriteLine("You are unauthorised.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Welcome to Admin Mode.");
            Console.WriteLine("Enter full name to delete:");
            string deleteName = Console.ReadLine();

            if (File.Exists("scores.txt"))
            {
                using (StreamReader reader = new StreamReader("scores.txt"))
                using (StreamWriter writer = new StreamWriter("temp.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        if (!line.Contains(deleteName))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                File.Delete("scores.txt");
                File.Move("temp.txt", "scores.txt");

                Console.WriteLine("Deletion complete.");
            }
            else
            {
                Console.WriteLine("No records found.");
            }

            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }
    }
}