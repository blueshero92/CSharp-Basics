using System;

namespace _12.TradeComissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double comission = 0;
            bool shouldCalculateComission = true;

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.05;
                }
                else if (sales>500 && sales<= 1000)
                {
                    comission = sales * 0.07;
                }
                else if(sales>1000 && sales <= 10000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.12;
                }
                else
                {
                    shouldCalculateComission = false;
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.10;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.13;
                }
                else
                {
                    shouldCalculateComission = false;
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.145;
                }
                else
                {
                    shouldCalculateComission = false;
                    Console.WriteLine("error");
                }
            }
            else
            {
                shouldCalculateComission = false;
                Console.WriteLine("error");
            }
            if (shouldCalculateComission == true)
            {
                Console.WriteLine($"{comission:f2}");
            }
        }
    }
}
