using System;

namespace _02_Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int expectedSum = int.Parse(Console.ReadLine());

            int payment = 0;
            int cashPayment = 0;
            int cardPayment = 0;

            int totalPayment = 0;

            int paymentCount = 0;

            int totalCashPayment = 0;
            int totalCardPayment = 0;

            double averageCash = 0;
            double averageCard = 0;

            int cashPaymentCount = 0;
            int cardPaymentCount = 0;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                payment = int.Parse(input);
                paymentCount++;

                if (paymentCount == 1)
                {
                    cashPayment = payment;
                    cashPaymentCount++;
                    totalCashPayment += cashPayment;

                }
                else if (paymentCount == 2)
                {
                    cardPayment = payment;
                    cardPaymentCount++;
                    totalCardPayment += cardPayment;
                    paymentCount = 0;
                }

                totalPayment += payment;

                if ((cashPayment > 100 && paymentCount == 1) || (cardPayment < 10 && paymentCount == 0))
                {
                    Console.WriteLine("Error in transaction!");

                    if (paymentCount == 1)
                    {
                        cashPaymentCount -= 1;
                        totalCashPayment -= payment;
                    }
                    else
                    {
                        cardPaymentCount -= 1;
                        totalCardPayment -= payment;
                    }

                    totalPayment -= payment;
                    averageCash = 0;
                    averageCard = 0;
                    payment = 0;
                }

                else
                {
                    Console.WriteLine("Product sold!");
                }

                if (totalPayment >= expectedSum)
                {
                    break;
                }

                payment = int.Parse(input);

            }

            averageCash = (double)totalCashPayment / cashPaymentCount;
            averageCard = (double)totalCardPayment / cardPaymentCount;

            if (totalPayment >= expectedSum)
            {
                Console.WriteLine($"Average CS: {averageCash:f2}");
                Console.WriteLine($"Average CC: {averageCard:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
