using System;
using System.Collections.Generic;

namespace T1809E_Vu
{
    internal class Program
    {
        public static int age;
        public int year;
        public const int day = 7;
        
        public static void Main(string[] args)
        {
            int x;
            string a;
            a = Console.ReadLine();
            x = Convert.ToInt32(Console.ReadLine());
            double y;
            y = Convert.ToDouble(Console.ReadLine());
            
            

            if (x >= 10)
            {
                Console.WriteLine(x + ">= 10 " + a);
            }
            else
            {
                Console.WriteLine(x + " < 10 "  + a);
            }
          Console.WriteLine(a);   
          
          List<int> intArr = new List<int>();
          
          intArr.Add(item:2);
          intArr.Add(item:1);
          
          List<string> strArr = new List<string>();
          strArr.Add(item:"hello");
          strArr.Add(item:"world");
          strArr.Add(item:"everyone !!!");

          foreach (string str in strArr)
          {
              Console.WriteLine(str);
          }
        }
    }
}