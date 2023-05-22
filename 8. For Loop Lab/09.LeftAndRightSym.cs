using System;

namespace _09.LeftAndRightSym
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for(int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                leftSum = leftSum + currentNum;
            }
            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                rightSum = rightSum + currentNum;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }

        }
    }
}
