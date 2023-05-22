using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int dogpack = int.Parse(Console.ReadLine());
            int catpack = int.Parse(Console.ReadLine());

            double dogfood = dogpack * 2.50;
            double catfood = catpack * 4.00;

            Console.WriteLine($"{dogfood + catfood} lv.");
          
            
        }
    }
}
