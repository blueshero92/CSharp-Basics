using System;

namespace _05.Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;
            int invalid = 0;

            double result = 0;

            for (int move = 1; move <= moves; move++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >=0 && number <= 9)
                {
                    group1++;
                    result += number * 0.20; 
                }
                else if (number >= 0 && number <= 19)
                {
                    group2++;
                    result += number * 0.30;
                }
                else if (number >= 0 && number <= 29)
                {
                    group3++;
                    result += number * 0.40;
                }
                else if (number >= 0 && number <= 39)
                {
                    group4++;
                    result += 50;
                }
                else if (number >= 0 && number <= 50)
                {
                    group5++;
                    result += 100;
                }
                else if (number < 0 || number > 50)
                {
                    invalid++;
                    result = result / 2;
                }
            }

            int totalGroups = group1 + group2 + group3 + group4 + group5 + invalid;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {(double)group1/totalGroups*100:f2}%");
            Console.WriteLine($"From 10 to 19: {(double)group2 / totalGroups * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {(double)group3 / totalGroups * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {(double)group4 / totalGroups * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {(double)group5 / totalGroups * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {(double)invalid / totalGroups * 100:f2}%");
        }
    }
}
