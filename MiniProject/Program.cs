using System;
using System.IO;

class Program
{
    const int MAX = 20; // Maximum number of homework items

    // Arrays to store homework information
    static string[] subjects = new string[MAX];
    static string[] descriptions = new string[MAX];
    static DateTime[] dates = new DateTime[MAX];
    static bool[] completed = new bool[MAX];
    static int count = 0; // Number of homework items stored

    static void Main()
    {
        // Load homework from file at the start
        LoadFromFile();

        int choice = 0;

        // Main menu loop
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("HOMEWORK DIARY SYSTEM");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. View Homework");
            Console.WriteLine("2. Add Homework");
            Console.WriteLine("3. Complete Homework");
            Console.WriteLine("4. Quit");
            Console.Write("\nEnter your choice: ");

            string input = Console.ReadLine();

            // Simple menu using strings
            if (input == "1")
            {
                choice = 1;
                ViewHomework();
            }
            else if (input == "2")
            {
                choice = 2;
                AddHomework();
            }
            else if (input == "3")
            {
                choice = 3;
                CompleteHomework();
            }
            else if (input == "4")
            {
                choice = 4;
                SaveToFile(); // Save before exiting
                Console.WriteLine("Saved. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Press ENTER.");
                Console.ReadLine();
            }
        }
    }

        // ---------------- VIEW HOMEWORK ----------------
    static void ViewHomework()
    {
        Console.Clear();
        Console.WriteLine("VIEW HOMEWORK");
        Console.WriteLine("-------------");

        // If nothing stored
        if (count == 0)
        {
            Console.WriteLine("No homework assigned.");
        }
        else
        {
            // Loop through all homework items
            for (int i = 0; i < count; i++)
            {
                // Work out days left using simple maths
                int daysLeft = (dates[i] - DateTime.Today).Days;

                // Change colour based on status
                if (completed[i] == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // completed
                }
                else if (daysLeft <= 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // urgent
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White; // normal
                }

                // Use simple string building (no $"")
                string status = completed[i] ? "Completed" : "Pending";

                Console.WriteLine((i + 1) + ". [" + status + "] " +subjects[i] + " - " + descriptions[i] +" (Due: " + dates[i].ToString("dd/MM/yyyy") + ")"
                );

                Console.ResetColor(); // reset colour
            }
        }

        Console.WriteLine("\nPress ENTER to return.");
        Console.ReadLine();
    }
        // ---------------- ADD HOMEWORK ----------------
    static void AddHomework()
    {
        // Stop adding if max reached
        if (count >= MAX)
        {
            Console.WriteLine("Homework limit reached.");
            Console.ReadLine();
            return;
        }

        Console.Clear();
        Console.WriteLine("ADD HOMEWORK");
        Console.WriteLine("------------");

        Console.Write("Enter subject: ");
        string subject = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        // Get date from user with simple try-catch
        DateTime due = DateTime.Today;
        bool validDate = false;

        while (validDate == false)
        {
            Console.Write("Enter due date (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            try
            {
                due = DateTime.Parse(input); // basic conversion

                if (due < DateTime.Today)
                {
                    Console.WriteLine("Date cannot be in the past.");
                }
                else
                {
                    validDate = true; // date is ok
                }
            }
            catch
            {
                Console.WriteLine("Invalid date. Try again.");
            }
        }

        // Store the new homework in arrays
        subjects[count] = subject;
        descriptions[count] = description;
        dates[count] = due;
        completed[count] = false;

        count++; // increase amount stored

        Console.WriteLine("Homework added! Press ENTER.");
        Console.ReadLine();
    }
        // ---------------- COMPLETE HOMEWORK ----------------
    static void CompleteHomework()
    {
        Console.Clear();
        Console.WriteLine("COMPLETE HOMEWORK");
        Console.WriteLine("-----------------");

        // No homework yet
        if (count == 0)
        {
            Console.WriteLine("No homework assigned.");
            Console.ReadLine();
            return;
        }

        // Show all homework
        for (int i = 0; i < count; i++)
        {
            string status = completed[i] ? "Completed" : "Pending";

            Console.WriteLine(
                (i + 1) + ". [" + status + "] " +
                subjects[i] + " - " + descriptions[i] +
                " (Due: " + dates[i].ToString("dd/MM/yyyy") + ")"
            );
        }

        // Ask user which one to complete
        int number = -1;
        bool validNumber = false;

        while (validNumber == false)
        {
            Console.Write("\nEnter homework number to complete: ");
            string input = Console.ReadLine();

            try
            {
                number = int.Parse(input); // convert to number

                if (number >= 1 && number <= count)
                {
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("Number out of range.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid number.");
            }
        }

        // Mark as completed
        completed[number - 1] = true;

        Console.WriteLine("Homework marked as completed! Press ENTER.");
        Console.ReadLine();
    }
    
}

