using System;

namespace _03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargos = int.Parse(Console.ReadLine());

            int minibus = 0;
            int truck = 0;
            int train = 0;

            int totalCargos = 0;

            double minibusPrice = 200;
            double truckPrice = 175;
            double trainPrice = 120;

            double totalPrice = 0;
            double averagePrice = 0;


            for(int cargo = 1; cargo <= cargos; cargo++)
            {
                int cargoWeight = int.Parse(Console.ReadLine());

                if (cargoWeight <= 3)
                {
                    minibus += cargoWeight; 
                }
                else if (cargoWeight <= 11)
                {
                    truck += cargoWeight;
                }
                else
                {
                    train += cargoWeight;                  
                }

            }

            totalCargos = minibus + truck + train;
            totalPrice = minibus * minibusPrice + truck * truckPrice + train * trainPrice;
            averagePrice = totalPrice / totalCargos;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{(double)minibus / totalCargos * 100:f2}%");
            Console.WriteLine($"{(double)truck / totalCargos * 100:f2}%");
            Console.WriteLine($"{(double) train / totalCargos * 100:f2}%");
        }
    }
}
