using System;

/*
 * Дана последовательность целых числе, за которой следует 0, определить какое число встретится в ней раньше: минимальное или максимальное;
 */


namespace CycleTask15
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

                if (i == n)
                {
                    a = 0;
                }

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

            Console.WriteLine($"Разность {max} и {min} = {max - min}");

        }
    }
}
