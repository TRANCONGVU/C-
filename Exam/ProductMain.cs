using System;
using System.Collections.Generic;
namespace T1809E_Vu
{
    public class ProductMain
    {
        public static void Main(string[] args)
        {
           
            bool start = true;

            List<Products> listProduct = new List<Products>();
            while (start)
            {
                ShowMenu();
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                    {
                        AddProduct(listProduct);
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine(" ProductID " + " Product Name " + " Price ");
                        foreach (var p in listProduct)
                        {
                            p.DisplayProduct();
                        }
                        break;
                    }

                    case 3:
                    {
                        string n;
                        Console.WriteLine("nhap vao id sp muon xoa :");
                        n = Console.ReadLine();
                        foreach (Products product in listProduct)
                        {
                            if (n == product.ProductId)
                            {
                                listProduct.Remove(product);
                            }
                            Console.WriteLine("nhap sai");
                        }
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
            Console.WriteLine("1 . Add product records");
            Console.WriteLine("2 . Display product records");
            Console.WriteLine("3 . Delete product by Id");
            Console.WriteLine("4 . Exit");
            Console.WriteLine("-------------------");
        }
        static void AddProduct(List<Products> listProduct){
          
            Console.WriteLine("nhap vao ma san pham :");
            string ProductId = Console.ReadLine();
            Console.WriteLine("nhap vao ten san pham:");
            string ProducName = Console.ReadLine();
            Console.WriteLine("Nhap vao gia :");
            float Price = Convert.ToInt32(Console.ReadLine());
            
            Products prd = new Products(ProductId , ProducName , Price);
            listProduct.Add(prd);
            
        }

        
    }
    
}