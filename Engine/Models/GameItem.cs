using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public GameItem(int itemTypeID, string name, int price)
        {
            itemTypeID = ItemTypeID;
            name = Name;
            price = Price;

        }

        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price);
        }


    }
}
