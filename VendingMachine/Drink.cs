using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Drink : Product
    {
        public Drink(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public void Sip()
        {

        }
    }
}
