/*
S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел. 
 */


using System;

namespace S1._11_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.");

            Console.WriteLine("Vvedite chslo A");
            string A = Console.ReadLine();
            int a = int.Parse(A);

            Console.WriteLine("Vvedite chslo B");
            string B = Console.ReadLine();
            int b = int.Parse(B);

            Console.WriteLine("Vvedite chslo C");
            string C = Console.ReadLine();
            int c = int.Parse(C);

            Console.WriteLine("Vvedite chslo A");
            string D = Console.ReadLine();
            int d = int.Parse(D);

            Console.WriteLine($"\n{a}\n\n{b}\n\n{c}\n\n{d}\n");
        }
    }
}
