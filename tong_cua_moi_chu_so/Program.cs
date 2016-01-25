using System;


namespace tong_cua_chu_so
{
    class Program
    {
        static void Main(string[] args)
        {
                
            int n, k = 0;
            Console.Write("enter n: ");
            n = int.Parse(Console.ReadLine());
            int n1 = n;
            while (n1 >= 1)
            {
                k++;
                n1 /= 10;
            }
            Console.Write("result: ");
            double m;
            int sum = 0;
            while (n > 1)
            {
                k--;
                m = (Math.Pow(10, k));
                
                if (n < 10)
                {
                    Console.Write("{0} = ", (int)(n / m));
                }
                else
                {
                    Console.Write("{0} + ", (int)(n / m));
                }
                sum += (int)(n / m);
                n = n - (int)(m * (int)(n / m));                            
            }
            Console.Write("{0}", sum);
            Console.ReadLine();

        }
    }
}
