using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Dungeon
{
    public class Dungeon
    {
        public static int[,] dungeonSpace = new int[5, 5];
        public int keyPosition = dungeonSpace[2, 3];
        public int swordPostion = dungeonSpace[3, 3];
        public int playerPosition = dungeonSpace[3, 1];
        public int enemyPosition = dungeonSpace[4, 4];
    }
}
