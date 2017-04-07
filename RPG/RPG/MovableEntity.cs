using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    //can be any entity(player, mob), that can move
    public abstract class MovableEntity
    {
        public enum Movement
        {
            NORTH=0,
            EAST,
            SOUTH,
            WEST
        }

        public int HP { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public String Symbol { get; set; }


        public void Render()
        {
            Console.SetCursorPosition(X,Y);
            Console.Write(Symbol);
        }

        public void Move(Movement movement)
        {
            Console.WriteLine("");

            if (movement == Movement.NORTH)
            {
                //move north
                Console.WriteLine("Moved North");
                X++;
            }

        }

         
    }

}
