/*
 * Дана последовательность из n целых чисел, за которой следует 0. Найти сумму четных элементов с четными номерами из этой последовательности.
 */


using System;

namespace CycleTask12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a;
            int b = 0;


            Random rnd = new Random(); // int x = rnd.Next(1,10);


            Console.WriteLine("Please enter a number - n");
            n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Empty sequence");
            }

            for (int i = 1; i <= n; i++)
            {
                a = (rnd.Next(1, 10));
                


                if (i == n)
                {
                    a = 0;
                }
                if (i % 2 == 0)
                {
                    b += a;
                }
                Console.WriteLine($"Random A {i} = {a}");

            }
            Console.WriteLine($"{b}");
        }
    }
}
