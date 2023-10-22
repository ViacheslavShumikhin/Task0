using System;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положение координат х1 > 0");
            string buf1 = Console.ReadLine();
            int x1 = int.Parse(buf1); //Устанавливаем 1 число

            Console.WriteLine("Введите положение координат у1 > 0");
            string buf2 = Console.ReadLine();
            int y1 = int.Parse(buf2); //Устанавливаем 2 число

            Console.WriteLine("Введите положение координат х2 > 0");
            string buf3 = Console.ReadLine();
            int x2 = int.Parse(buf3); //Устанавливаем 3 число

            Console.WriteLine("Введите положение координат у2 > 0");
            string buf4 = Console.ReadLine();
            int y2 = int.Parse(buf4); //Устанавливаем 4 число

            if (((x1 + y1) % 2) == 0 && ((x2 + y2) % 2) == 0)

                Console.WriteLine($" Точки лежат в одной координатной плоскости ");

            else
                Console.WriteLine($" Точки лежат в разных координатных плоскостях ");
        }
    }
}
