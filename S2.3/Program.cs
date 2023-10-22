/*
S2.3. Дан радиус окружности. Найти ее диаметр.
 */


using System;

namespace S2._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружноси в см или поставьте 0 для автоматической генерации");
            string buf = Console.ReadLine();
            int a = int.Parse(buf);

            Random rnd = new Random();
            int b = rnd.Next(1, 10);

            if (a == 0)
            { Console.WriteLine($"Хорошо, радиус окружности = { b }, диаметр равен {b * 2}"); }


            else

                Console.WriteLine($"Диаметр круга равен { a * 2 }см");
        }
    }
}
