using System;

namespace _102FootballExt
{
    class Program
    {
        static int cost = 0;

        static string name = "";
        static string team = "";
        static string opponent = "";
        static void Main(string[] args)
        {
            RunFootballExtension();
            cost = CalculateCost();
            Console.WriteLine("The total cost of attending the football game is: $" + cost);
            Console.WriteLine("Do you have enough money to pay for the ticket? (yes/no)");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                Console.WriteLine("Great! Enjoy the game!");
            }
            else
            {
                Console.WriteLine("Sorry, you cannot attend the game without enough funds.");
            }

            Console.WriteLine(); 
            ticket(name, team, opponent);

            Console.ReadLine();
            
            
        }
        static void RunFootballExtension()
        {
            
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! Welcome to Football.");
            Console.WriteLine("Please enter your favorite football team:");
            team = Console.ReadLine();
            if (team.ToLower() == "liverpool" || team.ToLower() == "city" || team.ToLower() == "united")
            {
                Console.WriteLine("Great choice! They have a strong legacy.");
            }
            else
            {
                Console.WriteLine(team + " is a good team too!");
            }
            Console.WriteLine("what team is your team playing against?");
            opponent = Console.ReadLine();
            if (opponent.ToLower() == "chelsea" || opponent.ToLower() == "arsenal" || opponent.ToLower() == "spurs")
            {
                cost += 50;
                Console.WriteLine(team +"vs"+ opponent);
                Console.WriteLine("Tough match ahead!");
                
            }
            else
            {
                cost += 30;
                Console.WriteLine(team +"vs"+ opponent);
                Console.WriteLine("Should be an interesting game!");
                
            }

        }  
        static int CalculateCost()
        {
            // This method can be expanded for more complex cost calculations in the future   
            int baseCost = 20;
            return baseCost + cost;
        } 
        static void ticket(string name, string team, string opponent)
        {

            Console.WriteLine("====== TICKET PURCHASED ======");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Game to see: " + team + " VS " + opponent);
            Console.WriteLine("Cost: $" + cost);
            Console.WriteLine("Time of purchase: " + DateTime.Now);  
            Console.WriteLine("=================================");

        }      
    }
}
