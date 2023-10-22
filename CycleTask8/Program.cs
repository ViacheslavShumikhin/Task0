/*
 * Дана последовательность из n целых чисел. Найти количество элементов этой поледовательности, кратных числу К1 и не кратных числу К2
 */

using System;

namespace CycleTask8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int a = 0;
            int b = 0;
            int c = 0;
            int k1;
            int k2;

            Console.WriteLine("Enter a number - n");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number - k1");
            k1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number - k2");
            k2 = int.Parse(Console.ReadLine());

            if (n<0)
            {
                Console.WriteLine("Empty sequence");
            }
            else

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Enter a nuber {i}- a");
                    a = int.Parse(Console.ReadLine());

                    if (i % k1 == 0)
                    {
                        b ++;
                    }
                    if (i % k2 !=0)
                    {
                        c ++;
                    }
                }
            Console.WriteLine($"The elements of the sequence is a multiple of k1 - {b}");
            Console.WriteLine($"The elements of the sequence is a multiple of k2 - {c}");
        }
    }
}
