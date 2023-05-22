using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            double judgesPoints = 0;
            double totalPoints = 0;

            for (int judge = 1; judge <= judges; judge++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());

                double points = judgeName.Length * (judgePoints / 2);
                judgesPoints += points;

                totalPoints = judgesPoints + startingPoints;

                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints:f1}!");
                    break;
                }

            }
          
            if (totalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - totalPoints:f1} more!");
            }
        }
    }
}
