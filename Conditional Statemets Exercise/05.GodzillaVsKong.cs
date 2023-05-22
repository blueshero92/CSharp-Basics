using System;

namespace _05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double outfitPrice = double.Parse(Console.ReadLine());

            double scenery = budget * 0.10;

            if (extras > 150)
            {
                outfitPrice = outfitPrice - outfitPrice * 0.10;
            }
            double totalPrice = extras * outfitPrice + scenery;

            if (totalPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalPrice:f2} leva left.");
            }
               
        }
    }
    
 }
