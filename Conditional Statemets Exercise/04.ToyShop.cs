using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());    
            int dolls = int.Parse(Console.ReadLine());  
            int bears = int.Parse(Console.ReadLine());  
            int minions = int.Parse(Console.ReadLine());    
            int trucks = int.Parse(Console.ReadLine());

            int toys = puzzles + dolls + bears + minions + trucks;

            double sum = puzzles * 2.60 + dolls * 3.00 + bears * 4.10 + minions * 8.20 + trucks * 2.00;
            

            if (toys >= 50)
            {
                sum = sum - sum * 0.25;
            }
            

            double rent = sum * 0.10;
            double totalSum = sum - rent;

            if (totalSum >=tripPrice) 
            {
                Console.WriteLine($"Yes! {totalSum-tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine ($"Not enough money! {Math.Abs(totalSum-tripPrice):f2} lv needed.");
            }
        }
    }
}
