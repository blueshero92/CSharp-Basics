using System;

namespace _02.Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string period = Console.ReadLine();

            string outfit = string.Empty;
            string shoes = string.Empty;

            if (period == "Morning")
            {
                if (degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (period == "Afternoon")
            {
                if (degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degrees > 24)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else 
            {   
                    outfit = "Shirt";
                    shoes = "Moccasins";   
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

        }
    }
}
