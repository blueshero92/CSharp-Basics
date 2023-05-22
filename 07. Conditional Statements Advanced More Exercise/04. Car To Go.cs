using System;

namespace _04._Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double carPrice = 0;

            string carType = string.Empty;
            string carClass = string.Empty;

            if (budget <= 100)
            {
                carClass = "Economy class";

                if (season == "Summer")
                {
                    carPrice = budget * 0.35;
                    carType = "Cabrio";
                }
                else
                {
                    carPrice = budget * 0.65;
                    carType = "Jeep";
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";

                if (season == "Summer")
                {
                    carPrice = budget * 0.45;
                    carType = "Cabrio";
                }
                else
                {
                    carPrice = budget * 0.80;
                    carType = "Jeep";
                }
            }
            else
            {
                carClass = "Luxury class";
                carPrice = budget * 0.90;
                carType = "Jeep";
            }

            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {carPrice:f2}");

        }
    }
}
