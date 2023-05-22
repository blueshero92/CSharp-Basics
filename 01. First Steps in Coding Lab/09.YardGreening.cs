using System;
using System.Net.WebSockets;
using System.Reflection.Metadata;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());

            double price = size * 7.61;
            double discount = price * 0.18;

            Console.WriteLine($"The final price is:  {price-discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv");

        }
    }
}
