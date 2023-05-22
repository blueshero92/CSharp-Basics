using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int musala = 0;
            int monblan = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int ewerest = 0;

            int totalPpl = 0;


            for (int group = 1; group <= groups; group++)
            {
                int pplPerGroup = int.Parse(Console.ReadLine());

                totalPpl += pplPerGroup;

                if (pplPerGroup <= 5)
                {
                    musala += pplPerGroup;
                }
                else if (pplPerGroup <= 12)
                {
                    monblan += pplPerGroup;
                }
                else if (pplPerGroup <= 25)
                {
                    kilimanjaro += pplPerGroup;
                }
                else if (pplPerGroup <= 40)
                {
                    k2 += pplPerGroup;
                }
                else
                {
                    ewerest += pplPerGroup;
                }

            }
            Console.WriteLine($"{(double) musala / totalPpl * 100:f2}%");
            Console.WriteLine($"{(double) monblan / totalPpl * 100:f2}%");
            Console.WriteLine($"{(double) kilimanjaro / totalPpl * 100:f2}%");
            Console.WriteLine($"{(double) k2 / totalPpl * 100:f2}%");
            Console.WriteLine($"{(double) ewerest / totalPpl * 100:f2}%");

        }
    }
}
