using System;

namespace _101PseudoCodeBSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 3, 7, 8, 9, 27, 35, 45, 55 };
            int itemToFind = 27;

            RunBinarySearch(list, itemToFind);   // <- one clear line

            Console.ReadLine();
        }

        static void RunBinarySearch(int[] list, int itemToFind)
        {
            int f = 0;
            int l = list.Length - 1;   // better: use length instead of hard-coded 7
            int m = 0;
            bool found = false;
            bool failed = false;

            while (!found && !failed)
            {
                m = (f + l) / 2;

                Console.WriteLine("f=" + f +
                                  " , l=" + l +
                                  " , ItemToFind=" + itemToFind +
                                  " , found=" + found +
                                  " , failed=" + failed +
                                  " , m=" + m);

                if (list[m] == itemToFind)
                {
                    found = true;
                }
                else if (f >= l)
                {
                    failed = true;
                }
                else
                {
                    if (list[m] > itemToFind)
                        l = m - 1;
                    else
                        f = m + 1;
                }
            }

            Console.WriteLine("f=" + f +
                              " , l=" + l +
                              " , ItemToFind=" + itemToFind +
                              " , found=" + found +
                              " , failed=" + failed +
                              " , m=" + m);
        }
    }
}

