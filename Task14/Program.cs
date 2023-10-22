/*
Заданы две клетки шахматной доски. Если они покрашены в один цвет, то
выведите слово YES, а если в разные цвета-то N0. Вводятся 4 числа - координаты
клеток. ДА
 */

using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положение первой клетки Х число 1 от 1 до 8");
            string buf1 = Console.ReadLine();
            int x1 = int.Parse(buf1); //Устанавливаем 1 число

            Console.WriteLine("Введите положение первой клетки У число 2 от 1 до 8");
            string buf2 = Console.ReadLine();
            int y1 = int.Parse(buf2); //Устанавливаем 2 число

            Console.WriteLine("Введите положение второй клетки Y число от 1 до 8");
            string buf3 = Console.ReadLine();
            int y2 = int.Parse(buf3); //Устанавливаем 3 число

            Console.WriteLine("Введите положение второй клетки X число от 1 до 8");
            string buf4 = Console.ReadLine();
            int x2 = int.Parse(buf4); //Устанавливаем 4 число

            if (((x1 + y1) % 2) == 0 && ((x2 + y2) % 2) == 0)

                Console.WriteLine($" YES ");

            else
                Console.WriteLine($" NO ");
        }
    }
}
