using System;

namespace CycleTask25
{
    /*
     * Cформируйте все числа фибоначчи не превышающие заданное число Q
     */
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1, second = 1, third = 0;
            Console.Write("Enter a number : ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fib. # -", first, second);

            do
            {
                third = first + second;
                if (third <= n) Console.Write($"{third}, ");
                first = second;
                second = third;

            } while (third <= n);
        }
        }
    }
}
