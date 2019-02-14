using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Drink : Product
    {
        public Drink(string name, int cost, int count)
        {
            this.name = name;
            this.cost = cost;
            this.count = count;
        }
    }
}
