using System;

namespace _021ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Rowena", "Robin", "Bao" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
