using System;

namespace sum_of_charactor_number
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            Console.Write("enter n: ");
            n = uint.Parse(Console.ReadLine());
            uint sum = 0, m;

            Console.Write("result= ");
            while (n != 0)
            {
                m = n % 10;
                sum += n % 10;
                if (n < 10)
                {
                    Console.Write("{0} = ", m);
                }
                else
                {
                    Console.Write("{0} + ", m);
                }
                n /= 10;
            }           
            Console.Write("{0}", sum);
            Console.ReadLine();
        }
    }
}
