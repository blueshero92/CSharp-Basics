using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaning = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine()) / 100;

            double penPacks = pens * 5.80;
            double markerPacks = markers * 7.20;
            double cleaningPack = cleaning * 1.20;

            double sum = penPacks + markerPacks + cleaningPack;
            double discountedSum = sum - (sum*discount); 

            Console.WriteLine(discountedSum);

        }
    }
}
