using System;

namespace _04._Numbers_Divided_By_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 100; n++)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
