using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the method.
        // It will run a block of code but return nothing.
        SayHello();

        Console.ReadLine(); // Keep window open.
    }

    // This method has:
    // - NO input
    // - NO return value (void)
    // It only prints text.
    static void SayHello()
    {
        Console.WriteLine("Hello! This method takes no data and returns nothing.");
    }
}
