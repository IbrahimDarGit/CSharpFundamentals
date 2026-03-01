using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number sequence:");
            string seq = Console.ReadLine();
            string[] num = seq.Split(',');

            int[] frequency = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                int value = int.Parse(num[i]);
                frequency[value] = frequency[value] + 1;
            }

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(i + "    " + frequency[i]);
            }

            Console.ReadLine();
        }
    }
}
