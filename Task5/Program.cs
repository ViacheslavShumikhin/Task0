using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число");
            string buffer = Console.ReadLine();
            int n = Convert.ToInt32(buffer); //Устанавливаем двухзначное число

            int d = n / 10;

            int e = n / 100;

            Double b = n % 10;

            Console.WriteLine($"Число десятков = {d} ");

            Console.WriteLine($"Число едениц =  {b} ");


        }
    }
}
