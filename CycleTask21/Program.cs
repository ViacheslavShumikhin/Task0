using System;
/*
 * Дана последовательность из n целых чисел, за которой следует 0. Найти сумму четных элементов из этой последовательности.
 */

namespace CycleTask21
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isCorrect;
            string bufer;
            double a = 0;
            int n = 0;


            do
            {
                Console.WriteLine("Введите целое число");
                bufer = Console.ReadLine();
                isCorrect = int.TryParse(bufer, out number);
                if (isCorrect == false) Console.WriteLine("Ошибка при вводе целого числа");

            }
            while (isCorrect == false);
            Console.WriteLine($"Вы ввели число {number}");

            //Обработка последовательности.

            while (number != 0)
            {
                if (number % 2 == 0)
                {
                    a += number;
                    n++;
                }

                //Ввод числа
                do
                {
                    Console.WriteLine($"Номер последовательности {n}");
                    Console.WriteLine("Введите целое число");
                    bufer = Console.ReadLine();
                    isCorrect = int.TryParse(bufer, out number);
                    if (isCorrect == false) Console.WriteLine("Ошибка при вводе целого числа");

                }
                while (isCorrect == false);
                Console.WriteLine($"Вы ввели число {number}");
            }//Конец while

            if (n == 0)
            {
                Console.WriteLine("Пустая последовательность");

            }
            else
            {

                Console.WriteLine($"Сумма четных элементов этой последовательности = {a}");
            }

        }
    }
}
