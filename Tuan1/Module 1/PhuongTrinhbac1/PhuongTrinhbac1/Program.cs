using System;

namespace PhuongTrinhbac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            Console.WriteLine("GIAI PHUONG TRINH BAC NHAT");
            Console.Write("nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap b:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phuong trinh vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                x = -b / a;
                Console.WriteLine(value: $"Phuong trinh co nghiem x={0}" + x);
                Console.ReadLine();
            }
        }
    }
}
