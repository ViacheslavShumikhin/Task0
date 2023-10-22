/*
S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.
 */

using System;

namespace S1._8_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.");
            Console.WriteLine("Vvedite chislo A");
            string a = Console.ReadLine();
            int A = int.Parse(a);

            Console.WriteLine("Vvedite chislo B");
            string b = Console.ReadLine();
            int B = int.Parse(b);

            Console.WriteLine("Vvedite chislo C");
            string c = Console.ReadLine();
            int C = int.Parse(c);

            Console.WriteLine("Vvedite chislo D");
            string d = Console.ReadLine();
            int D = int.Parse(d);

            Console.WriteLine($"{A} {B} {C} {D} ");
        }
    }
}
