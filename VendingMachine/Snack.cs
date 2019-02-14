using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Snack : Product
    {
        public Snack(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public void Eat()
        {

        }
    }
}
