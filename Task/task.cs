using System;

namespace task
{
    class task
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("введите 1-е число");
            string buffer = Console.ReadLine();
            number1 = Convert.ToInt32(buffer); //преобразовали строк в число

            Console.WriteLine("введите 2-е число");
            buffer = Console.ReadLine();
            number2 = Convert.ToInt32(buffer); //преобразовали строк в число

            int summa = number1 + number2;
            Console.WriteLine($"Сумма чисел  {number1} и {number2} = {summa}");

            int summa1 = number1 - number2;
            Console.WriteLine($"Разница чисел  {number1} и {number2} = {summa1}");

            int summa2 = number1 * number2;
            Console.WriteLine($"Произведение чисел  {number1} и {number2} = {summa2}");

            double summa3 = number1 / number2;
            Console.WriteLine($"Деление чисел  {number1} и {number2} = {summa3}");


            double summa4 = number1 % number2;
            Console.WriteLine($"Остаток деления  {number1} и {number2} = {summa4}");
        }
    }
}
