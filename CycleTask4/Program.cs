/*
Максимальное число
 */

using System;

namespace CycleTask4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a, n, max;
            
            string buf;

            Console.WriteLine("Enter a numer - n");
            buf = Console.ReadLine();
            n = int.Parse(buf);

            if (n <= 0)
                Console.WriteLine("empty sequence");

            else
            {
                Console.WriteLine("Enter - a");
                buf = Console.ReadLine();
                a = int.Parse(buf);
                max = a;

                for (int i = 2; i <= n; i++)
                {
                    Console.WriteLine("Enter - a");
                    buf = Console.ReadLine();
                    a = int.Parse(buf);
                    if (max < a)
                        max = a;
                }
                Console.WriteLine($"Maximal a number {max}");
            }

        }
    }
}

