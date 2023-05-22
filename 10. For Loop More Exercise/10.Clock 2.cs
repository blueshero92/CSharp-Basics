using System;

namespace _10.Clock_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int n = 0; n < 60; n++)
                {
                    for(int j = 0; j < 60; j++)
                    {
                        Console.WriteLine($"{i} : {n} : {j}");
                    }
                }
            }
        }
    }
}
