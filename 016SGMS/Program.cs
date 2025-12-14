using System;

namespace _016SGMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add a new student");
            Console.WriteLine("2.View all students");
            Console.WriteLine("3. Show class average");
            Console.WriteLine("4. Show highest mark");
            Console.WriteLine("5. Search for a student name");
            Console.WriteLine("6. exit to quit");

            Console.Write("Choose an option (1-6): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
            case 1:
            Console.WriteLine("You chose: Add a new student");
            break;

            case 2:
            Console.WriteLine("You chose: Display all students");
            break;

            case 3:
            Console.WriteLine("You chose: Show class average");
            break;

            case 4:
            Console.WriteLine("You chose: Show highest mark");
            break;

            case 5:
            Console.WriteLine("You chose: Search for a student by name");
            break;

            case 6:
            Console.WriteLine("Exiting program...");
            break;

            default:
            Console.WriteLine("Invalid choice! Enter 1–6.");
            break;
            }
        }
    }
}
