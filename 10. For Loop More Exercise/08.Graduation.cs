using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int grade = 1;
            double mark = 0;

            double markSum = 0;
            int gradeRepeated = 0;
            double averageMark = 0;
            
            while(grade <= 12)
            {
                mark = double.Parse(Console.ReadLine());

                if (mark >= 4)
                {
                    grade++;
                }
                else
                {
                    gradeRepeated++;
                }
                if(gradeRepeated > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    break;
                }

                averageMark = averageMark + mark / 12;
            }
            if(grade > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageMark:f2}");
            }
        }
    }
}
