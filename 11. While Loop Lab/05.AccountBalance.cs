using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input;
            double totalSum = 0;

            while ((input = Console.ReadLine()) != "NoMoreMoney") 
            {
               double depositSum = double.Parse(input);
                
                if(depositSum >= 0)
                {
                   Console.WriteLine($"Increase: {depositSum:f2}");
                }
                
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                totalSum = totalSum + depositSum;
            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
