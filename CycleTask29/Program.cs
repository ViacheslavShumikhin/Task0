using System;

namespace CycleTask29
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            double sum = 0;
            while (i <= 99)
            {
                sum = sum + Math.Sqrt(i);
                i = i + 3;
            }
            Console.WriteLine(sum);
        }
    }
}
