using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double transportPrice = 0;

            if (ticketType == "VIP")
            {
                ticketPrice = 499.99;
            }
            else
            {
                ticketPrice = 249.99;
            }

            if (people <= 4)
            {
                transportPrice += budget * 0.75;
            }
            else if (people <= 9)
            {
                transportPrice += budget * 0.60;
            }
            else if (people <= 24)
            {
                transportPrice += budget * 0.50;
            }
            else if (people <= 49)
            {
                transportPrice += budget * 0.40;
            }
            else
            {
                transportPrice += budget * 0.25;
            }

            double totalPrice = people * ticketPrice + transportPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }
        }
    }
}
