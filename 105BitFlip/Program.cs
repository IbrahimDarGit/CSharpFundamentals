using System;

namespace _105BitFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("##### WELCOME TO BIT FLIP SYSTEM #####");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("1. Enter Binary String");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    EnterBinaryString();
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
        static void EnterBinaryString()
        {
            Console.WriteLine("How many bits would you like to flip?");
            string flip= int.Parse(Console.ReadLine());
            Console.Write("Please enter your 8 bit binary string: ");
            string binary = Console.ReadLine();
            for (int i = 0; i < flip; i++)
            {
                if (binary.Length != 8)
                {
                    Console.WriteLine("Invalid binary string. It must be exactly 8 bits.");
                    Console.ReadLine();
                    return;
                }
                else if(binary[i] != '0' && binary[i] != '1')
                {
                    Console.WriteLine("Invalid binary string. It must contain only 0s and 1s.");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    char[] flippedBinary = new char[8];
                    for (int i = 0; i < 8; i++)
                    {
                        flippedBinary[i] = binary[i] == '0' ? '1' : '0';
                    }
                    Console.WriteLine("Flipped binary string: " + new string(flippedBinary));
                    Console.ReadLine();
                }
            }
        }
    }
}
