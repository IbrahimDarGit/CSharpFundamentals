using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user to type something.
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Give that name to the method.
        GreetUser(name);

        Console.ReadLine();
    }

    // This method TAKES data (a string)
    // but does NOT return anything.
    static void GreetUser(string username)
    {
        Console.WriteLine("Hello " + username + "! Welcome!");
    }
}

