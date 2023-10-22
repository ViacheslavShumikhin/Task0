/*
 S=15+17-19+21-23...n
 */

using System;

namespace CycleTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int s = 0;
            string buf;



            Console.WriteLine("Введите чило n");
            buf = Console.ReadLine();
            n = int.Parse(buf);
            int a = 15;

            for (int i = 1; i <= n; i++)
            {

                if (i % 3 != 0)
                {
                    s += a;
                }

                else
                {
                    s -= a;
                }

            a = a + 2;




            }
            Console.WriteLine($"{s}");
        }
    }
}
