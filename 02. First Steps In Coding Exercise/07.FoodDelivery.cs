using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veggieMenus = int.Parse(Console.ReadLine());

            double chickenPrice = chickenMenus * 10.35;
            double fishPrice = fishMenus * 12.40;
            double veggiePrice = veggieMenus * 8.15;
            double dessertPrice = (chickenPrice + fishPrice + veggiePrice) * 0.2;

            double totalSum = chickenPrice + fishPrice + veggiePrice + dessertPrice + 2.50;

            Console.WriteLine(totalSum);
        }
    }
}
