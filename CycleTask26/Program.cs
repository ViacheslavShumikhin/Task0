using System;

namespace CycleTask26
{
    class Program
    {

        /*
         * Определить является ли число К простым. 
         */
        static void Main(string[] args)
        {
            double a, b;
            double number = 0;
            bool isCorrect;
            string bufer;

            do //Цикл ввода первого числа
            {
                Console.WriteLine("Введиие число");
                bufer = Console.ReadLine();
                isCorrect = double.TryParse(bufer, out number);
                if (isCorrect == false) Console.WriteLine("Ошибка при вводе десятичного числа");
                if (number < 10 && number > 100) Console.WriteLine("Число не десятичное");
                else
                {
                    Console.WriteLine($"Вы ввели число {number}");
                    a = number / number;
                    b = number % 2; 
                    if (a == 1 && b != 0)
                        Console.WriteLine($"Число {number} простое");
                    else Console.WriteLine($"Число {number} не является простым");
                }

            }
            while (isCorrect == true);
        }
    }
}
