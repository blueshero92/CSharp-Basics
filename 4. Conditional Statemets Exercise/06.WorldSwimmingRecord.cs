using System;
using System.Xml.Schema;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double timeIvan = time * distance;
            double slowdown = Math.Floor(distance / 15) * 12.5;
            double totalTime = timeIvan + slowdown;

            if (totalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(worldRecord - totalTime):f2} seconds slower.");
            }
        }
    }
}
