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
                        int score = test();
                        register(score);
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
        static void register(int score)
        {
            Console.Clear();
            test();

            Console.WriteLine("Please enter your Name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your Surname");
            string surname = Console.ReadLine();

            DateTime today = DateTime.Today;
            string date = today.ToString("dd/MM/yyyy");

            // Create formatted line
            string record = name + " " + surname + " | Score: " + score + " | Date: " + date;

            // Append to file
            using (StreamWriter writer = new StreamWriter("scores.txt", true))
            {
                writer.WriteLine(record);
            }

            Console.WriteLine("Score saved successfully.");
        }

        static int test()
        {
            int score = 0;

            // Correct answers
            string correct1 = "b";
            string correct2 = "b";
            string correct3 = "b";
            string correct4 = "b";
            string correct5 = "b";
            string correct6 = "a";
            string correct7 = "b";

            // Question 1
            Console.WriteLine("Question 1: Which country has the largest population in the world?");
            Console.WriteLine("A) USA");
            Console.WriteLine("B) India");
            Console.WriteLine("C) China");
            Console.Write("Your answer: ");
            string opt1 = Console.ReadLine();
            opt1 = opt1.ToLower();

            if (opt1 == correct1)
            {
                score++;
            }

            Console.WriteLine("Correct answer: " + correct1);
            Console.WriteLine();

            // Question 2
            Console.WriteLine("Question 2: What is the capital city of Australia?");
            Console.WriteLine("A) Sydney");
            Console.WriteLine("B) Canberra");
            Console.WriteLine("C) Melbourne");
            Console.Write("Your answer: ");
            string opt2 = Console.ReadLine();
            opt2 = opt2.ToLower();

            if (opt2 == correct2)
            {
                score++;
            }

            Console.WriteLine("Correct answer: " + correct2);
            Console.WriteLine();

            // Question 3
            Console.WriteLine("Question 3: Which element has the chemical symbol 'Au'?");
            Console.WriteLine("A) Silver");
            Console.WriteLine("B) Gold");
            Console.WriteLine("C) Aluminium");
            Console.Write("Your answer: ");
            string opt3 = Console.ReadLine();
            opt3 = opt3.ToLower();

            if (opt3 == correct3)
            {
                score++;
            }

            Console.WriteLine("Correct answer: " + correct3);
            Console.WriteLine();

            // Question 4
            Console.WriteLine("Question 4: In which year did World War II end?");
            Console.WriteLine("A) 1944");
            Console.WriteLine("B) 1945");
            Console.WriteLine("C) 1946");
            Console.Write("Your answer: ");
            string opt4 = Console.ReadLine();
            opt4 = opt4.ToLower();

            if (opt4 == correct4)
            {
                score++;
            }

            Console.WriteLine("Correct answer: " + correct4);
            Console.WriteLine();

            // Question 5
            Console.WriteLine("Question 5: What is the square root of 144?");
            Console.WriteLine("A) 10");
            Console.WriteLine("B) 12");
            Console.WriteLine("C) 14");
            Console.Write("Your answer: ");
            string opt5 = Console.ReadLine();
            opt5 = opt5.ToLower();

            if (opt5 == correct5)
            {
                score++;
            }

            Console.WriteLine("Correct answer: " + correct5);
            Console.WriteLine();

            // Question 6
            Console.WriteLine("Question 6: Which game has made the most money?");
            Console.WriteLine("A) GTA V");
            Console.WriteLine("B) Minecraft");
            Console.WriteLine("C) Candy Crush");
            Console.Write("Your answer: ");
            string opt6 = Console.ReadLine();
            opt6 = opt6.ToLower();

            if (opt6 == correct6)
            {
                score++;
            }

            Console.WriteLine("Correct answer: " + correct6);
            Console.WriteLine();

            // Question 7
            Console.WriteLine("Question 7: Who won Ligue 1 in 2017?");
            Console.WriteLine("A) PSG");
            Console.WriteLine("B) Monaco");
            Console.WriteLine("C) Lyon");
            Console.Write("Your answer: ");
            string opt7 = Console.ReadLine();
            opt7 = opt7.ToLower();

            if (opt7 == correct7)
            {
                score++;
            }

            Console.WriteLine("Correct answer: " + correct7);
            Console.WriteLine();

            Console.WriteLine("Your final score is: " + score + " out of 7");

            return score;
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
