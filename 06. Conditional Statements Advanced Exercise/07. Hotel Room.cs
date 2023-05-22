using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
            }
            else
            {
                studioPrice = 76;
                apartmentPrice = 77;
            }

            double studioPriceTotal = studioPrice * nightCount;
            double apartmentPriceTotal = apartmentPrice * nightCount;

            if ((nightCount > 7 && nightCount <= 14) && (month == "May" || month == "October"))
            {
                studioPriceTotal -= studioPriceTotal * 0.05;
            }
            else if (nightCount > 14 && (month == "May" || month == "October"))
            {
                studioPriceTotal -= studioPriceTotal * 0.30;
            }
            else if (nightCount > 14 && (month == "June" || month == "September"))
            {
                studioPriceTotal -= studioPriceTotal * 0.20;
            }
            if (nightCount > 14)
            {
                apartmentPriceTotal -= apartmentPriceTotal * 0.10;
            }

            Console.WriteLine($"Apartment: {apartmentPriceTotal:f2} lv.");
            Console.WriteLine($"Studio: {studioPriceTotal:f2} lv.");

        }
    }
}
