/*
S2.6. Дан радиус окружности. Найти длину окружности и площадь круга.
 */


using System;

namespace S2._6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности или введите 0 для рандома");

            double r = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            double b = rnd.Next(1, 100);

            double r1 = Math.Pow(b, 2);
            double r2 = Math.Pow(r, 2);

            if (r == 0)

                Console.WriteLine($"При r ={b} длина окружности = {2 * 3.15 * b}, площадь круга составляет {3.14 * r1}");

            else
                Console.WriteLine($"При r ={r} длина окружности = {2 * 3.15 * r}, площадь круга составляет {3.14 * r2}");
        }
    }
}
