using System;
using System.Diagnostics;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGradesAllowed = int. Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string problemName = string.Empty;

            int grades = 0;
            int badGrades = 0;
            double gradesSum = 0;
            double averageScore = 0;

            while (input != "Enough")
            {                
                int grade = int.Parse(Console.ReadLine());
                problemName = input;

                gradesSum += grade;
                grades++;

                if (grade <= 4)
                {
                    badGrades++;

                    if (badGrades == badGradesAllowed)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        break;
                    }
                }

                input = Console.ReadLine();
                
            }

            averageScore += gradesSum / grades;

            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {grades}");
                Console.WriteLine($"Last problem: {problemName}");

            }


        }
    }
}
