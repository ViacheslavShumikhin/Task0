/*
Шоколадка имеет вид прямоугольника, разделенного на nxm долек.
Шоколадку можно один раз разломить по прямой на две части. Определите, можно ли
таким образом отломить от шоколадки часть, состоящую ровно из к долек. Программа
получает на вход три числа: n, т, к.
 */

using System;

namespace task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество долек по горозонтали");
            string buf1 = Console.ReadLine();
            int n = int.Parse(buf1); //Устанавливаем 1 число

            Console.WriteLine("Количество долек по вертикали");
            string buf2 = Console.ReadLine();
            int m = int.Parse(buf2); //Устанавливаем 2 число

            Console.WriteLine("Введите количество долек которую нужно отломить");
            string buf3 = Console.ReadLine();
            int k = int.Parse(buf3); //Устанавливаем 3 число


            if ((n % k == 0) || (m % k == 0))

                Console.WriteLine($" Можно отломить часть шоколадки из { k } долек ");

            else
                Console.WriteLine($" Нельзя отломить часть шоколадки из { k } долек ");
        }
    }
}
