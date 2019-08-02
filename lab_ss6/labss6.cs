using System;
using System.Threading;

namespace T1809E_Vu
{
    public class labss6
    {
        public static void Main(string[] args)
        {
           Thread t1 = new Thread(CountDown);
           t1.Start();
        }

        public static void CountDown()
        {
            for (int i=9 ; i >= 0 ; i-- )
            {
                for (int j = 59; j >= 0; j--)
                {
                    Console.WriteLine("thoi gian --" + i.ToString("D2") + ":" + j.ToString("D2"));
                    Thread.Sleep(1);
                }
            }
            Console.WriteLine("ahihihihi");
        }
    }
}