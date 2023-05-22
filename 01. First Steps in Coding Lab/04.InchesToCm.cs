using System;

namespace _04.InchesToCm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double cm = 2.54;

            double converted = inch * cm;
            Console.WriteLine(converted);
        }
    }
}
