using System;

namespace _01.Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int lastYear = int.Parse(Console.ReadLine());

            int age = 18;
           

            for (int year = 1800; year <= lastYear; year++)
            {

                if (year % 2 == 0)
                {
                    heritage -= 12000;
                }
                else
                {
                    heritage -= (12000 + (50 * age));
                }

                age++;
            }
            if (heritage >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritage:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(heritage):f2} dollars to survive.");
            }
        }
    }
}
