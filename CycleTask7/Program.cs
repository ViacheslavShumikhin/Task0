/*
 * Дана последовательность из n целых чисел. Найти сумму нечетных элементов этой последовательности.
 */

using System;

namespace CycleTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int s = 0;
            int a = 0;
            string buf;

            Console.WriteLine("Enter a number - n");
            buf = Console.ReadLine();
            n = int.Parse(buf);

            if (n < 0)
            {
                Console.WriteLine("Empty sequence");
            }
            else
                for (int i = 1; i < n; i++)
                {
                    Console.WriteLine($"Enter a number #{i} - a");
                    a = int.Parse(Console.ReadLine());

                    if (i % 2 != 0)

                        s += a;
                }
            Console.WriteLine($"Sum of even numbers ={s}");

        }
    }
}
