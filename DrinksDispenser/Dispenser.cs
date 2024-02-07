using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksDispenser
{
    internal class Dispenser
    {

        private Dictionary<Beverage, int> inventory = new Dictionary<Beverage, int>();

        private float money = 0f;

        public Dispenser()
        {
            //nothing to do atm
        }

        public void LoadMachine(Beverage beverageToLoad, int quantity)
        {
            // if we already have a slot for this product
            if (inventory.ContainsKey(beverageToLoad))
            {
                inventory[beverageToLoad] += quantity;
            }
            // otherwise create a new slot
            else
            {
                inventory.Add(beverageToLoad, quantity);
            }
        }

        public Beverage BuyDrink(Beverage beverageToBuy)
        {
            // if therre is such a drink
            if (inventory.ContainsKey(beverageToBuy))
            {
                // is the quantity larger than 0?
                if (inventory[beverageToBuy] < 0)
                {
                    inventory[beverageToBuy] -= 1;
                    Console.WriteLine("You just bought yourself a " +
                        $"{beverageToBuy.ProductName}");
                    return beverageToBuy;
                }
                // no product left
                else
                {
                    Console.WriteLine($"Sorry! We don't have {beverageToBuy.ProductName} atm :(");
                }
            }
            // product not sold in this establishment
            else
            {
                Console.WriteLine($"Sorry, we don't sell {beverageToBuy.ProductName}");
            }

            // nothing to return, so turn in empty
            return null;

        }

        public override string ToString()
        {
            string productsOnSale = "This machine contains the following:\n";
            foreach (Beverage beverage in inventory.Keys)
            {
                productsOnSale += $"{beverage.ProductName}: {inventory[beverage]} units\n";
            }
            return productsOnSale;
        }


    }
}
