using System;

namespace RLE
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Input A String");
            string Input = Console.ReadLine();
            int L = 0;
            string[] Letters = new string[Input.Length];
            string Output = "";
            while (L < Input.Length)
            {
                Letters[L] = Convert.ToString(Input[L]);
                L++;
            }

            bool Loop = true;
            L = 0;
            int Num = 0;
            string Temp = "";
            while (Loop)
            {

                if (L == 0)
                {
                    Temp = Letters[L];
                    Num++;
                    L++;
                }
                else
                {
                    if (Temp == Letters[L])
                    {
                        Num++;
                        L++;
                    }
                    else
                    {
                        Output += $"{Temp}{Num} ";
                        Temp = Letters[L];
                        L++;
                        Num = 1;
                    }
                }

                if (L == Input.Length)
                {
                    Loop = false;
                }
            }
            Output += $"{Temp}{Num}";
            Console.WriteLine($"Your Data is now:\n{Output}" );
        }
    }
}
