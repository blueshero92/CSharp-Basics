using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidght = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());

            int cakeSize = cakeLenght * cakeWidght;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                cakeSize -= int.Parse(input);                

                if (cakeSize <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
                    break;

                }

                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }


        }
    }
}
