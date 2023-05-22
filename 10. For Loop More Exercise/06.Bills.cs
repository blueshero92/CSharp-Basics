using System;

namespace _06.Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double totalElectricity = 0;
            double totalWater = 0;
            double totalNet = 0;
            double others = 0;

            for (int month = 1; month <= months; month++)
            {
                double electricityBill = double.Parse(Console.ReadLine());

                totalElectricity += electricityBill;
               
            }

            totalWater += months * 20;
            totalNet += months * 15;
            others += totalElectricity + totalWater + totalNet;

            double totalOthers = others + (others * 0.20);
            double averageBill = (totalElectricity + totalWater + totalNet + totalOthers) / months;

            Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalNet:f2} lv");
            Console.WriteLine($"Other: {totalOthers:f2} lv");
            Console.WriteLine($"Average: {averageBill:f2} lv");
        }
    }
}
