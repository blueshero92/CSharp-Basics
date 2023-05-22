using System;

namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int totalTime = first + second + third;

            int mins = totalTime / 60;
            int secs = totalTime % 60;

            Console.WriteLine($"{mins}:{secs:d2}");
        }
    }
}
