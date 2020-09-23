using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Console_Dungeon
{
    public class Player
    {        
        public bool hasKey { get; set; } = false;
        public bool hasSword { get; set; } = false;        
        public int life { get; set; } = 10;        
        
    }
}
