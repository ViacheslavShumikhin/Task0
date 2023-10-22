/*
S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
 */


using System;

namespace S1._7_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.");
            Console.WriteLine("VVedite chislo A");
            string a = Console.ReadLine();
            int A = int.Parse(a);

            Console.WriteLine("Vvedite chislo B");
            string b = Console.ReadLine();
            int B = int.Parse(b);

            Console.WriteLine("Vvedite chislo C");
            string c = Console.ReadLine();
            int C = int.Parse(c);

            Console.WriteLine($"{A}  {B}  {C}");
        }
    }
}
