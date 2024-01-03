using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPoppgaveUke6
{
    internal class ElectronicItem: InventoryItem
    {
        public int Warranty {  get; set; }
        public int Kilowatt {  get; set; } 
        public ElectronicItem(string name, int amount, int price, int warranty, int kilowatt)
        {
            Name = name;
            Amount = amount;
            Price = price;
            Warranty = warranty;
            Kilowatt = kilowatt;
        }
    }
}
