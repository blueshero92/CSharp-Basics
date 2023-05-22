using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widght = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int apartmentSize = widght * lenght * height;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                apartmentSize -= int.Parse(input);

                if (apartmentSize <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(apartmentSize)} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{apartmentSize} Cubic meters left.");
            }
        }
    }
}
