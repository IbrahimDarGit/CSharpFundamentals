using System;

namespace _103PseudoMean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of numbers to enter between 1 and 10:");
            int num = int.Parse(Console.ReadLine());

            while (num <= 0 || num >= 11)
            {
                Console.WriteLine("Please enter a number between 1 and 10:");
                num = int.Parse(Console.ReadLine());
            }

            int total = 0;
            int biggest = -1;
            int smallest = -1;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Enter positive number " + i);
                int n = int.Parse(Console.ReadLine());

                total = total + n;

                if (n > biggest)
                {
                    biggest = n;
                }

                if (n < smallest || smallest < 0)
                {
                    smallest = n;
                }
            }

            double mean = (double)total / num;
            int range = biggest - smallest;

            Console.WriteLine("Mean = " + mean);
            Console.WriteLine("Range = " + range);
        }
    }
}
