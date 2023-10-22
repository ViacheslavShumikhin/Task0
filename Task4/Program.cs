using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.WriteLine("Введите стоимость пирожков в рублях");
            string buffer = Console.ReadLine();
            number1 = Convert.ToInt32(buffer); //Стоимость в рублях пирожков

            Console.WriteLine("Введите стоимость пирожков в копейках");
            buffer = Console.ReadLine();
            number2 = Convert.ToInt32(buffer); //Количество копеек в пирожках

            Console.WriteLine("Введите количество пирожков");
            buffer = Console.ReadLine();
            number3 = Convert.ToInt32(buffer); //преобразовали строк в число

            int kop = (number1 * 100 + number2) * number3; //Сумма копеек за пирожки

            int kop2 = kop / 100; //Количество рублей за n Пирожков

            double kop3 = kop % 100; //Количество копеек за n Пирожков

            Console.WriteLine($"На пирожки нужно  {kop2} руб. {kop3} коп.");


        }
    }
}