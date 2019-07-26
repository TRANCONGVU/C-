using System;
using System.Collections.Generic;
using System.Net.Mime;

namespace T1809E_Vu
{
    public class News : Inews
    {
        public int id;
        public string title;
        public string PublishDate;
        public string Author;
        public string Content;
       
        
        int[] RateList = new int[3];

        public News()
        {
            
        }
        public News(int id , string title , string PublishDate , string Author , string Content )
        {
            this.id = id;
            this.title = title;
            this.PublishDate = PublishDate;
            this.Author = Author;
            this.Content = Content;
        }

        public float AverateRate
        {
            get => AverateRate;
            set => AverateRate = value;
        }
        
        public int this[int index]
        {
            get { return RateList[index]; }
            set
            {
                if (value <= 5 && value >= 1)
                {
                    RateList[index] = value;
                }
                else if(value < 1)
                {
                    RateList[index] = 1;
                }
                else if(value > 5)
                {
                    RateList[index] = 5;
                }
            }
        }
        
        public void Display()
        {
            
            Console.WriteLine("id :" +id);
            Console.WriteLine("title :" + title);
            Console.WriteLine("PublishDate :" + PublishDate);
            Console.WriteLine("Author :" + Author);
            Console.WriteLine("Content :" + Content);
            Console.WriteLine("AverateRate :" + AverateRate);
        }
        
        public void Calculate()
        {
            int total = 0;
            foreach (int rate in RateList)
            {
                total += rate;
            }

            AverateRate = (float)total / 3;
            Console.WriteLine("Gia tri rate la :" + AverateRate);
        }
    }
}