using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitConv
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] colours = {  ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.DarkCyan, ConsoleColor.DarkYellow};
            int index = 0;

            while (true)
            {

                //Console.BackgroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = colours[index];
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("##### WELCOME TO SIZE CONVERTER #####");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine("1. Image File Size");
                Console.WriteLine("2. Text File Size");
                Console.WriteLine("3. Sound File Size");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                

                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    Image();
                }
                else if (option == "2")
                {
                    Console.Clear();
                    Text();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    Sound();
                }
                else if (option == "4")
                {

                    Console.WriteLine("Thank you hope to See you soon");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option PLease try again");
                    Console.ReadLine();
                }


                index++;

                if (index == colours.Length)
                    index = 0; // restart colour cycle

                Console.WriteLine("\nPress ENTER to continue...");
                Console.ReadLine();
                

            }
        }        
        static void Image()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("########## IMAGE CONVERTER ##########");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter Image Width ");
            float width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Image Height ");
            float Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Image Bits per pixel ");
            float BPP = int.Parse(Console.ReadLine());
            float total = width * Height * BPP;
            Console.WriteLine("The total is:" + total + "Bits");

            Console.WriteLine("what unit would you Like to convert it to:");
            Console.WriteLine("1.Bytes");
            Console.WriteLine("2.KB");
            Console.WriteLine("3.MB");
            Console.WriteLine("4.GB");
            Console.WriteLine("5.Remain same");
            string choice = Console.ReadLine();

            while (true)
            {
                if (choice == "1")
                {
                    total = total / 8;
                    Console.WriteLine(total + "Bytes");
                }
                else if (choice == "2")
                {
                    total = total / 8 / 1024;
                    Console.WriteLine(total + "KB");
                }
                else if (choice == "3")
                {
                    total = total / 8 / 1024 / 1024;
                    Console.WriteLine(total + "MB");
                }
                else if (choice == "4")
                {
                    total = total / 8 / 1024 / 1024 / 1024;
                    Console.WriteLine(total + "GB");
                }
                else if (choice == "5")
                {
                    Console.WriteLine("This remains in Bits");
                }
                else
                {
                    Console.WriteLine("Not an option.Try Again");
                }
                Console.ReadLine();
                break;
            }

            
        }     
        static void Text()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("########### TEXT CONVERTER ##########");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Please enter number of characters");
            int chara = int.Parse(Console.ReadLine());
            int tot = chara * 8;
            Console.WriteLine("The total is:" + tot + "Bits");

            Console.WriteLine("what unit would you Like to convert it to:");
            Console.WriteLine("1.Bytes");
            Console.WriteLine("2.KB");
            Console.WriteLine("3.MB");
            Console.WriteLine("4.GB");
            Console.WriteLine("5.Remain same");
            string option = Console.ReadLine();

            while (true)
            {
                if (option == "1")
                {
                    tot = tot / 8;
                    Console.WriteLine(tot + "Bytes");
                }
                else if (option == "2")
                {
                    tot = tot / 8 / 1024;
                    Console.WriteLine(tot + "KB");
                }
                else if (option == "3")
                {
                    tot = tot / 8 / 1024 / 1024;
                    Console.WriteLine(tot + "MB");
                }
                else if (option == "4")
                {
                    tot = tot / 8 / 1024 / 1024 / 1024;
                    Console.WriteLine(tot + "GB");
                }
                else if (option == "5")
                {
                    Console.WriteLine("This remains in Bits");
                }
                else
                {
                    Console.WriteLine("Not an option.Try Again");
                }
                Console.ReadLine();
                break;                
            }          

            
        }
        static void Sound()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("########## SOUND CONVERTER ##########");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("please enter the Bit Rate");
            int bit = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the Duration");
            int dur = int.Parse(Console.ReadLine());
            int tota = bit * dur;
            Console.WriteLine("The sound file size is: " + tota + " bits");
            Console.WriteLine("what unit would you Like to convert it to:");
            Console.WriteLine("1.Bytes");
            Console.WriteLine("2.KB");
            Console.WriteLine("3.MB");
            Console.WriteLine("4.GB");
            Console.WriteLine("5.Remain same");
            string dec = Console.ReadLine();

            while (true)
            {
                if (dec == "1")
                {
                    tota = tota / 8;
                    Console.WriteLine(tota + "Bytes");
                }
                else if (dec == "2")
                {
                    tota = tota / 8 / 1024;
                    Console.WriteLine(tota + "KB");
                }
                else if (dec == "3")
                {
                    tota = tota / 8 / 1024 / 1024;
                    Console.WriteLine(tota + "MB");
                }
                else if (dec == "4")
                {
                    tota = tota / 8 / 1024 / 1024 / 1024;
                    Console.WriteLine(tota + "GB");
                }
                else if (dec == "5")
                {
                    Console.WriteLine("This remains in Bits");
                }
                else
                {
                    Console.WriteLine("Not an option.Try Again");
                }
                Console.ReadLine();
                break;
            }
            
        }
    }
}

