using System;

namespace TwoDArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a 2D array with 2 rows and 3 columns
            int[,] numbers = new int[2, 3];

            // Ask the user to enter numbers
            for (int row = 0; row < 2; row++)        // Loop through each row
            {
                for (int col = 0; col < 3; col++)    // Loop through each column
                {
                    Console.Write("Enter a number: ");   // Ask for input
                    numbers[row, col] = int.Parse(Console.ReadLine()); // Store the number
                }
            }

            // Show the numbers back to the user
            Console.WriteLine("\nYou entered:");

            for (int row = 0; row < 2; row++)        // Loop through each row again
            {
                for (int col = 0; col < 3; col++)    // Loop through each column again
                {
                    Console.Write(numbers[row, col] + " ");  // Print each number
                }
                Console.WriteLine();  // Make a new line after each row
            }
        }
    }
}
