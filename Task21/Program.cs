/*
Дано три числа. Упорядочите их в порядке неубывания. Программа должна
считывать три числа а,Ь,с, затем программа должна менять их значения так, чтобы стали
выполнены условия а<Ь<с, затем программа выводит тройку а,Ь,с.
 */

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            string buf = Console.ReadLine();
            int a = int.Parse(buf);

            Console.WriteLine("Введите число B");
            string buf1 = Console.ReadLine();
            int b = int.Parse(buf1);

            Console.WriteLine("Введите число С");
            string buf2 = Console.ReadLine();
            int c = int.Parse(buf2);

            while (a >= b)
            {
                Console.WriteLine(a);
                a--;
            }

            while (b <= a)
            {
                Console.WriteLine(b);
                b++;
            }

            while (c <= b)
            {
                Console.WriteLine(c);
                c++;
            }

            Console.WriteLine($" { a }<={ b }<={ c } ");
        }
    }
}