using System;

namespace Liczby_Pierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            int dataSum;
            dataSum = int.Parse(Console.ReadLine());

            for (int j = 0; j < dataSum; j++)
            {
                int divisor = 2;
                int number;
                number = int.Parse(Console.ReadLine());

                if (number == 1)
                {
                    Console.WriteLine("NIE");
                    continue;
                }

                while (true)
                {
                    if (number % divisor == 0 && number != divisor)
                    {
                        Console.WriteLine("NIE");
                        break;
                    }

                    if (divisor >= number)
                    {
                        Console.WriteLine("TAK");
                        break;
                    }

                    divisor++;
                }
            }
        }
    }
}
