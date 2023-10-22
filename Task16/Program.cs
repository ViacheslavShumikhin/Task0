/*
Для данного числа п<100 закончите фразу “На лугу пасется...” одним из
возможных продолжений: “п коров”, “п корова”, “п коровы”, правильно склоняя слово
“корова”.
 */



using System;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество коров до 100");
            string buf1 = Console.ReadLine();
            int n = int.Parse(buf1); //Устанавливаем 1 число

            if (n == 1)

                Console.WriteLine($" На лугу пасётся { n } корова ");
            else

            if ((n == 2) || (n == 3) || (n == 4))

                Console.WriteLine($" На лугу пасутся { n } коровы ");
            else
                Console.WriteLine($" На лугу пасутся { n } коров ");


        }
    }
}
