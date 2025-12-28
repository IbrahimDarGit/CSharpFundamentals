using System;

namespace _019SubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("==== STUDENT NAME SYSTEM ====");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Please Choose an option:");
                Console.WriteLine("1. Add Student Name");
                Console.WriteLine("2. Exit program");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    AddStudentName();
                }
                else if (option == "2")
                {
                    Console.WriteLine("Thank you for using the Student Name System");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                    Console.ReadLine();
                }
            }
        }
        static void AddStudentName()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("==== STUDENT NAME SYSTEM ====");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Please enter the number of students:");
            int numStud = int.Parse(Console.ReadLine());

            string[,] students = new string[numStud, 4];

            for (int i = 0; i < numStud; i++)
            {
                Console.WriteLine("Enter name of student " + (i + 1) + ":");
                students[i, 0] = Console.ReadLine();

                Console.WriteLine("Enter surname of student " + (i + 1) + ":");
                students[i, 1] = Console.ReadLine();

                Console.WriteLine("Enter subject of student " + (i + 1) + ":");
                students[i, 2] = Console.ReadLine();

                Console.WriteLine("Enter marks of student " + (i + 1) + ":");
                students[i, 3] = Console.ReadLine();
            }
            
            Console.WriteLine("The entered student details are:");
            for (int i = 0; i < numStud; i++)
            {
                Console.WriteLine($"Student {i + 1} Name: {students[i, 0]} Surname:{students[i, 1]} Subject: {students[i, 2]} Marks: {students[i, 3]}");
            }

            Console.WriteLine("Cell Print Subject " + students[0, 2]);

            Console.ReadLine();
        }
    }
}
