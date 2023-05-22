using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double totalIncome = 0;

            if (type == "Premiere")
            {
                totalIncome = rows * columns * 12.00;
            }
            else if (type == "Normal")
            {
                totalIncome = rows * columns * 7.50;
            }
            else
            {
                totalIncome = rows * columns * 5.00;
            }

            Console.WriteLine($"{totalIncome:f2} leva");
        }
    }
}
