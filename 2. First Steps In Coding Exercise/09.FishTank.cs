using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) / 100;

            double volumeCm = lenght * widht * height;
            double volumeLiters = volumeCm / 1000;
            double litersNeeded = volumeLiters * (1 - percent);

            Console.WriteLine(litersNeeded);

        }
    }
}
