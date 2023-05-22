using System;

namespace _01.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deteregentBottles = int.Parse(Console.ReadLine());

            int deteregentMl = deteregentBottles * 750;

            string input = Console.ReadLine();

            int loadingCount = 0;
            int dishes = 0;
            int pots = 0;

            while (input != "End")
            {
                int dishesPerLoading = int.Parse(input);
                
                loadingCount++;

                if(loadingCount == 3)
                {
                    pots += dishesPerLoading;
                    deteregentMl -= dishesPerLoading * 15;
                    loadingCount = 0;
                }
                else
                {
                    dishes += dishesPerLoading;
                    deteregentMl -= dishesPerLoading * 5;
                }

                if (deteregentMl < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(deteregentMl)} ml. more necessary!");
                    break;
                }

                input = Console.ReadLine();

            }
            if (input == "End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {deteregentMl} ml.");
            }
        }
    }
}
