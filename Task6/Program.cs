using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string buffer = Console.ReadLine();
            int n = Convert.ToInt32(buffer); //Устанавливаем число

            int d = n + 1;

            long e = n - 1;


            Console.WriteLine($"Следующее число за введеным = {d} ");

            Console.WriteLine($"Предыдущее число за введенным =  {e} ");
        }
    }
}
