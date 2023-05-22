using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            
            int seats = 0;
            
            string ticketType;
            
            int kidTicketCount = 0;
            int studentTicketCount = 0;
            int standardTicketCount = 0;
            int totalTickets;
            

            while (movieName != "Finish")
            {
                seats = int.Parse(Console.ReadLine());
                ticketType = Console.ReadLine();

                int currentKidTicketCount = 0;
                int currentStudentTicketCount = 0;
                int currentStandardTicketCount = 0;

                int totalSeats = seats;

                while (ticketType != "End" && seats > 0)
                {
                    seats--;
                    
                    if (ticketType == "kid")
                    {
                        kidTicketCount++;
                        currentKidTicketCount++;
                    }
                    else if (ticketType == "student")
                    {
                        studentTicketCount++;
                        currentStudentTicketCount++;
                    }
                    else
                    {
                        standardTicketCount++;
                        currentStandardTicketCount++;
                    }

                    if (seats != 0)
                    {
                        ticketType = Console.ReadLine();
                    }
                    
                }
                int currentTotalTickets = currentKidTicketCount + currentStudentTicketCount + currentStandardTicketCount;

                Console.WriteLine($"{movieName} - {(double)currentTotalTickets*100/totalSeats:f2}% full.");

                movieName = Console.ReadLine();
            }
            totalTickets = kidTicketCount + studentTicketCount + standardTicketCount;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)studentTicketCount * 100 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{(double)standardTicketCount * 100/ totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidTicketCount * 100 / totalTickets:f2}% kids tickets.");
        }
    }
}
