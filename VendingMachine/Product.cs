using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Product
    {
        static int countID = 0;

        public int Id;

        public string name;
        public int cost;

        public Product()
        {
            Id = ++countID;
        }

        public void Purchase()
        {

        }

        public void Use()
        {

        }
    }
}
