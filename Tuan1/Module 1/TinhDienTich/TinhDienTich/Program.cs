using System;

namespace TinhDienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            int nDai, nRong, nchuvi, ndientich;
            Console.WriteLine("\n********Tinh chu vi& dien tich********");
            Console.Write("Nhap vao Chieu Dai:");
            nDai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao Chieu Rong:");
            nRong = Convert.ToInt32(Console.ReadLine());
            nchuvi = (nDai + nRong) * 2;
            ndientich = nDai * nRong;
            Console.WriteLine("Chu vi =" + nchuvi);
            Console.WriteLine("Dien tich =" + ndientich);
            Console.ReadLine();
        }
    }
}
