/*
Минимальное значение
*/


using System;

namespace CycleTask3


{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n, min;
            
            string buf;

            Console.WriteLine("Enter a numer - n");
            buf = Console.ReadLine();
            n = int.Parse(buf);

            if (n<=0)
                Console.WriteLine("empty sequence");

            else
                {
                    Console.WriteLine("Enter - a");
                    buf = Console.ReadLine();
                    a = int.Parse(buf);
                    min = a;

                    for (int i = 2; i <= n; i++)
                    {
                        Console.WriteLine("Enter - a");
                        buf = Console.ReadLine();
                        a = int.Parse(buf);
                        if (min > a)
                            min = a;
                    }
                    Console.WriteLine($"Minimal a number {min}");
                }

        }
    }
}
