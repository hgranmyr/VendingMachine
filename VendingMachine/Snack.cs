using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Snack : Product
    {
        public Snack(string name, int cost, int count)
        {
            this.name = name;
            this.cost = cost;
            this.count = count;
        }
    }
}
