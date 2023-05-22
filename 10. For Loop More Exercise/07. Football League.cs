using System;

namespace _07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int totalFans = int.Parse(Console.ReadLine());

            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;


            for (int fan = 1; fan <= totalFans; fan++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else
                {
                    sectorG++;
                }
            }

            double averagePercent = (double)totalFans / capacity * 100;

            Console.WriteLine($"{(double)sectorA/totalFans*100:f2}%");
            Console.WriteLine($"{(double)sectorB / totalFans * 100:f2}%");
            Console.WriteLine($"{(double)sectorV / totalFans * 100:f2}%");
            Console.WriteLine($"{(double)sectorG / totalFans * 100:f2}%");
            Console.WriteLine($"{averagePercent:f2}%");

        }
    }
}
