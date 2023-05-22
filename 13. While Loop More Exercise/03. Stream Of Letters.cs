using System;

namespace _03._Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string word = string.Empty;

            int cCount = 0;
            int oCount = 0;
            int nCount = 0;

            while (input != "End")
            {
                if (input == "c")
                {
                    cCount++;
                }
                else if (input == "o")
                {
                    oCount++;
                }
                else if (input == "n")
                {
                    nCount++;
                }

                if ((char.Parse(input) >= 97 && char.Parse(input) <= 122) || (char.Parse(input) >= 65 && char.Parse(input) <= 90))
                {
                    if ((cCount > 1 && input == "c") || (oCount > 1 && input == "o") || (nCount > 1 && input == "n"))
                    {
                        word += input;
                    }
                    else if (input != "c" && input != "o" && input != "n")
                    {
                        word += input;
                    }
                }

                if (cCount >= 1 && oCount >= 1 && nCount >= 1)
                {
                    Console.Write($"{word} ");
                    word += " ";
                    cCount = 0;
                    oCount = 0;
                    nCount = 0;
                    word = string.Empty;
                }

                input = Console.ReadLine();          
            }
        }
    }
}
