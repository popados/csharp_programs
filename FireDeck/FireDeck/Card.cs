using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDeck
{
    //this is created as certain cards respectively to card object and using constructors to make a method that fills the properties
    class Card
    {
        //variables for cards
        public string CardName { get; set; }
        public string CardDescription { get; set; }
        public string AbilityDescription { get; set; }
        public string CardType { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int Cost { get; set; }
        public bool isDead { get; set; }


        //constructor // maybe use this with arguments to change values of each card
        public Card()
        {

            //change these to new variables that get privates and set public for main class
            CardName = "Card Name";
            CardDescription = "Card Description";
            AbilityDescription = "N/A";
            CardType = "Creature or Spell";
            Attack = 0;
            Health = 0;
            Cost = 0;
            isDead = false;
        }
        public void Print()
        {
            Console.WriteLine("Card: " + CardName +
                "\n Description: " + CardDescription +
                "\n Ability: " + AbilityDescription +
                "\n Type: " + CardType +
                "\n Attack: " + Attack +
                "\n Health: " + Health +
                "\n Cost: " + Cost);
            Console.WriteLine();
            Console.ReadKey();
        }
        public class ImpCard : Card
        {
            public ImpCard()
            {
                CardName = "Imp";
                CardDescription = "Totally not a Warlock pet.";
                AbilityDescription = "N/A";
                CardType = "Creature";
                Attack = 3;
                Health = 1;
                Cost = 1;
            }
        }
        public class LittleDraco : Card
        {
            public LittleDraco()
            {
                CardName = "Little Draco";
                CardDescription = "Small Dragon";
                AbilityDescription = "N/A";
                CardType = "Creature";
                Attack = 1;
                Health = 3;
                Cost = 1;
            }
        }
        //spirit of fire card
        public class SpiritOFire : Card
        {

            public SpiritOFire()
            {
                CardName = "Spirit Of Fire";
                CardDescription = "Its the spirit of da fire, mon.";
                AbilityDescription = "N/A";
                CardType = "Creature";
                Attack = 3;
                Health = 4;
                Cost = 2;
            }
        }
        //class for fire drake card
        public class FireDrake : Card
        {
            //constructor
            public FireDrake()
            {
                CardName = "Fire Drake";
                CardDescription = "Big Big Dragon.";
                AbilityDescription = "+1/+1 for each Little Draco in play.";
                CardType = "Creature";
                Attack = 5;
                Health = 3;
                Cost = 3;
            }
        }
        public class FireBall : Card
        {
            public FireBall()
            {
                CardName = "Fireball";
                CardDescription = "Fire in your face.";
                AbilityDescription = "Deal 1 damage to target creature/commander.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 1;
            }

        }
        public class FlameStrike : Card
        {
            public FlameStrike()
            {
                CardName = "Flamestrike";
                CardDescription = "Fire strikes the earth.";
                AbilityDescription = "1 Damage to three creatures.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 2;
            }
        }
        public class WildFire : Card
        {
            public WildFire()
            {
                CardName = "Wildfire";
                CardDescription = "Uncontrollable flames.";
                AbilityDescription = "Deal 2 damage to all creatures and commanders.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 3;
            }

        }
    }
}
