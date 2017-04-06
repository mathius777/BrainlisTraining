using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{



    public class Room
    {
        //default constructor
        public Room()
        {
            Symbol = "#";
        }
        //in case we want to override our default room symbol
        public Room(string _Symbol)
        {
            Symbol = _Symbol;
        }

        public String Symbol = "#";

        //public List<Items> ItemsInRoom;
        //ItemsInRoom.Add(new Item(someshit));

    }
}
