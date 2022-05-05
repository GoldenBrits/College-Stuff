using System;
using System.Threading;
using System.Linq;

namespace Number_Thing
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("===============================================\nPlease Input how many Numbers you wish to enter\n===============================================");
            bool num = int.TryParse(Console.ReadLine(), out int Count);
            if (num)
            {
                int[] Numbers = new int[Count];
                Console.Clear();
                Console.WriteLine("===========================\nPlease Input the Number Now\n===========================");
                int Input = Convert.ToInt32(Console.ReadLine());
                while (Count > 0)
                {
                    int LastNumber = Input % 10;
                    Input = Input / 10;
                    Count--;
                    Numbers[Count] = LastNumber;
                }

                int[] Buingus = new int[10];
                //not working
                foreach (int I in Numbers)
                {
                    int Temp = Buingus[I];
                    Temp++;
                    Console.WriteLine(I);
                    Buingus[I] = Temp;
                }
                
                int Pos = Buingus[Buingus.Max()];
                int Numb = 0;
                int i = 0;
                while (Numb != Pos)
                {
                    Numb = Numbers[i];
                }
                Console.WriteLine($"{Numbers[Numb]} is the most frequent Number with {Buingus.Max()} instances");
            }
            else 
            {
                Console.WriteLine("Please Only Input Numbers");
                Thread.Sleep(2000);
                Console.Clear();
                Main();
            }
        }
    }
}
