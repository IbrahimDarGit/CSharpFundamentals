using System;
using System.IO;

namespace SGMS
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("STUDENT GRADE MANAGEMENT SYSTEM");
                Console.WriteLine("===============================");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add / view Student Information");
                Console.WriteLine("2. Class Average Marks");
                Console.WriteLine("3. Generate reports");
                Console.WriteLine("4. Exit Application");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Average();
                        break;
                    case "3":
                        Report();
                        break;
                    case "4":
                        Console.WriteLine("Exiting application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        static void Add()
        {
            Console.Clear();
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add student information");
            Console.WriteLine("2. view student information");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Please enter your name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your age:");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your subject:");
                string subject = Console.ReadLine();

                Console.WriteLine("Enter your marks in test:");
                int mark = int.Parse(Console.ReadLine());


                using (StreamWriter writer = new StreamWriter("example.txt"))
                {

                }
                using (StreamWriter writer = new StreamWriter("example.txt", true))
                {
                    writer.WriteLine("Student Information");
                    writer.WriteLine("Your name is " + name);
                    writer.WriteLine("Your age is " + age);
                    writer.WriteLine("Your subject is " + subject);
                    writer.WriteLine("Your marks in test is " + mark);
                    writer.WriteLine("Thanks for this information");
                }
                Console.WriteLine("File successfully updated");
            }
            else if (choice == "2")
            {
                StreamReader reader = new StreamReader("example.txt");

                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }

                reader.Close();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid option.Retry");
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        static void Average()
        {
            Console.Clear();
            Console.WriteLine("How many Students results do you have?");
            int m = int.Parse(Console.ReadLine());

            int x = 0;
            int total = 0;

            while (x < m)
            {
                Console.WriteLine("Please enter student " + (x + 1) + " Marks");
                int addition = int.Parse(Console.ReadLine());

                if (addition < 0)
                {
                    Console.WriteLine("Invalid amount");
                }
                else
                {
                    total = total + addition;
                    x++;   // VERY IMPORTANT
                }
            }

            Console.WriteLine("Total marks are: " + total);

            if (m > 0)
            {
                int mean = total / m;
                Console.WriteLine("Average class marks are " + mean);
            }
            Console.ReadLine();
        }

        static void Report()
        {
            Console.Clear();
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1.Add reports");
            Console.WriteLine("2.View reports");
            string dec = Console.ReadLine();
            if (dec == "1")
            {
                Console.WriteLine("Please enter students name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter students your age:");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter subject:");
                string subject = Console.ReadLine();

                Console.WriteLine("Enter your students marks in test:");
                int mark = int.Parse(Console.ReadLine());


                using (StreamWriter writer = new StreamWriter("report.txt"))
                {

                }
                using (StreamWriter writer = new StreamWriter("report.txt", true))
                {
                    writer.WriteLine("Student report");
                    writer.WriteLine("Stundent name is " + name);
                    writer.WriteLine("Student age is " + age);
                    writer.WriteLine("Student subject is " + subject);
                    writer.WriteLine("Student marks in test is " + mark);
                }
                Console.WriteLine("File successfully updated");
            }
            else if (dec == "2")
            {
                StreamReader reader = new StreamReader("report.txt");

                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }

                reader.Close();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid option.Retry");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

