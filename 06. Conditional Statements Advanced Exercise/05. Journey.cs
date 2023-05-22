using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string vacationType = string.Empty;
            double moneySpent = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    moneySpent += budget * 0.30;
                    vacationType = "Camp";
                }
                else
                {
                    moneySpent += budget * 0.70;
                    vacationType = "Hotel";
                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    moneySpent += budget * 0.40;
                    vacationType = "Camp";
                }
                else
                {
                    moneySpent += budget * 0.80;
                    vacationType = "Hotel";
                }

            }
            else
            {
                destination = "Europe";
                moneySpent += budget * 0.90;
                vacationType = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacationType} - {moneySpent:f2}");
        }
    }
}
