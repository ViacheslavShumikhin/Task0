/*
 В математике функция sign(x) (знак числа) определена так:
sign(x)=l, если х>0,
sign(x)=-l, если х<0,
sign(x)=0, если х=0.
Для данного числа х выведите значение sign(x). 
 */


using System;

namespace task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число X");
            string buf1 = Console.ReadLine();
            int n = int.Parse(buf1); //Устанавливаем 1 число

            if (n > 0)

                Console.WriteLine($" Sign(x)=1 ");
            else

            if (n < 0)

                Console.WriteLine($" Sign(x)=-1 ");
            else
                 if (n == 0)
                Console.WriteLine($" Sign(x)=0 ");
        }
    }
}
