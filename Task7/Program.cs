using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string buffer = Console.ReadLine();
            int n = int.Parse(buffer); //Устанавливаем число

            int sled;

            if (n % 2 == 0)
                sled = n + 2;

            else
                sled = n + 1;

            Console.WriteLine($" Следующее четное число { n } = { sled } ");
        }
    }
}
