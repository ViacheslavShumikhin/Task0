using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n;
            Console.WriteLine("введите количество яблок");
            string buffer = Console.ReadLine();
            k = Convert.ToInt32(buffer); //преобразовали строк в число

            Console.WriteLine("введите количество школьников");
            buffer = Console.ReadLine();
            n = Convert.ToInt32(buffer); //преобразовали строк в число

            int cunt = k / n;
            Console.WriteLine($"Каждому школьнику достается по  {cunt} яблок");

            int ost = k % n;
            Console.WriteLine($"Остаток яблок составляет {ost}");

        }
    }
}
