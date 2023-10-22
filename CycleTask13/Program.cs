using System;

/*
 * Дана последовательность из n целых чисел, за которой следует 0. Найти количество элементов этой последовательности, кратных её первому элементу.
 */


namespace CycleTask13
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

            if (n < 0)
            {
                Console.WriteLine("Empty sequence");
            }

            for (int i = 1; i <= n; i++)
            {
                a = (rnd.Next(1, 10));
                

                if (i == 1)
                {
                    b = a;
                }
                if (a % b == 0)
                {
                   c ++;
                }
                Console.WriteLine($"Random A {i} = {a}");
            }
            Console.WriteLine($"Количество элементов  в последовательности кратно а1 ={c}, число а1 ={b}");
        }
    }
}
