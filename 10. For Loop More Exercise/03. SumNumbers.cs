using System;

namespace _03._SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numbersSum = 0;
            int input;

            while(numbersSum < number)
            {
                input = int.Parse(Console.ReadLine());
                
                numbersSum = numbersSum + input;
            }

            Console.WriteLine(numbersSum);
        }
    }
}
