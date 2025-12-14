using System;

namespace SingleArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];// Declare an array to hold 10 integers

            for (int i = 0; i < 10; i++)// Loop to get user input
            {
                Console.Write("Enter a number: ");
                numbers[i] = int.Parse(Console.ReadLine());// Store input in the array
            }

            Console.WriteLine("\nYou entered:");
            for (int i = 0; i < 10; i++)// Loop to display the stored numbers
            {
                Console.WriteLine(numbers[i]);// Print each number
            }
        }
    }
}
