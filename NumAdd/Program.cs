using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a whole number");

                int num;
                int sum = 0;

                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                    Console.ReadLine();
                    continue;
                }

                if (num % 2 == 0)
                {
                    Console.WriteLine("This is an Even Number");
                }
                else if (num % 2 != 0)
                {
                    Console.WriteLine("This is an odd Number");
                }
                else
                {
                    Console.WriteLine("Number isnt accepted.Try again");
                }
                if (num < 0)
                {
                    num = num * -1;
                }

                //Console.WriteLine("debug 1 " + num);

                for (; num > 0; num = num / 10)
                {
                    sum = sum + (num % 10);
                    //int addition = sum;
                    //Console.WriteLine("debug 2 num = " + num + " sum = "+ sum + "num / 10 = "+ num / 10)  ;
                    Console.Write(sum);
                    if (num / 10 > 0)
                        Console.Write("+");
                }

                Console.WriteLine(" Sum of digits = " + sum);

                if (sum % 2 == 0)
                {
                    Console.WriteLine(sum + " is an Even Number");
                }
                else if (sum % 2 != 0)
                {
                    Console.WriteLine(sum + " is an odd Number");
                }
                else
                {
                    Console.WriteLine("Number isnt accepted.Try again");
                }

                Console.ReadLine();
            }
        }
    }
}