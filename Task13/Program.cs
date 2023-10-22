/*
Шахматный король ходит по горизонтали, вертикали и диагонали, но только
на 1 клетку. Даны две различные клетки шахматной доски, определите, может ли король
попасть с первой клетки на вторую одним ходом.
 */


using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите положение короля по координате Х число 1 от 1 до 8");
            string buf1 = Console.ReadLine();
            int x1 = int.Parse(buf1); //Устанавливаем 1 число

            Console.WriteLine("Введите положение короля по координате У число 2 от 1 до 8");
            string buf2 = Console.ReadLine();
            int y1 = int.Parse(buf2); //Устанавливаем 2 число

            Console.WriteLine("Введите координату Х хода короля от 1 до 8");
            string buf3 = Console.ReadLine();
            int y2 = int.Parse(buf3); //Устанавливаем 3 число

            Console.WriteLine("Введите координату У хода короля от 1 до 8");
            string buf4 = Console.ReadLine();
            int x2 = int.Parse(buf4); //Устанавливаем 4 число

            if ((x1 - x2 <= 1 && x1 - x2 >= -1) && (y1 - y2 <= 1 && y1 - y2 >= -1))

                Console.WriteLine($" Король может попасть с первой клетки на вторую одним ходом ");
            else
                Console.WriteLine($" Король не может попать с первой клетки на вторую одним ходом ");

        }
    }
}


