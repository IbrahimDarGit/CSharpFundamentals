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
                        // Code to calculate class average marks
                        break;
                    case "3":
                        // Code to generate reports
                        break;
                    case "4":
                        Console.WriteLine("Exiting application. Goodbye!");
                        return; // Exit the application
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        static void Add()
        {
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
                    writer.WriteLine("This is an example text file.");
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
        }

        static void Average()
        {
            // Code to calculate class average marks
        }
        static void Report()
        {
            // Code to generate reports
        }
    }
}

