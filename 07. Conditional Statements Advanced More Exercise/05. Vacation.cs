using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;

            string location = string.Empty;
            string restType = string.Empty;

            if (budget <= 1000)
            {
                restType = "Camp";

                if(season == "Summer")
                {
                    price = budget * 0.65;
                    location = "Alaska";
                }
                else
                {
                    price = budget * 0.45;
                    location = "Morocco";
                }
            }
            
            else if (budget <= 3000)
            {
                restType = "Hut";

                if (season == "Summer")
                {
                    price = budget * 0.80;
                    location = "Alaska";
                }
                else
                {
                    price = budget * 0.60;
                    location = "Morocco";
                }
            }
            else
            {
                restType = "Hotel";
                price = budget * 0.90;

                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else
                {
                    location = "Morocco";
                }
            }

            Console.WriteLine($"{location} - {restType} - {price:f2}");
        }
    }
}
