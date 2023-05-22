using System;

namespace _03.New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double flowerPrice = 0;

            if (flowers == "Roses")
            {
                flowerPrice = 5;
            }
            else if (flowers == "Dahlias")
            {
                flowerPrice = 3.80;
            }
            else if (flowers == "Tulips")
            {
                flowerPrice = 2.80;
            }
            else if (flowers == "Narcissus")
            {
                flowerPrice = 3;
            }
            else if (flowers == "Gladiolus")
            {
                flowerPrice = 2.50;
            }

            double totalPrice = flowerPrice * flowerCount;

            if (flowers == "Roses" && flowerCount > 80)
            {
                totalPrice -= totalPrice * 0.10;
            }
            else if ((flowers == "Dahlias" && flowerCount > 90) || (flowers == "Tulips" && flowerCount > 80))
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (flowers == "Narcissus" && flowerCount < 120)
            {
                totalPrice += totalPrice * 0.15;
            }
            else if (flowers == "Gladiolus" && flowerCount < 80)
            {
                totalPrice += totalPrice * 0.20;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowers} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }
    }
}
