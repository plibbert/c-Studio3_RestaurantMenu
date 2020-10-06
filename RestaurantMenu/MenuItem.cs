using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private string Name { get; set; }
        private Category Cat { get; set; }
        private double Price { get; set; }
        private string Description { get; set; }
        private bool IsNew { get; set; }

        public MenuItem(string name, Category cat, double price, string description, bool isNew)
        {
            Name = name;
            Cat = cat;
            Price = price;
            Description = description;
            IsNew = isNew;
        }
        }
}
