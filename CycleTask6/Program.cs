/*
Дана последовательность из n целый чисел. Найти сумму элементов с четными номерами из этой последовательности.
 */

using System;

namespace CycleTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            string buf;
            int n;
            int a = 0;
            int s = 0;

            Console.WriteLine("Enter a number - n");
            buf = Console.ReadLine();
            n = int.Parse(buf);

            if (n <= 0)
            {
                Console.WriteLine("Empty sequence");
            }
                

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} - a");
                buf = Console.ReadLine();
                a = int.Parse(buf);

                if (i % 2 == 0)
                {
                    s += a;
                }
                


            }

            Console.WriteLine($"Sum of even numbers ={s}");

        }
    }
}
