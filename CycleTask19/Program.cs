using System;
/*
 * Дана последовательность из n целых чисел, за которой следует 0. Найти сумму четных элементов этой последовательности.
 * 
 *          int n, a;
            int b = 0;


            Random rnd = new Random(); // int x = rnd.Next(1,10);


            Console.WriteLine("Please enter a number - n");
            n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Empty sequence");
            }

            for (int i = 1; i <= n; i++)
            {
                a = (rnd.Next(1, 10));

                if (i == n)
                {
                    a = 0;
                }
                if (a % 2 == 0)
                {
                    b += a;
                }
                Console.WriteLine($"Random A {i} = {a}");

            }
            Console.WriteLine($"{b}");
 * 
 */
namespace CycleTask19
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isCorrect;
            string bufer;
            double s = 0;
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
                Console.WriteLine($"Вы ввели число {number}");
            }//Конец while

            if (n == 0)
            {
                Console.WriteLine("Пустая последовательность");

            }
            else
            {
                double sar = s;
                Console.WriteLine($"Сумма четных элементов из этой последовательности = {sar}");
            }

        }
    }
}
