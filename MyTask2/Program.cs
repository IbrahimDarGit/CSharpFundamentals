using System;

namespace MyTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pseudocode to be translated:
            // string[]Names  new string[5];
            // Names[1] ← ‘Ben’
            // Names[2] ← ‘Thor’
            // Names[3] ← ‘Zoe’
            // Names[4] ← ‘Kate’
            // Max ← 4         
            // Current ← 1
            // Found ← False
            // OUTPUT ‘What player are you looking for?’
            // INPUT PlayerName
            // WHILE (Found = False) AND (Current &lt;= Max)
            //   IF Names[Current] == PlayerName
            //     THEN Found ← True
            //     ELSE Current ← Current + 1
            //   ENDIF
            // ENDWHILE
            // IF Found == True
            //   THEN OUTPUT ‘Yes, they have a top score’
            //   ELSE OUTPUT ‘No, they do not have a top score’
            // ENDIF

            // Translated C# code:
            string[] Names = new string[5];
            Names[1] = "Ben";
            Names[2] = "Thor";
            Names[3] = "Zoe";
            Names[4] = "Kate";
            int Max = 4;
            int Current = 1;
            bool Found = false;
            Console.Write("What player name are you looking for? out of 4 top scores: ");
            string PlayerName = Console.ReadLine();
            while (Found == false && Current <= Max)
            {
                if (Names[Current] == PlayerName)
                {
                    Found = true;
                }
                else
                {
                    Current = Current + 1;
                }
            }
            if (Found == true)
            {
                Console.WriteLine("Yes, they have a top score");
            }
            else
            {
                Console.WriteLine("No, they do not have a top score");
            }
        }
    }
}
