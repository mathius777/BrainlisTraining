using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Player : MovableEntity
    {
        public Player()
        {
            X = 0;
            Y = 0;
            HP = 10;
            Symbol = "P";
        }
        public Player(int _hp,int _x, int _y)
        {
            X = _x;
            Y = _y;
            HP = _hp;
            Symbol = "P";
        }
 
  
    }


}
