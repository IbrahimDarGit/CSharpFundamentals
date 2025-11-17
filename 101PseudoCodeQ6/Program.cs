using System;

class Program
{
    static void Main()
    {
        int N = 6;
        int P = 0;

        Console.WriteLine("N  P  X  Y  F");

        for (int X = 2; X <= N; X++)
        {
            int F = 0;

            for (int Y = 2; Y <= 3; Y++)
            {

                Console.WriteLine(N + "  " + P + "  " + X + "  " + Y + "  " + F);

                if ((X % Y == 0) && (X != Y))
                {
                    F = F + 1;
                }
            }

            if (F == 0)
            {
                P = P + 1;
            }


            Console.WriteLine(N + "  " + P + "  " + X + "  -  " + F);
        }
    }
}
