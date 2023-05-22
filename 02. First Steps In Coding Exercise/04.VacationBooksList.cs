using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesInBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hoursSum = pagesInBook / pagesPerHour;
            int hoursPerDay = hoursSum / days;
           
            Console.WriteLine(hoursPerDay);

        }
    }
}
