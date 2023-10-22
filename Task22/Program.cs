/*
Даны три целых числа. Определите, сколько среди них совпадающих.
Программа должна вывести одно из чисел: 3 (если все совпадают), 2 (если два совпадает) или 0 (если все числа разные)
*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            string buf = Console.ReadLine();
            int a = int.Parse(buf);

            Console.WriteLine("Введите число B");
            string buf1 = Console.ReadLine();
            int b = int.Parse(buf1);

            Console.WriteLine("Введите число С");
            string buf2 = Console.ReadLine();
            int c = int.Parse(buf2);

            if (a == b && b == c)
            {
                Console.WriteLine("3");
            }

            else

            if (a != b && b == c || a == b && b != c || a == c && b != c)
            {
                Console.WriteLine("2");
            }

            else

            if (a != b && b != c)
            {
                Console.WriteLine("0");
            }


        }
    }
}