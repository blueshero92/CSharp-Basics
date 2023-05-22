using System;

namespace _06._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double payPerKm = 0;

            if (kmPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    payPerKm = 0.75;
                }
                else if (season == "Summer")
                {
                    payPerKm = 0.90;
                }
                else
                {
                    payPerKm = 1.05;
                }
            }
            else if (kmPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    payPerKm = 0.95;
                }
                else if (season == "Summer")
                {
                    payPerKm = 1.10;
                }
                else
                {
                    payPerKm = 1.25;
                }
            }
            else if (kmPerMonth <= 20000)
            {
                payPerKm = 1.45;
            }

            double salary = (kmPerMonth * payPerKm) * 4;
            double taxes = salary * 0.10;
            double netSalary = salary - taxes;

            Console.WriteLine($"{netSalary:f2}");
        }
    }
}
