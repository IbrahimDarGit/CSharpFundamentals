using System;

namespace _009WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Enter a number to count up to: ");// Ask the user for a number
        int number = int.Parse(Console.ReadLine());

        int i = 0;// sets initial value of i to 0

        while (i <= number)
        {
            Console.WriteLine(i);// Print the current number
            i++;// Increases value of i by 1
            
        }
        Console.WriteLine("Done!");//not part of the loop, indicates completion
        Console.ReadLine();// Keeps window open until user presses Enter
        }
    }
}
