using System;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char celebDay = char.Parse(Console.ReadLine());

            int totalFlowers = chrysanthemums + roses + tulips;

            double chrysanthemumPrice = 0;
            double rosePrice = 0;
            double tulipPrice = 0;

            if (season == "Spring" || season == "Summer")
            {
                chrysanthemumPrice = 2.00;
                rosePrice = 4.10;
                tulipPrice = 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrysanthemumPrice = 3.75;
                rosePrice = 4.50;
                tulipPrice = 4.15;
            }

            double totalPrice = chrysanthemumPrice * chrysanthemums + rosePrice * roses + tulipPrice * tulips;

            if (celebDay == 'Y')
            {
                totalPrice += totalPrice * 0.15;
            }

            if (season == "Spring")
            {
                if (tulips > 7)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }
            if (season == "Winter")
            {
                if (roses >= 10)
                {
                    totalPrice -= totalPrice * 0.10;
                }
            }
            if (totalFlowers > 20)
            {
                totalPrice -= totalPrice * 0.20;
            }

            Console.WriteLine($"{totalPrice + 2:f2}");


        }
    }
}
