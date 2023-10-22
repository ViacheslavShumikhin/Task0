/*
 Дано целое чило L, и даны целые числа a1, a2...an
 Найдем среднее рифметическое.
 */


using System;

namespace CycleTask1
{
    class Program
    {
        static void Main(string[] args)

        {
            int n;

            double s = 0;
            
            Console.WriteLine("Введите чило n");
            string buf = Console.ReadLine();
            n = int.Parse(buf);

            if (n <= 0)
                Console.WriteLine("пустая последовательность");
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Введите число a");
                    int a = Convert.ToInt32(Console.ReadLine());
                    
                    s += a;
                }
                Console.WriteLine($"Среднее арифметическое сумм числе n ={s/n}");
            }
        }
    }
}