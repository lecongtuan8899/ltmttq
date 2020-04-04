using System;

namespace SoGaSoCho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TINH SO GA SO CHO\n");
            for (int i = 9; i <= 25; i++)
            {
                if ((2 * i + (36 - i) * 4) == 100)
                {
                    Console.WriteLine("So ga la: " + i);
                    Console.WriteLine("So cho la: " + (36 - i));
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
