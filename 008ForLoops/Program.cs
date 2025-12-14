using System;

namespace _008ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
        // Ask the user for a number
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Counting from 1 to " + number + ":");

        // Loop from 1 up to the number entered
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);// Print the current number
        }

        Console.WriteLine("Done!");
        Console.ReadLine(); // Keeps window open until user presses Enter
        }
    }
}
