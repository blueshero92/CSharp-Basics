using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());

            double sneakers = taxPerYear - taxPerYear * 0.4;
            double outfit = sneakers - sneakers * 0.2;
            double ball = outfit / 4;
            double accesories = ball / 5;

            double totalSum = taxPerYear + sneakers + outfit + ball + accesories;

            Console.WriteLine(totalSum);
        }
    }
}
