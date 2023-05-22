using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isPrime;

            int primeSum = 0;
            int nonPrimeSum = 0;

            while(input!= "stop")
            {
                int num = int.Parse(input);

                isPrime = true;

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if(num%i == 0)
                        {
                            isPrime = false;
                        }
                    }
                }
                if (isPrime && num > 0)
                {
                    primeSum += num;
                }
                else if (num > 0)
                {
                    nonPrimeSum += num;
                }

                input= Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
