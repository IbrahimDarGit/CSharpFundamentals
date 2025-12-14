using System;

namespace _101PseudoCodeBSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 3, 7, 8, 9, 27, 35, 45, 55};
            int ItemToFind = 27;

            int f = 0;
            int l = 7;
            int m = 0;
            bool found = false;
            bool failed = false;

            while (!found && !failed)
            {
 
                m=(f + l) / 2;
 Console.WriteLine("f=" + f + " , l=" + l + " , ItemToFind=" + ItemToFind + " , found=" + found + " , failed=" + failed + " , m=" + m);               
                if (list[m] == ItemToFind)
                {
                    found = true;
                }
                else if (f >= l)
                {
                    failed = true;
                }
                else
                {
                    if (list[m] > ItemToFind)
                    {
                        l = m - 1;
                    }
                    else
                    {
                        f = m + 1;
                    }
                }
           
            }   

 Console.WriteLine("f=" + f + " , l=" + l + " , ItemToFind=" + ItemToFind + " , found=" + found + " , failed=" + failed + " , m=" + m);                  
        }
    }
}
