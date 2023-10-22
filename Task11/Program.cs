/*
Даны три целых числа. Найдите наибольшее из них (программа должна
вывести ровно одно целое число).
 */


using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            string buf = Console.ReadLine();
            int a = int.Parse(buf); //Устанавливаем число

            Console.WriteLine("Введите число В");
            string buf1 = Console.ReadLine();
            int b = int.Parse(buf1); //Устанавливаем число

            Console.WriteLine("Введите число С");
            string buf2 = Console.ReadLine();
            int c = int.Parse(buf2); //Устанавливаем число


            if (a > b)
                Console.WriteLine($" Наибольшее число { a } ");

            else
                if (b > c)
                Console.WriteLine($" Наибольшее число { b } ");
            else
                Console.WriteLine($" Наибольшее число { c } ");
        }
    }
}
