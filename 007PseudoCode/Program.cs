using System;

namespace _007PseudoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of simple pseudocode translated to C#

            /*
               ThePseudocode I was given:
               INPUT number
               IF number > 0 THEN
                    OUTPUT "Positive"
               ELSE
                    OUTPUT "Negative or Zero"
               ENDIF
            */
            // Translated C# code:
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("Negative or Zero");
        }
    }
}
