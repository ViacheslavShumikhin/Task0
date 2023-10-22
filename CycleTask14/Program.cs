using System;
/*
 * Дана последовательность из N целых числе. Определить какое число в ней встретится раньше: минимальное или максимальное.
 */


namespace CycleTask14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a;
            int min = 0;
            int max = 0;
            int minPos = 0;
            int maxPos = 0;

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

                if (i == 1 || a < min)
                {
                    min = a;
                    minPos = i;
                }

                if (i == 1 || a > max)
                {
                    max = a;
                    maxPos = i;
                }

                Console.WriteLine($"Random A {i} = {a}");

            }
            if (minPos < maxPos)
                Console.WriteLine("Минимальное число встретится раньше");
            else if (minPos > maxPos)
                Console.WriteLine("Максимальное число встретится раньше");
            else
                Console.WriteLine("Оба числа");

        }
    }
}