using System;
using System.IO;

namespace _020TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your subject:");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter your marks in test:");
            int mark = int.Parse(Console.ReadLine());

            // 🔹 CLEAR PREVIOUS RESULTS (reuse the file)
            using (StreamWriter writer = new StreamWriter("example.txt"))
            {
                // File is now empty
            }

            // 🔹 WRITE NEW RESULTS
            using (StreamWriter writer = new StreamWriter("example.txt", true))
            {
                writer.WriteLine("This is an example text file.");
                writer.WriteLine("Your name is " + name);
                writer.WriteLine("Your age is " + age);
                writer.WriteLine("Your subject is " + subject);
                writer.WriteLine("Your marks in test is " + mark);
                writer.WriteLine("Thanks for this information");
            }

            Console.WriteLine("File reused and updated successfully.");
        }
    }
}
