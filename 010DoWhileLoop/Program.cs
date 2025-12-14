using System;

namespace _010DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());
            int number = 1;

            do
            {
                Console.WriteLine(number); // Print the current number
                number++;
            }
            while (number <= i);// Continue until number exceeds i
            
            Console.WriteLine("Done!");
            Console.ReadLine(); // Keeps window open
        }
    }
}
