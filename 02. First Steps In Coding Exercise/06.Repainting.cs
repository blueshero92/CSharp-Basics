using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine())+2;
            double paint = double.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalPaint = (paint + paint*0.1) * 14.50;
            double totalNylon = nylon * 1.50;
            double totalThinner = thinner * 5.00;
            double totalMaterials = totalPaint + totalNylon + totalThinner + 0.4;
            double payPerHour = (totalMaterials * 0.3);
            double totalPay = payPerHour * hours;

            double sum = totalMaterials + totalPay;

            Console.WriteLine(sum);

        }
    }
}
