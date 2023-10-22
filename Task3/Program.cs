using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2 = 10;

            Console.WriteLine("введите число");
            string buffer = Console.ReadLine();
            number1 = Convert.ToInt32(buffer); //преобразовали строк в число


            long number3 = number1 % number2;
            Console.WriteLine($"последнее число  {number3} ");

        }
    }
}
