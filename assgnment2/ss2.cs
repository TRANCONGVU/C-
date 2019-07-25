using System;
using System.Collections.Generic;

namespace T1809E_Vu
{
    public class ss2
    {
        public static void Main(string[] args)
        {
            Product product = new Product(1 , 123 , 12 , "hang moi ve" , "san pham 1" , "anh 1" );
            product.getInfo();
            product.CheckQty();
            product.AddGallery("hihi");
            
            Cart myCart = new Cart("TEN" , "HN" , "VN");
            myCart.AddProduct(product);
            myCart.GetGrandTotal();
        }
    }
}