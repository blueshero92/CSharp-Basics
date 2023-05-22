using System;

namespace _05.Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double budget = 0;

            string destination;
            
            while(input != "End")
            {
                destination = input;
                budget = double.Parse(Console.ReadLine());

                while(budget > 0)
                {
                    double savings = double.Parse(Console.ReadLine());
                    budget -= savings;                                                   
                }
                Console.WriteLine($"Going to {destination}!");

                input= Console.ReadLine();
            }
        }
    }
}
