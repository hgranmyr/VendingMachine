using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            void VendingMachineMenu()
            {
                ShowProducts();

                bool keepAlive = true;
                while (keepAlive)
                {
                    Console.WriteLine("1: Shop | 2: Refill | 0: Exit");

                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            PurchaseProduct();
                            break;

                        case 2:
                            RefillMachine();
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
                ShowProducts();
            }

            void RefillMachine()
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
                            products.Add(AddDrink());
                            break;

                        case 2:
                            products.Add(AddSnack());
                            break;

                        case 0:
                            VendingMachineMenu();
                            break;
                        default:
                            keepAlive = false;
                            break;
                    }
                }

                Product AddDrink()
                {
                    string name = Console.ReadLine();
                    int cost = Convert.ToInt32(Console.ReadLine());
                    int count = Convert.ToInt32(Console.ReadLine());
                    return new Drink(name, cost, count);
                }

                Product AddSnack()
                {
                    string name = Console.ReadLine();
                    int cost = Convert.ToInt32(Console.ReadLine());
                    int count = Convert.ToInt32(Console.ReadLine());
                    return new Drink(name, cost, count);
                }


            }  // Refilling vending machine

            void ShowProducts()
            {
                foreach (var item in products)
                {
                    Console.WriteLine(item.name + item.cost + item.count);
                }

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


            VendingMachineMenu();

            Console.ReadKey(true);
        }
    }
}
