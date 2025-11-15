using System;

namespace _011TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;  // we need a variable to store the number

        try
        {
            // Ask the user to enter a number
            Console.Write("Please enter a number: ");

            // Try to convert the input into an integer
            number = int.Parse(Console.ReadLine());

            // If it works, show success message
            Console.WriteLine("You entered the number: " + number);
        }
        catch
        {
            // This happens ONLY if the input is not a valid number
            Console.WriteLine("That is not a valid number. Please try again.");
        }
        finally
        {
            // This ALWAYS runs no matter what
            Console.WriteLine("Thank you for using this program!");
        }

        Console.ReadLine(); // keeps window open
        }
    }
}
