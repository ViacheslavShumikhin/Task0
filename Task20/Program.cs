/*
 Даны три целых числа А, В, С. Определить, есть ли среди них хотя бы одно
четное и хотя бы одно нечетное.
*/
using System;

namespace task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            string buf1 = Console.ReadLine();
            long a = int.Parse(buf1); //Устанавливаем 1 число

            Console.WriteLine("Введите число В");
            string buf2 = Console.ReadLine();
            long b = int.Parse(buf2); //Устанавливаем 2 число

            Console.WriteLine("Введите число С");
            string buf3 = Console.ReadLine();
            long c = int.Parse(buf3); //Устанавливаем 3 число

            if (a % 2 == 0)
                Console.WriteLine($" Четное число { a } ");
            else

            if (b % 2 == 0)
                Console.WriteLine($" Четное число { b } ");
            else

            if (c % 2 == 0)
                Console.WriteLine($" Четное число { c } ");
            else
                Console.WriteLine($" Определяем нечетное число ");

            if (a % 2 != 0)
                Console.WriteLine($" Не четное число { a } ");
            else

           if (b % 2 != 0)
                Console.WriteLine($" Не четное число { b } ");
            else

           if (c % 2 != 0)
                Console.WriteLine($" Не четное число { c } ");


        }

    }
}