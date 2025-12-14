using System;

namespace _104BarCode
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("##### WELCOME TO BARCODE SYSTEM #####");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("1. Enter Barcode");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    EnterBarcode();
                }
                else if (option == "2")
                {
                    Console.WriteLine("Thank you, hope to see you soon!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadLine();
                }
            }
        }

        static void EnterBarcode()
        {
            Console.Write("Please enter your 13 digit barcode number: ");
            string barcode = Console.ReadLine();

            if (barcode.Length != 13)
            {
                Console.WriteLine("Invalid barcode. It must be exactly 13 digits.");
                Console.ReadLine();
                return;
            }

            foreach (char c in barcode)
            {
                if (!char.IsDigit(c))
                {
                    Console.WriteLine("Invalid barcode. Only digits (0–9) are allowed.");
                    Console.ReadLine();
                    return;
                }
            }

            int oddTotal = 0;
            int evenTotal = 0;

            for (int i = 0; i < barcode.Length; i++)
            {
                int digit = int.Parse(barcode[i].ToString());

                if ((i + 1) % 2 == 0)
                {
                    evenTotal += digit;
                }
                else
                {
                    oddTotal += digit;
                }
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Sum of ODD-position digits : " + oddTotal);
            Console.WriteLine("Sum of EVEN-position digits: " + evenTotal);
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
    }
}
