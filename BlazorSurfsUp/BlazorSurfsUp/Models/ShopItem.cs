using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSurfsUp.Models
{
    public class ShopItem
    {
        public string Name { get; set; }
        public Type ItemType { get; set; }
        public double Price { get; set; }
        public User Owner { get; set; }
        public ShopItem()
        {

        }
        public ShopItem(string name, Type type, double price)
        {
            Name = name;
            ItemType = type;
            Price = price;
        }
    }
}
