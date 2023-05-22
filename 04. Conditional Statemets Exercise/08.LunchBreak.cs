using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int lunchBreak = int.Parse(Console.ReadLine());

            double lunch = lunchBreak * 0.125;
            double rest = lunchBreak * 0.25;
            double timeWatching = lunchBreak - (lunch + rest);

            if (episodeTime <= timeWatching)
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(timeWatching - episodeTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(episodeTime - timeWatching)} more minutes.");
            }
        }
    }
}
