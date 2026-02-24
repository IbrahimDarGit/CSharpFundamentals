using System;

namespace ReverseW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase:");
            string input = Console.ReadLine();

            string currentWord = "";
            string result = "";
            Random rand = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    currentWord = currentWord + input[i];
                }
                else
                {
                    result = result + ScrambleWord(currentWord, rand) + " ";
                    currentWord = "";
                }
            }

            result = result + ScrambleWord(currentWord, rand);

            Console.WriteLine();
            Console.WriteLine("Scrambled:");
            Console.WriteLine(result);
        }
        static string ScrambleWord(string word, Random rand)
        {
            if (word.Length <= 2)
            {
                return word;
            }

            string first = word.Substring(0, 1);
            string middle = word.Substring(1, word.Length - 2);
            string last = word.Substring(word.Length - 1, 1);

            string scrambledMiddle = "";

            while (middle.Length > 0)
            {
                int index = rand.Next(middle.Length);

                scrambledMiddle = scrambledMiddle + middle[index];

                middle = middle.Remove(index, 1);
            }

            return first + scrambledMiddle + last;
        }
    }
}
