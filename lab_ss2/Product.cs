using System;
using System.Collections.Generic;

namespace T1809E_Vu
{
    
    public class Product
    {
        public int id, price, qty;
        public string name, image, desc;
        public List<string> gallery = new List<string>();
        
        public Product()
        {
            Console.WriteLine("nhap ten");
            name = Console.ReadLine();
            Console.WriteLine("anh sp :");
            image = Console.ReadLine();
            Console.WriteLine("nhap id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap gia");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so luong");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" mo ta");
            desc = Console.ReadLine();
            gallery.Add(image);

        }

        public Product(int id, int price, int qty, string desc, string
            name, string image)
        {
            this.id = id;
            this.price = price;
            this.qty = qty;
            this.desc = desc;
            this.name = name;
            this.image = image;
            gallery.Add(image);
        }

        
        
        public void getInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Thong tin san pham : ");
            Console.WriteLine("id :" + id);
            Console.WriteLine("price :" + price + "VND");
            Console.WriteLine("qty :" + qty);
            Console.WriteLine("desc :" + desc);
            Console.WriteLine("name :" + name);
            Console.WriteLine("image :" + image);
            Console.WriteLine("gallery" + gallery);
        }
        
        
        public Boolean  checkQty()
        {
            if ( qty > 0)
            {
                Console.WriteLine("con hang + so luong : " + qty);
                return true;
            }
            else
            {
                Console.WriteLine("het hang");
                return false;
            }
        }

        public void addGallery()
        {
            foreach (string image  in gallery)
            {
                if (image.Length >= 10)
                {
                    Console.WriteLine("so anh dat toi da vui long xoa bot");
                    deleteImg();
                }
                else
                {
                    Console.WriteLine("them anh vao gallery");
                    Console.ReadLine();
                    gallery.Add(image);
                }
            }
            
        }

        public void deleteImg()
        {
            Console.WriteLine("nhap anh muon xoa");
            string i = Console.ReadLine();
            foreach (string image in gallery)
            {
                gallery.Remove(i);
                Console.WriteLine("anh da duoc xoa");
            }
        }

    }
    
}