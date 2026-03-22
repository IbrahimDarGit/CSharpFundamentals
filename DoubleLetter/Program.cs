using System;

namespace DoubleLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word:");
            string input = Console.ReadLine();
            Console.WriteLine("You entered: " + input);
            int count = 0;
            string doubleLetters = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    count++;
                    doubleLetters += input[i];
                }
            }
            if (count > 0)
            {
                Console.WriteLine("The word contains " + count + " double letters: " + doubleLetters);
            }
            else if (count > 1)
            {
                Console.WriteLine("The word contains more than one double letter.");
                Console.WriteLine("The double letters are: " + doubleLetters);
            }
            else
            {
                Console.WriteLine("The word does not contain any double letters.");
            }
        }
    }
}
