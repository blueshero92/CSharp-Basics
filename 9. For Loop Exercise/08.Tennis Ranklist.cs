using System;

namespace _08.Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int pointsRecieved = 0;
            int tourPoints = 0;
            int averagePoints = 0;

            int tournamentsWon = 0;

            for (int tournament = 1; tournament <= tournaments; tournament++)
            {
                string tournamentStage = Console.ReadLine();

                if (tournamentStage == "W")
                {
                    pointsRecieved += 2000;
                }
                else if (tournamentStage == "F")
                {
                    pointsRecieved += 1200;
                }
                else
                {
                    pointsRecieved += 720;
                }


                if (tournamentStage == "W")
                {
                    tournamentsWon++;
                }
            }
            
            tourPoints += pointsRecieved;
            averagePoints += pointsRecieved / tournaments;

            int finalPoints = tourPoints + startingPoints;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{(double)tournamentsWon / tournaments * 100:f2}%");
        }
    }
}
