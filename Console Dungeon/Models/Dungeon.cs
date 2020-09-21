using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Dungeon
{
    public class Dungeon
    {
        public static int[,] dungeonSpace = new int[5, 5];
        public int keyPosition = dungeonSpace[5, 1];
        public int swordPostion = dungeonSpace[5, 5];
        public int playerPosition = dungeonSpace[5, 5];
        public int enemyPosition = dungeonSpace[5, 5];
    }
}
