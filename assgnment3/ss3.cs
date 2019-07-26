using System;
using System.Collections.Generic;

namespace T1809E_Vu
{
    public class ss3
    {
        public static void Main(string[] args)
        {
            bool start = true;

            List<News> list = new List<News>();
            while (start)
            {
                ShowMenu();
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                    {
                        InsertNew(list);
                        break;
                    }

                    case 2:
                    {
                        ListNews(list);
                        break;
                    }

                    case 3:
                    {
                        break;
                    }

                    case 4:
                    {
                        start = false;
                        break;
                    }
                }
                
            }
            
            
            

        }

        static void ShowMenu()
        {
            Console.WriteLine("1 . insert news");
            Console.WriteLine("2 . view list new");
            Console.WriteLine("3 . Avenrfe rate");
            Console.WriteLine("4 . Exit");
            Console.WriteLine("-------------------");
        }

        static void InsertNew(List<News> list)
        {
            Console.WriteLine("nhap id :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap title :");
            string title = Console.ReadLine();
            Console.WriteLine("nhap date :");
            string PublishDate = Console.ReadLine();
            Console.WriteLine("Author :");
            string Author = Console.ReadLine();
            Console.WriteLine("Content:");
            string Content = Console.ReadLine();
            
            News ns = new News(id , title , PublishDate , Author , Content);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("nhap vao danh gia so" + i);
                ns[i] = Convert.ToInt32(Console.ReadLine());
            }
            list.Add(ns);
        }

        static void ListNews(List<News> list)
        {
            foreach (News n in list)
            {
                n.Display();
            }
        }

        static void AvgRate(List<News> list)
        {
            foreach (News n in list)
            {
                n.Calculate();
                n.Display();
            }
        }
        
    }
}