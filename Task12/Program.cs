/*
Дано натуральное число. Требуется определить, является ли год с данным
номером високосным. Если год является високосным, то выведите YES, иначе выведите
N0. Напомним, что в соответствии с григорианским календарем, год является
високосным, если его номер кратен 4, но не кратен 100, или же если он кратен 400.
 */

using System;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            string buf = Console.ReadLine();
            int a = int.Parse(buf); //Устанавливаем число

            if (a % 4 == 0)
                Console.WriteLine($"Yes");

            else
                if (a % 100 != 0)
                Console.WriteLine($"No");
            else
                Console.WriteLine($"No");
        }
    }
}
