using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(AddDrink("Coke", 10));
            products.Add(AddSnack("Snickers", 5));
            products.Add(AddSnack("Pringles", 20));


            Product AddDrink(string name, int cost)
            {
                return new Drink(name, cost);
            }

            Product AddSnack(string name, int cost)
            {
                return new Drink(name, cost);
            }

            /*void RefillMachine()
            {
                bool keepAlive = true;

                while (keepAlive)
                {
                    Console.Clear();
                    Console.WriteLine("1: Add Drink | 2: Add Snack | 0: Back ");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            break;

                        case 2:
                            break;

                        case 0:
                            VendingMachineMenu();
                            break;
                        default:
                            keepAlive = false;
                            break;
                    }
                }



            }  // Refilling vending machine*/



            int moneyPool = 0;



            VendingMachineMenu();





            void VendingMachineMenu()
            {
                
                foreach (var item in products)
                {
                    Console.WriteLine(item.name + " " + item.cost);
                }

                bool keepAlive = true;
                while (keepAlive)
                {
                    Console.WriteLine("1: Shop | | 0: Exit");

                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            PurchaseProduct();
                            break;

                        case 2:
                            break;
                        case 0:
                            keepAlive = false;
                            break;
                        default:
                            keepAlive = false;
                            break;
                    }
                }
            }
            void PurchaseProduct()
            {
                if moneyPool >= 
            }




            int[] value = new int[8];

            value[0] = 1;
            value[1] = 5;
            value[2] = 10;
            value[3] = 20;
            value[4] = 50;
            value[5] = 100;
            value[6] = 500;
            value[7] = 1000;



            Console.ReadKey(true);
        }
    }
}
