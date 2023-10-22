using System;

namespace CycleTask16
{
    /* Найти сумму цифер десятичном числе k */

    class Program
    {
        static void Main(string[] args)
        {
            int k, b, c;
            int a = 0;
            Console.WriteLine("Введите число К");
            k = int.Parse(Console.ReadLine());

            if (k < 10)
            {
                Console.WriteLine("Число не десятичное");
            }
            else
            {
                a = k % 10;
                b = k - (a * 10);
                c = a + b;
                Console.WriteLine($"{c}");
            }

        }
    }
}
