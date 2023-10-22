/*
Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей.
 */


using System;

namespace S2._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 6350;
            Console.WriteLine("Введите высоту AB");
            string h = Console.ReadLine();
            int h1 = int.Parse(h);
            int d = r + h1;
            double result =  Math.Sqrt(Math.Pow(d,2)- Math.Pow(r,2));
            Console.WriteLine($"Растояние до линии горизонта составляет { result } км");





        }
    }
}
