using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace T1809E_Vu
{
    public class assgnment6
    {
        static bool stop = false;

        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap vao");
            n = Convert.ToInt32(Console.ReadLine());


            Thread t2 = new Thread(Fibonaci);
            t2.Start(n);
            
            Thread t1 = new Thread(CountTime);
            t1.Start();

        }

        static void CountTime()
        {
            for (int i = 0; i >= 0; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    Console.WriteLine("thoi gian " + i.ToString("D2") + ":" + j.ToString("D2"));
                    Thread.Sleep(1000);
                    if (stop) break;
                }

                if (stop) break;

            }

            
        }

        static void Fibonaci(object o)
        {
            int n = (int) o;
            int n1 = 1, n2 = 1, n3 = 2; 
            for (int i=0 ; n1+n2 < n ; i++)
            {
                n3 = n2 + n1;
                n1 = n2;
                n2 = n3;
                
                Console.WriteLine(n3);
                Thread.Sleep(100);
            }

            stop = true;

        }

    }
}