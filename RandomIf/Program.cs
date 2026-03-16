using System;
import random;

namespace RandomIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int roll = rand.Next(1, 7);
            int roll2 = rand.Next(1, 7);
            int roll3 = rand.Next(1, 7);

            int sum = roll + roll2 + roll3;

            Console.WriteLine("You rolled a " + roll + ", a " + roll2 + ", and a " + roll3 + ".");
            Console.WriteLine("The sum of your rolls is " + sum + ".");
            
            if (roll == roll2 && roll2 == roll3)
            {
                Console.WriteLine("You rolled three of a kind! congrats!");
            }
            else if (roll == roll2 || roll == roll3 || roll2 == roll3)
            {
                Console.WriteLine("You rolled a pair! not bad!");
            }
            else
            {
                Console.WriteLine("You rolled all different numbers. better luck next time!");
            }
            
            if (sum <= 10)
            {
                Console.WriteLine("You rolled a " + sum + ". You lose.");
            }
            else
            {
                Console.WriteLine("You rolled a " + sum + ". You win!");
            }

        }
    }
}
