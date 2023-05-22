using System;

namespace _09.Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();

            int nights = days - 1;

            double roomPricePerNight = 0;

            if (roomType == "room for one person")
            {
                roomPricePerNight = 18;
            }
            else if (roomType == "apartment")
            {
                roomPricePerNight = 25;
            }
            else
            {
                roomPricePerNight = 35;
            }

            double totalPrice = roomPricePerNight * nights;

            if (roomType == "apartment")
            {
                if (days < 10)
                {
                    totalPrice -= totalPrice * 0.30;
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice -= totalPrice * 0.35;
                }
                else
                {
                    totalPrice -= totalPrice * 0.50;
                }
            }
            if (roomType == "president apartment")
            {
                if (days < 10)
                {
                    totalPrice -= totalPrice * 0.10;
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice -= totalPrice * 0.15;
                }
                else
                {
                    totalPrice -= totalPrice * 0.20;
                }

            }

            if (grade == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else
            {
                totalPrice -= totalPrice * 0.10;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
