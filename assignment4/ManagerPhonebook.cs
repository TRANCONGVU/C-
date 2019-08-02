using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace T1809E_Vu
{
    public class ManagerPhonebook
    {
        public static void Main(string[] args)
        {
            List<PhoneBook> list = new List<PhoneBook>();
            bool start = true;
            while (start)
            {
                ShowMenu();
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                    {
                        InsertPhone(list);
                        break;
                    }

                    case 2:
                    {
                        RemovePhone(list);
                        break;
                    }

                    case 3:
                    {
                        UpdatePhone(list);
                        break;
                    }

                    case 4:
                    {
                        SearchPhone(list);
                        break;
                    }
                    case 5:
                    {
                        start = false;
                        break;
                    }
                    
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Chon chuc nang");
            Console.WriteLine("1 . insert phone");
            Console.WriteLine("2 . Remove Phone");
            Console.WriteLine("3 . Update Phone");
            Console.WriteLine("4 . Search Phone");
            Console.WriteLine("--------------------");
            
        }

        static void InsertPhone(List<PhoneBook> list)
        {
         Console.WriteLine("Nhap name");
         string name = Console.ReadLine();
         Console.WriteLine("Nhap so dien thoai");
         string phone = Console.ReadLine();
         PhoneBook p = new PhoneBook();
         if (p.insertPhone(name, phone))
         {
             list.Add(p);
         }
        }

        static void RemovePhone(List<PhoneBook> list)
        {
            Console.WriteLine("nhap ten muon xoa");
            string name = Console.ReadLine();
            foreach (PhoneBook p in list)
            {
                p.removePhone(name);
            }
            
        }

        static void SearchPhone(List<PhoneBook> list)
        {
            Console.WriteLine("nhap ten muon tim");
            string name = Console.ReadLine();
            foreach (PhoneBook p in list)
            {
                p.searchPhone(name);
                p.display();
            }
            
        }

        static void UpdatePhone(List<PhoneBook> list)
        {
            Console.WriteLine("nhap ten");
            string name = Console.ReadLine();
            Console.WriteLine("nhap so dien thoai moi");
            string newphone = Console.ReadLine();
            foreach (PhoneBook p in list)
            {
                p.updatePhone(name, newphone);
                p.display();
            }

        }

    }
}