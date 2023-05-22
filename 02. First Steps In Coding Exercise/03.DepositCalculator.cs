using System;
using System.Diagnostics.CodeAnalysis;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double interestPerYear = double.Parse(Console.ReadLine())/100;



            Console.WriteLine(depositSum + term * ((depositSum * interestPerYear)) / 12);

           

            
        }
    }
}
