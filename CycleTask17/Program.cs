using System;
/*
 * Дана последовательность из n целых чисел. Определить, каких чисел в этолй последовательности больше: положительных или отрицательных
 */


namespace CycleTask17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a;
            int b = 0;
            int c = 0;


            Random rnd = new Random(); // int x = rnd.Next(1,10);


            Console.WriteLine("Please enter a number - n");
            n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)
            {
                a = (rnd.Next(-10, 10));

                if (a < 0)
                {
                    b++;
                }
                else
                {
                    c++;
                }
                Console.WriteLine($"{a}");




            }
            if (c == b)
            {
                Console.WriteLine("Положительных и отрицательных чисел поровну");
            }
            if (c > b)
                Console.WriteLine("Положительных больше");
            else Console.WriteLine("Отрицательных больше");

        }
    }
}
