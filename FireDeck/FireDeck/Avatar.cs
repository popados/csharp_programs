using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDeck
{
    class Avatar
    {
        public string Name { get; set; }
        public int Health { get; set; }
        //private int Attack { get; set; }
        private int ManaCount { get; set; }

        public Avatar(string _name) {
            Name = _name;
            Health = 15;
            //Attack = 2;
            ManaCount = 5;
        }
        public void PrintStats() {
            Console.WriteLine("Name: " + Name + "\n Health: " + Health);
            Console.ReadKey();
        }
    }
}
