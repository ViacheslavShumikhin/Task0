using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество километров которое машина проезжает за 1 день");
            string buffer = Console.ReadLine();
            int n = int.Parse(buffer); //Устанавливаем число

            Console.WriteLine("Введите количество километров которое машина нужно проехать");
            string buffer1 = Console.ReadLine();
            int m = int.Parse(buffer1); //Устанавливаем число

            double ost = m % n;
            int d = m / n;

            if (ost == 0)
                Console.WriteLine($" Машине нужно { ost } дней ");

            else
                ost = d + 1;

            Console.WriteLine($" Машине нужно { ost } дней ");
        }
    }
}
