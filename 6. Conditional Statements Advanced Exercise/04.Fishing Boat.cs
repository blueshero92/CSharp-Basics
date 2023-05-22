using System;

namespace _04.Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double boatPrice = 0;

            if (season == "Spring")
            {
                boatPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatPrice = 4200;
            }
            else
            {
                boatPrice = 2600;
            }

            if (fishermen <= 6)
            {
                boatPrice -= boatPrice * 0.10;
            }
            else if (fishermen <= 11)
            {
                boatPrice -= boatPrice * 0.15;
            }
            else
            {
                boatPrice -= boatPrice * 0.25;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                boatPrice -= boatPrice * 0.05;
            }

            if (budget >= boatPrice)
            {
                Console.WriteLine($"Yes! You have {budget - boatPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {boatPrice - budget:f2} leva.");
            }
        }
    }
}
