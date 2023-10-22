/*
Даны координаты двух точек на плоскости, требуется определить, лежат ли
они в одной координатной четверти или нет (все координаты отличны от нуля). Вводятся
4 числа: координаты первой точки (xl,yl) и координаты второй точки (х2,у2).
 */


using System;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положение координат х1 > 0");
            string buf1 = Console.ReadLine();
            long x1 = int.Parse(buf1); //Устанавливаем 1 число

            Console.WriteLine("Введите положение координат у1 > 0");
            string buf2 = Console.ReadLine();
            long y1 = int.Parse(buf2); //Устанавливаем 2 число

            Console.WriteLine("Введите положение координат х2 > 0");
            string buf3 = Console.ReadLine();
            long x2 = int.Parse(buf3); //Устанавливаем 3 число

            Console.WriteLine("Введите положение координат у2 > 0");
            string buf4 = Console.ReadLine();
            long y2 = int.Parse(buf4); //Устанавливаем 4 число

            if (x1 > 0 && x2 > 0 && y1 > 0 && y2 > 0)
                Console.WriteLine($" Точки лежат в I координатной плоскости ");
            else

            if (x1 > 0 && x2 > 0 && y1 < 0 && y2 < 0)
                Console.WriteLine($" Точки лежат в II координатной плоскости  ");
            else

            if (x1 < 0 && x2 < 0 && y1 < 0 && y2 < 0)
                Console.WriteLine($" Точки лежат в III координатной плоскости ");
            else

            if (x1 < 0 && x2 < 0 && y1 > 0 && y2 > 0)
                Console.WriteLine($" Точки лежат в IV координатной плоскости  ");
            else
                Console.WriteLine($" Точки не лежат в одной координатной плоскости  ");


        }

    }
}