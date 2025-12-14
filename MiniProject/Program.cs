using System;
using System.IO;

class Program
{
    // Maximum homework allowed
    const int MAX = 20;

    // File name where homework is saved
    const string FILE_NAME = "homework.txt";

    // Arrays to store information
    static string[] subjects = new string[MAX];
    static string[] descriptions = new string[MAX];
    static DateTime[] dates = new DateTime[MAX];
    static bool[] completed = new bool[MAX];

    // Number of homework stored
    static int count = 0;

    static void Main()
    {
        // Load homework from file when program starts
        LoadFromFile();

        int choice = 0;

        // Menu loop
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
                SaveToFile(); // Save before closing
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

        // No homework yet
        if (count == 0)
        {
            Console.WriteLine("No homework assigned.");
        }
        else
        {
            int i = 0;

            while (i < count)
            {
                // Work out days left
                int daysLeft = (dates[i] - DateTime.Today).Days;

                // Colour coding
                if (completed[i] == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (daysLeft <= 3 && daysLeft >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // Simple status text
                string status = "Pending";
                if (completed[i] == true)
                {
                    status = "Completed";
                }

                // Print one homework entry
                Console.WriteLine(
                    (i + 1) + ". [" + status + "] " +
                    subjects[i] + " - " + descriptions[i] +
                    " (Due: " + dates[i].ToString("dd/MM/yyyy") + ")"
                );

                Console.ResetColor();
                i = i + 1;
            }
        }

        Console.WriteLine("\nPress ENTER to return.");
        Console.ReadLine();
    }

    // ---------------- ADD HOMEWORK ----------------
    static void AddHomework()
    {
        // When limit reached
        if (count >= MAX)
        {
            Console.WriteLine("Homework limit reached.");
            Console.ReadLine();
            return;
        }

        Console.Clear();
        Console.WriteLine("ADD HOMEWORK");
        Console.WriteLine("------------");

        // Enter subject
        Console.Write("Enter subject: ");
        string subject = Console.ReadLine();

        // Enter description
        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        DateTime due = DateTime.Today;
        bool validDate = false;

        // Ask for date until valid
        while (validDate == false)
        {
            Console.Write("Enter due date (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            try
            {
                due = DateTime.Parse(input);

                if (due >= DateTime.Today)
                {
                    validDate = true; // ok
                }
                else
                {
                    Console.WriteLine("Date cannot be in the past. Try again.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid date. Try again.");
            }
        }

        // Store homework
        subjects[count] = subject;
        descriptions[count] = description;
        dates[count] = due;
        completed[count] = false;

        count = count + 1;

        Console.WriteLine("Homework added! Press ENTER.");
        Console.ReadLine();
    }

    // ---------------- COMPLETE HOMEWORK ----------------
    static void CompleteHomework()
    {
        Console.Clear();
        Console.WriteLine("COMPLETE HOMEWORK");
        Console.WriteLine("-----------------");

        if (count == 0)
        {
            Console.WriteLine("No homework assigned.");
            Console.ReadLine();
            return;
        }

        // Show list
        int i = 0;
        while (i < count)
        {
            string status = "Pending";
            if (completed[i] == true)
            {
                status = "Completed";
            }

            Console.WriteLine(
                (i + 1) + ". [" + status + "] " +
                subjects[i] + " - " + descriptions[i] +
                " (Due: " + dates[i].ToString("dd/MM/yyyy") + ")"
            );

            i = i + 1;
        }

        // Ask user which one to complete
        bool valid = false;
        int number = 0;

        while (valid == false)
        {
            Console.Write("\nEnter homework number to complete: ");
            string input = Console.ReadLine();

            try
            {
                number = int.Parse(input);

                if (number >= 1 && number <= count)
                {
                    valid = true;
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

    // ---------------- SAVE TO FILE ----------------
    static void SaveToFile()
    {
        // Save each homework on 4 lines
        StreamWriter writer = new StreamWriter(FILE_NAME);

        int i = 0;
        while (i < count)
        {
            writer.WriteLine(subjects[i]);
            writer.WriteLine(descriptions[i]);
            writer.WriteLine(dates[i].ToString("dd/MM/yyyy"));

            if (completed[i] == true)
            {
                writer.WriteLine("true");
            }
            else
            {
                writer.WriteLine("false");
            }

            i = i + 1;
        }

        // End with a blank line
        writer.WriteLine("");

        writer.Close();
    }

    // ---------------- LOAD FROM FILE ----------------
    static void LoadFromFile()
    {
        // If file not created yet
        if (File.Exists(FILE_NAME) == false)
        {
            return;
        }

        StreamReader reader = new StreamReader(FILE_NAME);

        // Read 4 lines per homework
        while (count < MAX)
        {
            string line1 = reader.ReadLine();

            // Stop when blank line found
            if (line1 == "")
            {
                break;
            }

            string line2 = reader.ReadLine();
            string line3 = reader.ReadLine();
            string line4 = reader.ReadLine();

            subjects[count] = line1;
            descriptions[count] = line2;
            dates[count] = DateTime.Parse(line3);

            if (line4 == "true")
            {
                completed[count] = true;
            }
            else
            {
                completed[count] = false;
            }

            count = count + 1;
        }

        reader.Close();
    }
}
