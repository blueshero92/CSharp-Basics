using System;

namespace _08.Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());
            
            int num1 = 0;
            int num2 = 0;

            int prevPairValue = 0;
            int pairValue = 0; 
            int totalValue = 0;

            int maxDifference = 0;

            int maxPair = int.MinValue;
            int minPair = int.MaxValue;

            int maxPairDifference = int.MinValue;


            for (int pair = 1; pair <= pairs; pair++)
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                pairValue = num1 + num2;

                totalValue += pairValue;


                if (pair > 1 && (Math.Abs(pairValue - prevPairValue)) > maxPairDifference)
                {
                    maxPairDifference = Math.Abs(pairValue - prevPairValue);
                }

                prevPairValue = pairValue;
            }

            maxDifference = maxPair - minPair;

            if (totalValue / pairs == pairValue)
            {
                Console.WriteLine($"Yes, value={pairValue}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxPairDifference}");
            }


        }
    }
}
