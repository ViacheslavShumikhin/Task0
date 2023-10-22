using System;

namespace CycleTask28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вывода значения выражения S=sin(x+cos(2x-sin(3x+cos(4x+sin(5x-cos(6x+...)...)");
            double s = 0, x = 0; bool ok = false; string str; int n = 0;

            while (!ok)
            {
                Console.WriteLine("Введите n");
                str = Console.ReadLine();
                if (int.TryParse(str, out n) && (n > 0)) ok = true;
                else Console.WriteLine("Ошибка ввода! Введите натуральное число");
            }
            ok = false;
            while (!ok)
            {
                Console.WriteLine("Введите x");
                str = Console.ReadLine();
                if (double.TryParse(str, out x)) ok = true;
                else Console.WriteLine("Ошибка ввода!Введите натуральное число");
            }

            s = Math.Cos(n * x);
            for (int i = n - 1; i > 0; i--)
            {
                s = Math.Cos(n * x - s);
            }
            s = Math.Sin(x + s);
            Console.WriteLine("S=sin(x+cos(2x-sin(3x+cos(4x+sin(5x-cos(6x+...)...)={0}", s);
            Console.WriteLine("Для выхода нажмите Enter...");
            Console.ReadLine();
        }
    }
}
