using System;

namespace _04.Smart_Lilly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int moneySaved = 0;

            for (int currentAge = 1; currentAge <= age; currentAge++)
            {
                if (currentAge % 2 == 0)
                {
                    moneySaved += currentAge * 5 - 1;
                }
                else
                {
                    moneySaved += toyPrice;
                }
            }

            if (moneySaved >= washingMachine)
            {
                Console.WriteLine($"Yes! {moneySaved - washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - moneySaved:f2}");
            }
        }
    }
}
