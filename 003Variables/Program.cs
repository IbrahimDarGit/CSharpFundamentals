using System;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstrating different variable types and parsing from user input
            // STRING
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");

            // INT
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old.");

            // DOUBLE
            Console.Write("What is your height in metres? ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Your height is " + height + "m.");

            // DATETIME
            Console.Write("Enter your date of birth (e.g. 12/03/2010): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Your date of birth is: " + dob.ToShortDateString());

            // BOOL
            Console.Write("Are you a student? (true/false): ");
            bool isStudent = bool.Parse(Console.ReadLine());
            Console.WriteLine("Student status: " + isStudent);

            // INT.PARSE demonstration
            Console.Write("Enter your current year (as a number): ");
            string yearInput = Console.ReadLine();
            int currentYear = int.Parse(yearInput);
            Console.WriteLine("Next year will be: " + (currentYear + 1));

            Console.WriteLine("\n--- Summary ---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("DOB: " + dob.ToShortDateString());
            Console.WriteLine("Student: " + isStudent);
            Console.WriteLine("Next Year: " + (currentYear + 1));
        }
    }
}
