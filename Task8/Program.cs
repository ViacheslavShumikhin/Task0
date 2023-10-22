using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string buffer = Console.ReadLine();
            int n = int.Parse(buffer); //Устанавливаем число

            int d4 = n % 10;
            int d3 = n % 100 / 10;
            int d2 = n % 1000 / 100;
            int d1 = n / 1000;



            if (d1 == d4 && d2 == d3)
                Console.WriteLine($" Число семетричное");

            else
                Console.WriteLine($" Число не семетричное");



        }
    }
}
