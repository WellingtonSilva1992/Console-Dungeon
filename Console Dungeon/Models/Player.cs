using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Dungeon
{
    public class Player
    {
        public bool hasKey = false;
        public bool hasSword = false;
        public bool enemyIsProximity = false;
        public int Life = 10;
        public int Position;
        public int enemyPosition;
    }
}
