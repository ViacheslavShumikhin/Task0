/*
 * Дана последовательность из n целых чисел. Определить, каких чисел в этой последовательности больше: положительных или отрицательных;
 */

using System;

namespace CycleTask9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a = 0;
            int b = 0;
            int c = 0;

            Console.WriteLine("Enter a number - n");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Enter a number - a");
                a = double.Parse(Console.ReadLine());

                if (a < 0)
                {
                    b++;
                }
                if (a > 0)
                {
                    c++;
                }

                
            }

            if (b > c)
            {
                Console.WriteLine($"More negative numbers - {b}");
            }
            else
            {
                Console.WriteLine($"More positive numbers - {c}");
            }


        }
    }
}
