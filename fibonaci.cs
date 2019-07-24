using System;

namespace T1809E_Vu
{
    public class fibonaci
    {
        public static void Main(String[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            checkFibonaci(n);
        }

        public static void checkFibonaci(int n)
        {
            
            int n1 = 1;
            int n2 = n1;
            int n3 = n2 + n1;
            for (int i = 1; i <= n; i++)
            {
                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;
            }
            Console.WriteLine(n3 + " la so fibonaci thu " + n );
            
        }
    }
}