using System;

namespace _04._SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinationCount = 0;

            bool flag = false;

            for (int x1 = start; x1 <= stop; x1++)
            {
                for (int x2 = start; x2 <= stop; x2++)
                {
                    combinationCount++;

                    if (x1 + x2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCount} ({x1} + {x2} = {magicNumber})");
                        flag = true;
                        break;
                    }                   

                }                
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magicNumber}");
            }
        }
    }
}
