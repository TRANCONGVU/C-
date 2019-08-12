using System;
using System.Collections.Generic;

namespace T1809E_Vu
{
    public class Products
    {
        public string ProductId;
        public string ProducName;
        public float Price;
        public Products()
        {
            
        }
        
        public Products(string productId, string producName, float price)
        {
            ProductId = productId;
            ProducName = producName;
            Price = price;
        }

        public string ProductId1
        {
            get => ProductId;
            set => ProductId = value;
        }

        public string ProducName1
        {
            get => ProducName;
            set => ProducName = value;
        }

        public float Price1
        {
            get => Price;
            set => Price = value;
        }
        

        public void DisplayProduct()
        {
            Console.WriteLine("---" + ProductId + "-----" + ProducName +"-----" + Price);
            
        }
    }
    
}