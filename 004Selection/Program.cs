using System;

namespace SelectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // PART 1: Getting information
            // -------------------------------
            Console.WriteLine("Welcome to the Selection Demo!");
            Console.WriteLine("Let's collect some basic information first.\n");

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("What is your height in metres? ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Enter your date of birth (e.g. 12/03/2010): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false): ");
            bool isStudent = bool.Parse(Console.ReadLine());

            Console.Write("Enter your current grade (as a number): ");
            int currentGrade = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Summary of your details ---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height + "m");
            Console.WriteLine("Date of Birth: " + dob.ToShortDateString());
            Console.WriteLine("Student: " + isStudent);
            Console.WriteLine("Next Year: " + (currentGrade + 1));

            // -------------------------------
            // PART 2: Selection examples
            // -------------------------------

            Console.WriteLine("\n--- Selection and Decisions ---");

            // Simple IF statement
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }

            // IF-ELSE statement
            if (isStudent)
            {
                Console.WriteLine("You are a student. Keep learning!");
            }
            else
            {
                Console.WriteLine("You are not a student. Learning never stops though!");
            }

            // IF-ELSE IF-ELSE chain
            if (currentGrade >= 9)
            {
                Console.WriteLine("Fantastic! You are achieving top grades.");
            }
            else if (currentGrade >= 5)
            {
                Console.WriteLine("Good job! You passed.");
            }
            else
            {
                Console.WriteLine("Don’t give up! You can improve with more practice.");
            }

            // Logical AND (&&)
            if (age > 16 && isStudent)
            {
                Console.WriteLine("You might be in college or sixth form.");
            }

            // Logical OR (||)
            if (height > 1.8 || age > 30)
            {
                Console.WriteLine("You are either quite tall or more experienced in life (or both)!");
            }

            // Nested IF example
            if (isStudent)
            {
                if (currentGrade >= 8)
                {
                    Console.WriteLine("You are an excellent student!");
                }
                else
                {
                    Console.WriteLine("Stay consistent and you will reach higher grades soon.");
                }
            }

            Console.WriteLine("\nThank you, " + name + "! This was the Selection Demo.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();// Waits for the user to press any key before closing the program
        }
    }
}

