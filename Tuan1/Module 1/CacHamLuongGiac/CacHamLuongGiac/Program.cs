using System;

namespace CacHamLuongGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***CAC HAM LUONG GIAC***");
            int a;
            double fx;
            Console.Write("nhap vao mot goc:");
            fx = Convert.ToDouble(Console.ReadLine());
            double rad = fx * Math.PI / 180;
            Console.WriteLine("Sin({0})={1}", fx, Math.Sin(rad));
            Console.WriteLine("Cos({0})={1}", fx, Math.Cos(rad));
            Console.WriteLine("Tan({0})={1}", fx, Math.Tan(rad));
            Console.WriteLine("Cot({0})={1}", fx, 1/Math.Tan(rad));
            Console.ReadKey();

        }
    }
}
