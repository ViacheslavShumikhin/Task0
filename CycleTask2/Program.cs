/*
Найти количество четных чисел;
 */


using System;

namespace CycleTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a;

            double k = 0;
            string buf;


            Console.WriteLine("Введите чило n");
            buf = Console.ReadLine();
            n = int.Parse(buf);

            if (n <= 0)
                Console.WriteLine("пустая последовательность");
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Введите число a");
                    buf = Console.ReadLine();
                    a = int.Parse(buf);

                    if
                        (a % 2 == 0)
                        k++;
                }
                Console.WriteLine($"Количество четных чисел {k}");
            }
        }
    }
}