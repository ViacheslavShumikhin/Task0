using System;

namespace CycleTask24

/* Найти сумму цифер десятичном числе k 
        int k, b, c;
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
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, k;
            int number = 0;
            bool isCorrect;
            string bufer;

            do //Цикл ввода первого числа
            {
                Console.WriteLine("Введиие число");
                bufer = Console.ReadLine();
                isCorrect = int.TryParse(bufer, out number);
                if (isCorrect == false) Console.WriteLine("Ошибка при вводе десятичного числа");
                if (number < 10 && number > 100 ) Console.WriteLine("Число не десятичное");
                else 
                {
                    Console.WriteLine($"Вы ввели число {number}");
                    a = number % 10;
                    b = number / 10;
                    k = a + b;
                    Console.WriteLine($"Сумма чисел десятичного числа ={k}");
                }

            }
            while (isCorrect == true);
            
        }
    }
}
