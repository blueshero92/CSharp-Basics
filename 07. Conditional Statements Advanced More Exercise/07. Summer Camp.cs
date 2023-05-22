using System;

namespace _07._Summer_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;
            string sport = string.Empty;

            if (season == "Winter")
            {
                if (groupType == "girls")
                {
                    pricePerNight = 9.60;
                    sport = "Gymnastics";
                }
                else if (groupType == "boys")
                {
                    pricePerNight = 9.60;
                    sport = "Judo";
                }
                else
                {
                    pricePerNight = 10;
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (groupType == "girls")
                {
                    pricePerNight = 7.20;
                    sport = "Athletics";
                }
                else if (groupType == "boys")
                {
                    pricePerNight = 7.20;
                    sport = "Tennis";
                }
                else
                {
                    pricePerNight = 9.50;
                    sport = "Cycling";
                }
            }
            else
            {
                if (groupType == "girls")
                {
                    pricePerNight = 15;
                    sport = "Volleyball";
                }
                else if (groupType == "boys")
                {
                    pricePerNight = 15;
                    sport = "Football";
                }
                else
                {
                    pricePerNight = 20;
                    sport = "Swimming";
                }
            }

            double totalPrice = pricePerNight * studentsCount * nights;
            
            if (studentsCount >= 50)
            {
                totalPrice -= totalPrice * 0.50;
            }
            else if (studentsCount >= 20)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (studentsCount >= 10)
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"{sport} {totalPrice:f2} lv.");
        }
    }
}
