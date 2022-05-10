using System;
using System.Threading;

namespace Fib_on_a_Chi
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pleas Enter the Amount of Digits it should be to");
            bool Num = int.TryParse(Console.ReadLine(), out int Digits);
            if (Num)
            {
                Fib(Digits);
            }
            else
            {
                Console.WriteLine("Please Only Input Numbers");
                Thread.Sleep(2000);
                Console.Clear();
                Main();
            }
        }
        
        static void Fib(int Digits)
        {
            ulong F1 = 1;
            ulong F2 = 1;
            while (Digits != 0)
            {
                if (Digits == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"The First Fibonacci Number with {Digits} is {F1}");
                    break;
                }
                F1 = F1 + F2;
                F2 = F2 + F1;

                if (F1 / (1 * Math.Pow(10, Digits - 1)) >= 1)
                {
                    Console.Clear();
                    Console.WriteLine($"The First Fibonacci Number with {Digits} is {F1}");
                    break;
                }
                else if (F2 / (1 * Math.Pow(10, Digits - 1)) >= 1)
                {
                    Console.Clear();
                    Console.WriteLine($"The First Fibonacci Number with {Digits} Digits is {F2}");
                    break;
                }
            }
        }
    }
}
