using System;

/*
 * Дана последовательность целых чисел, за которой следует 0. Определить какое число встретится в ней раньше: минимальное или максимальное.
 * 
 * int n, a;
            int min = 0;
            int max = 0;
            int minPos = 0;
            int maxPos = 0;

            Random rnd = new Random(); // int x = rnd.Next(1,10);


            Console.WriteLine("Please enter a number - n");
            n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Empty sequence");
            }

            for (int i = 1; i <= n; i++)
            {
                a = (rnd.Next(-100, 100));

                if (i == 1 || a < min)
                {
                    min = a;
                    minPos = i;
                }

                if (i == 1 || a > max)
                {
                    max = a;
                    maxPos = i;
                }

                Console.WriteLine($"Random A {i} = {a}");
                       
            }
            Console.WriteLine($"Минимальное число {min}");
            Console.WriteLine($"Максимальное чило {max}");
            if (minPos < maxPos)
                Console.WriteLine("Минимальное число встретится раньше");
            else if (minPos > maxPos)
                Console.WriteLine("Максимальное число встретится раньше");
            else
                Console.WriteLine("Оба числа");

 * 
 */

namespace CycleTask22
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; //Вводимое число
            bool isCorrect;
            string bufer;
            int n = 0; //Счетчик
            int min = 0;
            int max = 0;
            int minPos = 0;
            int maxPos = 0;
            int b = 0;
            int c = 0;



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
                n++;

                if (n == 1 || number < min)
                {
                    min = number;
                    minPos = n;
                }

                if (n == 1 || number > max)
                {
                    max = number;
                    maxPos = n;
                }

                if (n == 1)
                {
                    b = number;
                }
                if (number % b == 0)
                {
                    c++;
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

                Console.WriteLine($"Минимальное число {min}");
                Console.WriteLine($"Максимальное чило {max}");
                if (minPos < maxPos)
                    Console.WriteLine("Минимальное число встретится раньше");
                else if (minPos > maxPos)
                    Console.WriteLine("Максимальное число встретится раньше");
                else
                    Console.WriteLine("Оба числа");
                Console.WriteLine($"Номер минимальной {minPos}");
                Console.WriteLine($"Номер максимальной {maxPos}");
                Console.WriteLine($"Разность между максимальным и миниальным числом составляет {max - min}");
                Console.WriteLine($"Количество элементов  в последовательности кратно первого числа ={c}, первое число ={b}");
            }
        }
    }
}
