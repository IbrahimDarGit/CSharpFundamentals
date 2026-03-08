using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascending
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int n = 2; n < 1000000; n++)
            {
                bool prime = true;

                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    string s = n.ToString();
                    bool ascending = true;

                    for (int i = 1; i < s.Length; i++)
                    {
                        if (s[i] <= s[i - 1])
                        {
                            ascending = false;
                            break;
                        }
                    }

                    if (ascending)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Count: {0}", count);
        }
    }
}
