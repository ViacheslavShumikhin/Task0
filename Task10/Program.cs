/*
Напишите программу, которая считывает два целых числа А и В и выводит
наибольшее значение из них. Числа
— целые от 1 до 1000.
 */

using System;

namespace task10
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


            if (a > b)
                Console.WriteLine($" Наибольшее число { a } ");

            else
                Console.WriteLine($" Наибольшее число { b } ");
        }
    }
}
