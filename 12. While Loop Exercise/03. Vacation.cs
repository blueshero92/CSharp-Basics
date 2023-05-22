using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double startingMoney = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int spendingDays = 0;

            while (moneyNeeded > startingMoney)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());

                daysCount++;

                if (action == "spend")
                {                   
                    spendingDays++;
                    startingMoney -= sum;

                    if (spendingDays == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }
                }
                else
                {
                    startingMoney += sum;
                    spendingDays = 0;
                    
                }

                if (startingMoney < 0)
                {
                    startingMoney = 0;
                }

            }

            if (startingMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }

        }
    }
}
