using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            int totalBikers = juniors + seniors;

            double juniorTax = 0;
            double seniorTax = 0;

            switch (trace)
            {
                case "trail":
                    juniorTax = 5.50;
                    seniorTax = 7;
                    break;
                case "cross-country":
                    juniorTax = 8;
                    seniorTax = 9.50;
                    break;
                case "downhill":
                    juniorTax = 12.25;
                    seniorTax = 13.75;
                    break;
                case "road":
                    juniorTax = 20;
                    seniorTax = 21.50;
                    break;
            }

            double totalTax = juniors * juniorTax + seniors * seniorTax;
            double expenses = totalTax * 0.05;

            double finalTax = totalTax - expenses;

            if (trace == "cross-country" && totalBikers >= 50 )
            {
                finalTax -= finalTax * 0.25;
            }

            Console.WriteLine($"{finalTax:f2}");


        }
    }
}
