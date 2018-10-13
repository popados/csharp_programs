using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameMain
{
    class Player
    {
        public int playerHealth;
        public int turnCount;
        public Player() {
            playerHealth = 15;
            turnCount = 0;           
        }
    }
}
