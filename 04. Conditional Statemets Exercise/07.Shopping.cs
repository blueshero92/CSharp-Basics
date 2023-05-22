using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpus = int.Parse(Console.ReadLine());
            int cpus = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double gpuPrice = 250;
            double cpuPrice = gpuPrice*gpus * 0.35;
            double ramPrice = gpuPrice*gpus * 0.10;

            double totalSum = gpus*gpuPrice + cpus*cpuPrice + ram*ramPrice;

            if (gpus > cpus)
            {
                totalSum = totalSum - totalSum * 0.15;
            }
            if (budget >= totalSum)
            {
                Console.WriteLine($"You have {budget - totalSum:f2} leva left!");

            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budget:f2} leva more!");
            }
        }
    }
}
