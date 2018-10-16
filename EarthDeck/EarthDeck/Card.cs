using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthDeck
{
    public class Card
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
        public bool summonSickness { get; set; }

        //constructor for cards with default values
        //all cards are created as Card card = new CardName();
        //all commented out code between class and constructor in inheirented classes is for saving
        public Card()
        {
            CardName = "Card Name";
            CardDescription = "Card Description";
            AbilityDescription = "N/A";
            CardType = "Creature or Spell";
            Attack = 0;
            Health = 0;
            Cost = 0;
        }
        public override string ToString()
        {
            return ":--" + CardName + "--:";
            //+ "\t Mana Cost: " + Cost
        }
    }
        public class ArmoredToad : Card
        {
            public ArmoredToad()
            {
                CardName = "Armoured Toad";
                CardDescription = "A sturdy creature.";
                AbilityDescription = "Defender";
                CardType = "Creature";
                Attack = 1;
                Health = 3;
                Cost = 1;
            }
    }
        public class LittleHatchling : Card
        {
            public LittleHatchling()
            {
                CardName = "Little Hatchling";
                CardDescription = "A young tortoise.";
                AbilityDescription = "Rally up to 1 Little Hatchling";
                CardType = "Creature";
                Attack = 1;
                Health = 2;
                Cost = 1;
            }
    }
        public class SpiritOfEarth : Card
        {
            public SpiritOfEarth()
            {
                CardName = "Spirit of Earth";
                CardDescription = "Hide behind it.";
                AbilityDescription = "Defender";
                CardType = "creature";
                Attack = 2;
                Health = 3;
                Cost = 2;
            }
    }
        public class TortoiseChief : Card
        {
            public TortoiseChief()
            {
                CardName = "Tortoise Chief";
                CardDescription = "Strong and resolute.";
                AbilityDescription = "Aura/Defender";
                CardType = "Creature";
                Attack = 2;
                Health = 4;
                Cost = 2;
            }
    }
        public class Quake : Card
        {
            public Quake()
            {
                CardName = "Quake";
                CardDescription = "My eyes!";
                AbilityDescription = "Deal 1 damage to all enemy creatures.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 1;
            }
    }
        public class TortoiseShell : Card
        {
            public TortoiseShell()
            {
                CardName = "Tortoise Shell";
                CardDescription = "A powerful defensive item.";
                AbilityDescription = "Give a creature +2/2 for the turn";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 2;
            }
    }
        public class SwampArmy : Card
        {
            public SwampArmy()
            {
                CardName = "Swamp Army";
                CardDescription = "The unites of the earth unite.";
                AbilityDescription = "Give all your creatures +1/1.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 3;
        }
    }
}
