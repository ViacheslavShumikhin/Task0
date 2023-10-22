/*
2 .2.Дана сторона квадрата.Найти его периметр.
 */


using System;

namespace S2._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата в см или поставьте 0 для автоматической генерации");
            string buf = Console.ReadLine();
            int a = int.Parse(buf);

            Random rnd = new Random();
            int b = rnd.Next(1, 10);

            if (a == 0)
            { Console.WriteLine($"Хорошо, сторона квадрата = { b }, периметр равен {b * 4}"); }
            
                          
            else   
        
            Console.WriteLine($"Периметр квадрата равен { a*4 }см");
        }
    }
}
