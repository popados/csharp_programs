using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDeck
{

    //class and constructor for a single specific card
    class TestImpCard
    {

        //variables for creature card
        public string CardName { get; set; }
        public string CardDescription { get; set; }
        public string AbilityDescription { get; set; }
        public string CardType { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int Cost { get; set; }



        //constructor
        public TestImpCard()
        {
            CardName = "Imp";
            CardDescription = "Totally not a Warlock pet.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 1;
            Health = 1;
            Cost = 1;
        }
        //print method for the card
        public void Print()
        {
            Console.WriteLine("Card: " + CardName + "\n Description: " + CardDescription +
                "\n Ability: " + AbilityDescription + "\n Type: " + CardType + "\n Attack: " + Attack +
                "\n Health: " + Health + "\n Cost: " + Cost);
            Console.WriteLine();
        }

    }
}
