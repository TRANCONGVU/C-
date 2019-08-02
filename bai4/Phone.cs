using System;
namespace T1809E_Vu
{
    public abstract class Phone
    {
        public abstract bool insertPhone(string name, string phone);
        public abstract bool removePhone(String name);
        public abstract bool updatePhone(String name, String newphone);
        public abstract PhoneNumber searchPhone(String name);

    }
}