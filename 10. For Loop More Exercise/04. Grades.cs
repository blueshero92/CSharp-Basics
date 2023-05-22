using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;

            double averageGrade = 0;
            double totalGrade = 0;

            for (int student = 1; student <= students; student++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 3)
                {
                    group1++;
                }
                else if (grade < 4)
                {
                    group2++;
                }
                else if (grade < 5)
                {
                    group3++;
                }
                else
                {
                    group4++;
                }

                totalGrade += grade;
             
            }

            averageGrade += totalGrade / students;

            Console.WriteLine($"Top students: {(double)group4/students*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)group3/students*100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)group2/students*100:f2}%");
            Console.WriteLine($"Fail: {(double)group1/students*100:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");

        }
    }
}
