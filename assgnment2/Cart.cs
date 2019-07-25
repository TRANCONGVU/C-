using System;
using System.Collections.Generic;

namespace T1809E_Vu
{
    public class Cart
    {
        public int id, granTotal;
        public string customer, city, country;
        
        public List<Product> productsList = new List<Product>();

        public Cart()
        {
            Console.WriteLine("nhap vao ten");
            customer = Console.ReadLine();
            Console.WriteLine("nhap vao thanh pho :");
            city = Console.ReadLine();
            Console.WriteLine("nhap vao country");
            country = Console.ReadLine();
        }

        public Cart(string customer, string city, string country)
        {
            this.customer = Console.ReadLine();
            this.city = Console.ReadLine();
            this.country = Console.ReadLine();
        }
        
        public bool AddProduct(Product p)
        {
            if (!productsList.Contains(p) && p.CheckQty())
            {
                productsList.Add(p);
                p.qty--;
                granTotal += p.price;
                return true;
            }
            Console.WriteLine("san pham da co trong gio hang");
            return false;
        }

        public bool RemoveProduct(Product p)
        {
            if (productsList.Contains(p))
            {
                productsList.Remove(p);
                p.qty++;
                granTotal -= p.price;
                return true;
            }
            Console.WriteLine("k co trong gio hang");
            return false;
        }

        public decimal GetGrandTotal()
        {
            decimal finallTotal = 0;
            if (country == "VN")
            {
                if (city == "HN" || city == "HCM")
                {
                    finallTotal = granTotal * (decimal) 1.01;
                }
                else
                {
                    finallTotal = granTotal * (decimal) 1.02;
                }
            }
            else
            {
                finallTotal = granTotal * (decimal) 1.05;
            }

            return finallTotal;
        }
    }
}