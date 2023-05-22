using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treated = 0;
            int untreated = 0;

            int thirdDay = 1;

            for (int day = 1; day <= days; day++)
            {
                int patientsPerDay = int.Parse(Console.ReadLine());


                if (patientsPerDay <= doctors)
                {
                    treated += patientsPerDay;
                }
                else
                {
                    treated += doctors;
                    untreated += patientsPerDay - doctors;
                }

                thirdDay++;

                if (thirdDay == 3)
                {
                    thirdDay = 0;

                    if (untreated > treated)
                    {
                        doctors++;
                    }
                }

            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");


        }
    }
}
