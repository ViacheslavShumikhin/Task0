/*
S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».
 */

using System;

namespace S1._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».");
            Console.WriteLine("Введите число");

            string buf = Console.ReadLine();
            int a = int.Parse(buf);
            Console.WriteLine($"Вы ввели чило {a}");
        }
    }
}
