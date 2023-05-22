using System;

namespace _05._Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int total = 0;

            int input = 0;

            for (int i = 1; i <= n; i++)
            {
                input = int.Parse(Console.ReadLine());
                total += input;
            }
            Console.WriteLine($"{(double)total / n:f2}");

        }
    }
}
