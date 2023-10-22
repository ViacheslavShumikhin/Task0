// S1.1. Вывести на экран число  с точностью до сотых.

using System;

namespace S1._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 12.4567;
            number = Math.Round(number, 2);
            Console.WriteLine(number);
        }

        

        
    }
}
