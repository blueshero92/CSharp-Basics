using System;

namespace _08._On_Time_For_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            examMin = examMin + examHour * 60;
            arrivalMin = arrivalMin + arrivalHour * 60;

            int difference = examMin - arrivalMin;

            if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");

                if (difference > 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }

            }
            else if (difference < 0)
            {
                Console.WriteLine("Late");

                if (difference > -60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                    
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference / 60)}:{Math.Abs(difference % 60):d2} hours after the start");
                }
            }
            else
            {
                Console.WriteLine("Early");

                if (difference >= 60)
                {
                    Console.WriteLine($"{Math.Abs(difference / 60)}:{difference % 60:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
                  
                
            
        }
    }
}
