using System;

namespace Phuongtrinhbac2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            double delta,x1,x2;

            Console.Write("\n");
            Console.Write("Giai phuong trinh bac hai\n");

            Console.Write("Nhap gia tri cua a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap gia tri cua b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap gia tri cua c: ");
            c = Convert.ToInt32(Console.ReadLine());

            delta = b * b - 4 * a * c;
            if (delta == 0)
            {
                Console.Write("Phuong trinh co mot nghiem duy nhat.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("Nghiem duy nhat cua phuong trinh la = {0}\n", x1);
            }
            else if (delta > 0)
            {
                Console.Write("Phuong trinh co hai nghiem phan biet\n");

                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x1 = Math.Round(x1, 2);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = Math.Round(x2, 2);
                Console.Write("x1: = {0}\n", x1);
                Console.Write("x2: = {0}\n", x2);
            }
            else
            {
                Console.Write("Phuong trinh vo nghiem\n");

                Console.ReadKey();
            }
        }
    }
}
