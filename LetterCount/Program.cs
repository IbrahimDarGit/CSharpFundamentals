using System;

namespace LetterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();

            int[] frequency = new int[256];

            for (int i = 0; i < sentence.Length; i++)
            {
                char c = sentence[i];
                frequency[c]++;
            }

            for (int i = 0; i < 256; i++)
            {
                if (frequency[i] > 0)
                {
                    if ((char)i == ' ')
                    {
                        Console.WriteLine("<> - " + frequency[i]);
                    }
                    else
                    {
                        Console.WriteLine((char)i + " - " + frequency[i]);
                    }
                }
            }
        }
    }
}