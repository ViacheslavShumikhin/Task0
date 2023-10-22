using System;
/*
 * Дана последовательность из n целых чисел, за которой следует 0. Найти сумму элементов c четными номерами из этой последовательности.
 */

namespace CycleTask20
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isCorrect;
            string bufer;
            double s = 0;
            int n = 1;


            do
            {
                Console.WriteLine($"Номер последовательности {n}");
                Console.WriteLine("Введите целое число");
                bufer = Console.ReadLine();
                isCorrect = int.TryParse(bufer, out number);
                if (isCorrect == false) Console.WriteLine("Ошибка при вводе целого числа");
            }
            while (isCorrect == false);
            Console.WriteLine($"Вы ввели число {number}\n");

            //Обработка последовательности.

            while (number != 0)
            {
                if (n % 2 == 0)
                    s += number;
                n++;
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
                Console.WriteLine($"Вы ввели число {number} \n");
            }//Конец while

            if (n == 0)
            {
                Console.WriteLine("Пустая последовательность");

            }
            else
            {
                double sar = s;
                Console.WriteLine($"Сумма элементов c четными номерами из этой последовательности = {sar}");
            }

        }
    }
}
