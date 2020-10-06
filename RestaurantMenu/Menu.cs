using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; }

        public Menu (List<MenuItem> item, DateTime lastUpdated)
        {
            Items = item;
            LastUpdated = lastUpdated;
        }
    }
}
