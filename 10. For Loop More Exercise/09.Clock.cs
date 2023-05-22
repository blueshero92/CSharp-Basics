using System;

namespace _09.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for(int n = 0; n < 60; n++)
                {
                    Console.WriteLine($"{i} : {n}");
                }
            }
        }
    }
}
