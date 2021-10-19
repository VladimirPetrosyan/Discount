using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 500)
            {
                b = (a * 3) / 100;
                a = a - b;
                Console.WriteLine(a);
              }
            if (a < 500)
            {
                Console.WriteLine(a);
            }
                if (a > 1500) ;
            { 
                b = (a * 5) / 100;
                a = a - b;
                Console.WriteLine(a);
            }
        }
    }
}
