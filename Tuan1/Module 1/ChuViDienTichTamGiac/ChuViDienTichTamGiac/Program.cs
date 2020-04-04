using System;

namespace ChuViDienTichTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TINH CHU VI VA DIEN TICH TAM GIAC\n");
            int a, b, c;
            double cv,dt,p,i;
            Console.WriteLine("nhap canh a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap canh b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap canh c:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a>0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        cv = a + b + c;
                        Console.WriteLine("Chu vi tam giac la:\n" + cv);
                        p = cv / 2;
                        i = p * (p - a) * (p - b) * (p - c);
                        dt = Math.Sqrt(i);
                        dt = Math.Round(dt,1);
                        Console.WriteLine("Dien tich tam giac la:\n" + dt);
                    }
                    else
                        Console.WriteLine("Khong tao thanh tam giac");
                }
                else
                    Console.WriteLine("Khong tao thanh tam giac");
            }
            else
                Console.WriteLine("Khong tao thanh tam giac");
            Console.ReadKey();
        }
    }
}
