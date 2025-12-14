using System;

namespace _017WorkBinaryCon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers would you like to enter? ");
            int count = int.Parse(Console.ReadLine());

            while (count > 0)
            {
                Console.Write("Enter a number (0–255): ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0 || number > 255)
                {
                    Console.WriteLine("Number must be between 0 and 255.");
                    continue;   // ask again without reducing count
                }

                string binary = ConvertTo8BitBinary(number);

                Console.WriteLine("Exponent: " + binary);
                Console.WriteLine();

                count--; // reduce the count
            }

            Console.WriteLine("All numbers converted!");
            Console.ReadLine();
        }

        static string ConvertTo8BitBinary(int number)
        {
            string result = "";

            while (number > 0)
            {
                int remainder = number % 2;
                result = remainder + result;
                number = number / 2;
            }

            // ensure exactly 8 bits
            result = result.PadLeft(8, '0');

            return result;
        }
    }
}
