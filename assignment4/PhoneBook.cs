using System;
using System.Collections.Generic;

namespace T1809E_Vu
{
    public delegate void ChangeValue(string s);
    
    public class PhoneBook : Phone
    {
        public event ChangeValue PhoneChage;
        
        public List<PhoneNumber> PhoneList;

        public PhoneBook()
        {
            
        }

        public override bool insertPhone(string name, string phone)
        {
            if (PhoneList == null)
            {
                PhoneList = new List<PhoneNumber>();
            }
            foreach (PhoneNumber n in PhoneList)
            {
                if (n.Name.Equals(name))
                {
                    if (!n.Phone.Equals(phone))
                    {
                        n.Phone += ":" + phone;
                    }
                    return true;
                }
                return false;
            }
            PhoneList.Add(new PhoneNumber(name , phone));
            return true;
        }
        

        public override bool removePhone(string name)
        {
            foreach (PhoneNumber n in PhoneList)
            {
                if (n.Name.Equals(name))
                {
                    PhoneList.Remove(n);
                    if (PhoneChage == null)
                    {
                        PhoneChage += Notify;
                    }

                    PhoneChage("so dien thoai cua "+ name +" da bi thay xoa");
                    return true;
                }
            }
            return false;
        }

        public override bool updatePhone(string name, string newphone)
        {
            foreach (PhoneNumber n in PhoneList)
                
            {
              
                if (n.Name.Equals(name))
                {
                    n.Phone = newphone;
                    if (PhoneChage == null)
                    {
                        PhoneChage += Notify;
                    }

                    PhoneChage("so dien thoai cua "+ name +" da bi thay doi");
                        return true;
                }
               
            }
            return false;
            
        }
        public static void Notify(string s){
            Console.WriteLine(s);
        }

        public static void Delete(string x)
        {
            Console.WriteLine(x);
        }
        
        public override PhoneNumber searchPhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    return p;
                }
            }
            return null;
        }

        public void display()
        {
            foreach (PhoneNumber p in PhoneList)
            {
                Console.WriteLine("ten danh ba :" +p.Name);
                Console.WriteLine("so dien thoai :"+p.Phone);
            }
        }
    }
    
}