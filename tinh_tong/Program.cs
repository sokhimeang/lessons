using System;

namespace tinh_tong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, x, giaithua = 1;
            float tong = 0;
            do
            {
                Console.Write("enter n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            do
            {
                Console.Write("enter x: ");
                x = int.Parse(Console.ReadLine());
            } while (x <= 0);          
            for (i = 1; i <= n; i++)
            {
                giaithua *= i;
                tong += (float)(Math.Pow(x, i) / giaithua);               
            }
            Console.Write("tong: {0}",tong);
            Console.ReadLine();
        }
    }
}
