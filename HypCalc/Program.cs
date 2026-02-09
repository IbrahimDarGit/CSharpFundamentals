using System;
namespace Hypothesis
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("====  HYPOTHESIS TEST CALCULATOR  ====");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("please choose one of following options:");
                Console.WriteLine("1.Program Explaination ");
                Console.WriteLine("2.Spearemans rank ");
                Console.WriteLine("3.Exit the program ");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    Console.WriteLine("In Progress");
                    Console.WriteLine("Calculator made by Ibrahim Dar");
                    Console.ReadLine();
                }
                else if (option == "2")
                {
                    SR();
                }
                else if (option == "3")
                {
                    Console.WriteLine("Thank you for using the calculator");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                    Console.ReadLine();
                }
            }
        }

        static void SR()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("====  HYPOTHESIS TEST CALCULATOR  ====");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("please choose one of following options:");
            Console.WriteLine("1.Spearemans rank ");
            Console.WriteLine("2.Spearemans rank Hypothesis test");

            string optio = Console.ReadLine();

            if (optio == "1")
            {
                Console.Clear();
                rank();
            }
            else if (optio == "2")
            {
                Console.Clear();
                hyp();
            }
            else
            {
                Console.WriteLine("Invalid option please try again");
                Console.ReadLine();
            }
        }

        static void rank()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("==== SPEARMAN'S RANK CALCULATOR ====");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Formulas is rs = 1 - (6 * D) / (n * (n * n - 1))");
            Console.WriteLine("Please enter the sum of D^2 value");
            double D = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter N value");
            double n = double.Parse(Console.ReadLine());

            double rs = 1 - (6 * D) / (n * (n * n - 1));

            string correlation = "";

            if (rs > 1 || rs < -1)
            {
                Console.WriteLine("Error please recheck your values");
                Console.ReadLine();
                return;
            }
            else if (rs == 1)
                correlation = "Perfect positive correlation";
            else if (rs == -1)
                correlation = "Perfect negative correlation";
            else if (rs == 0)
                correlation = "No correlation";
            else if (rs > 0 && rs < 0.3)
                correlation = "Weak positive correlation";
            else if (rs < 0 && rs > -0.3)
                correlation = "Weak negative correlation";
            else if (rs >= 0.3 && rs < 0.7)
                correlation = "Moderate positive correlation";
            else if (rs <= -0.3 && rs > -0.7)
                correlation = "Moderate negative correlation";
            else if (rs >= 0.7 && rs < 0.9)
                correlation = "Strong positive correlation";
            else if (rs >= 0.9 && rs < 1)
                correlation = "Very strong positive correlation";
            else if (rs <= -0.9 && rs > -1)
                correlation = "Very strong negative correlation";

            Console.WriteLine();
            Console.WriteLine("Your rs value is: " + rs);
            Console.WriteLine("Your correlation is: " + correlation);

            Console.WriteLine();
            Console.WriteLine("Press ENTER to return to menu...");
            Console.ReadLine();
        }

        static void hyp()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("==== SPEARMAN'S HYP CALCULATOR ====");
            Console.WriteLine("-----------------------------------");


            Console.WriteLine("What Your First Variable name:");
            string var1 = Console.ReadLine();
            Console.WriteLine("What Your Second Variable name:");
            string var2 = Console.ReadLine();
            Console.WriteLine("H0: There is no correlation between " + var1 + " and " + var2);
            Console.WriteLine("Is there a positive or negative correlation or Any correlation?");
            string corr = Console.ReadLine().ToLower();
            if (corr == "positive")
            {
                Console.WriteLine("H1: There is a positive correlation between " + var1 + " and " + var2);
                Console.WriteLine("One tailed test");
            }
            else if (corr == "negative")
            {
                Console.WriteLine("H1: There is a negative correlation between " + var1 + " and " + var2);
                Console.WriteLine("One tailed test");
            }
            else if (corr == "any")
            {
                Console.WriteLine("H1: There is a correlation between " + var1 + " and " + var2);
                Console.WriteLine("Two tailed test");
            }
            else
            {
                Console.WriteLine("Invalid option please try again");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("What is your rs value:");
            double rs = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your n value:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your significance level (Percentage) :");
            int sig = int.Parse(Console.ReadLine());
            Console.WriteLine("Is this a One or Two tailed test:");
            string tailed = Console.ReadLine().ToLower();
            if (tailed == "one")
            {
                Console.WriteLine("One tailed test selected");
                one(sig,n,rs);
            }
            else if (tailed == "two")
            {
                Console.WriteLine("Two tailed test selected");
                two(sig,n,rs);
            }
            else
            {
                Console.WriteLine("Invalid option please try again");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
        static void one(int sig, int n, double rs)
        {
            double[,] spearmanCritical =
            {
                {1.0000, 1.0000, 1.0000, 1.0000, 1.0000}, // n = 4
                {0.7000, 0.9000, 0.9000, 1.0000, 1.0000}, // n = 5
                {0.6571, 0.7714, 0.8286, 0.9429, 0.9429}, // n = 6
                {0.5714, 0.6786, 0.7857, 0.8571, 0.8929}, // n = 7
                {0.5476, 0.6429, 0.7381, 0.8095, 0.8571}, // n = 8
                {0.4833, 0.6000, 0.6833, 0.7667, 0.8167}, // n = 9
                {0.4424, 0.5636, 0.6485, 0.7333, 0.7818}, // n = 10
                {0.4182, 0.5273, 0.6091, 0.7000, 0.7545}, // n = 11
                {0.3986, 0.5035, 0.5874, 0.6713, 0.7273}, // n = 12
                {0.3791, 0.4780, 0.5604, 0.6484, 0.6978}, // n = 13
                {0.3670, 0.4593, 0.5385, 0.6220, 0.6747}, // n = 14
                {0.3500, 0.4429, 0.5179, 0.6000, 0.6536}, // n = 15
                {0.3382, 0.4265, 0.5029, 0.5824, 0.6324}, // n = 16
                {0.3271, 0.4124, 0.4821, 0.5577, 0.6055}, // n = 17
                {0.3170, 0.4000, 0.4683, 0.5425, 0.5897}, // n = 18
                {0.3077, 0.3887, 0.4555, 0.5285, 0.5751}, // n = 19
                {0.2992, 0.3783, 0.4438, 0.5155, 0.5614}  // n = 20
            };

                    int row = n - 4;
                    int col = 0;

                    if (sig == 10) col = 0;
                    else if (sig == 5) col = 1;
                    else if (sig == 2) col = 2;
                    else if (sig == 1) col = 3;
                    else if (sig == 0) col = 4;

                    double critical = spearmanCritical[row, col];

            if (rs >= critical || rs <= -critical)
            {
                Console.WriteLine("Reject H0");
            }
            else
            {
                Console.WriteLine("Don't reject H0");
            }
            Console.ReadLine();

        }

        static void two(int sig, int n, double rs)
        {
            double[,] spearmanCriticalv =
            {
                // 10%     5%      2.5%    1%      0.5%
                {1.0000, 1.0000, 1.0000, 1.0000, 1.0000}, // n = 4
                {0.7000, 0.9000, 0.9000, 1.0000, 1.0000}, // n = 5
                {0.6571, 0.7714, 0.8286, 0.9429, 0.9429}, // n = 6
                {0.5714, 0.6786, 0.7857, 0.8571, 0.8929}, // n = 7
                {0.5476, 0.6429, 0.7381, 0.8095, 0.8571}, // n = 8
                {0.4833, 0.6000, 0.6833, 0.7667, 0.8167}, // n = 9
                {0.4424, 0.5636, 0.6485, 0.7333, 0.7818}, // n = 10
                {0.4182, 0.5273, 0.6091, 0.7000, 0.7545}, // n = 11
                {0.3986, 0.5035, 0.5874, 0.6713, 0.7273}, // n = 12
                {0.3791, 0.4780, 0.5604, 0.6484, 0.6978}, // n = 13
                {0.3670, 0.4593, 0.5385, 0.6220, 0.6747}, // n = 14
                {0.3500, 0.4429, 0.5179, 0.6000, 0.6536}, // n = 15
                {0.3382, 0.4265, 0.5029, 0.5824, 0.6324}, // n = 16
                {0.3271, 0.4124, 0.4821, 0.5577, 0.6055}, // n = 17
                {0.3170, 0.4000, 0.4683, 0.5425, 0.5897}, // n = 18
                {0.3077, 0.3887, 0.4555, 0.5285, 0.5751}, // n = 19
                {0.2992, 0.3783, 0.4438, 0.5155, 0.5614}  // n = 20
            };


            int row = n - 4;
            
            int col = 0;

            if (sig == 10) col = 0;
            else if (sig == 5) col = 1;
            else if (sig == 2) col = 2;
            else if (sig == 1) col = 3;
            else if (sig == 0) col = 4;

            double critical = spearmanCriticalv[row, col];

            if (rs >= critical || rs <= -critical)
            {
                Console.WriteLine("Reject H0");
            }
            else
            {
                Console.WriteLine("Don't reject H0");
            }
            Console.ReadLine();


        }

    }
}



