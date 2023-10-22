/*
S2.1. Составить программу:
а) вычисления значения функции y=7x2+3x+6 при любом значении x;
б) вычисления значения функции x=12a2+7a+12 при любом значении а.
 */


using System;

namespace S2._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int X = rnd.Next(1,10);  //Получить очередное случайное число
            int A = rnd.Next(1, 10); //Получить очередное случайное число

            Console.WriteLine($"Рандомное число Х = {X}");
            Console.WriteLine($"Рандомное число A = {A}");

            double y = 7 * X * 2 + 3 * X + 6;
            double x = 12 * A * 2 + 7 * A + 12;

            Console.WriteLine($"значения функции y=7x2+3x+6 при значении x={X} равняется {y}");
            Console.WriteLine($"значения функции x=12a2+7a+12 при  значении а={A} равняется {x}");
        }
    }
}
