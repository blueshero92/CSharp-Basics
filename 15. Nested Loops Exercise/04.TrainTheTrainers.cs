using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            string presentationName;
            int presentationCount = 0;
            double grade = 0;
            double gradesSum = 0;

            while(input != "Finish")
            {
                presentationName = input;
                grade = 0;

                for (int i = 1; i <= judges; i++)
                {
                    grade += double.Parse(Console.ReadLine());
                }

                grade = grade/judges;

                Console.WriteLine($"{presentationName} - {grade:f2}.");

                input = Console.ReadLine();

                gradesSum += grade;
                presentationCount++;
            }
            Console.WriteLine($"Student's final assessment is {gradesSum / presentationCount:f2}.");
        }
    }
}
