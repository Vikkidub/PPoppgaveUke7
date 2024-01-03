using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPoppgaveUke6
{
    public class ClothingItem: InventoryItem, ISellable
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public ClothingItem(string name, int amount, int price, string size, string color)
        {
            Name = name;
            Amount = amount;
            Price = price;
            Size = size;
            Color = color;

        }

    }
}
