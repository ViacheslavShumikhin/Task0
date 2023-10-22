using System;
/*
 *       int k, b, c;
            int a = 0;
            Console.WriteLine("Введите число К");
            k = int.Parse(Console.ReadLine());

            if (k < 10)
            {
                Console.WriteLine("Число не десятичное");
            }
            else
            {
                a = k % 10;
                b = k - (a * 10);
                c = a + b;
                Console.WriteLine($"{c}");
 * 
 */
namespace CycleTask23
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int number = 0;
            bool isCorrect;
            string bufer;
            int n = 0;
            int k = 0;
            int c = 0;

            do //Цикл ввода первого числа
            {
                Console.WriteLine("Введите целое число");
                bufer = Console.ReadLine();
                isCorrect = int.TryParse(bufer, out number); //Преобразовываем bufer в число
                if (isCorrect == false) Console.WriteLine("Ошибка при вводе целого числа"); //Проверка на соответствие  целого числа

            }
            while (isCorrect == false);
            Console.WriteLine($"Вы ввели число {number}");

            //Обработка последовательности.

            while (number != 0) //Цикл ввода второго и последующих цифр
            {
                if (number >= 10)
                    k = number % 10;
                b = number - (k * 10);
                c = k + b;
                Console.WriteLine($"{c}");
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
                Console.WriteLine($"Сумма элементов c четными номерами из этой последовательности = {c}");


            }
        }
    }
}
