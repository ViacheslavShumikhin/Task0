/*
Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности.
 */


using System;

namespace S2._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба, или поставьте 0 для рандома");
            string buf = Console.ReadLine();
            int a = int.Parse(buf);

            Random rnd = new Random();
            int b = rnd.Next(1, 100);

            int a1 = Math.Pow(a, 3);
            int a2 = Math.Pow(a, 2);
            int c = Math.Pow(b, 3);
            int d = Mat.Pow(b, 2);

            if (a == 0);
            Console.WriteLine($"Объем куба равен {a1}");
            Console.WriteLine($"Площадь боковой поверхности равна {a2}");
            else
                Console.WriteLine($"Рандомное число {b}");
                Console.WriteLine($"Объем куба равен {c)}");
                Console.WriteLine($"Площадь боковой поверхности равна {d}");

        }
    }
}
