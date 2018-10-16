using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDeck
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
    public class Mino : Card
    {
        //string CardName = "Imp";
        //string CardDescription = "Totally not a Warlock pet.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 1;
        //int Cost = 1;
        public Mino()
        {
            CardName = "Mino";
            CardDescription = "The Smallest Fish.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 0;
            Health = 1;
            Cost = 1;
        }
    }
    public class LittleSerpent : Card
    {
        //string CardName = "Imp";
        //string CardDescription = "Totally not a Warlock pet.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 1;
        //int Cost = 1;
        public LittleSerpent()
        {
            CardName = "Little Serpent";
            CardDescription = "Youngin' Water Drako.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 1;
            Health = 3;
            Cost = 1;
        }
    }
    public class SpiritOWater : Card
    {
        //string CardName = "Imp";
        //string CardDescription = "Totally not a Warlock pet.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 1;
        //int Cost = 1;
        public SpiritOWater()
        {
            CardName = "Spirit Of Water";
            CardDescription = "Surfs Up d00d.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 3;
            Cost = 2;
        }
    }
    public class WaterDragon : Card
    {
        //string CardName = "Imp";
        //string CardDescription = "Totally not a Warlock pet.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 1;
        //int Cost = 1;
        public WaterDragon()
        {
            CardName = "Water Dragon";
            CardDescription = "Might one day be threating.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 1;
            Cost = 1;
        }
    }
    public class Crash : Card
    {
        //string CardName = "Imp";
        //string CardDescription = "Totally not a Warlock pet.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 1;
        //int Cost = 1;
        public Crash()
        {
            CardName = "Crash";
            CardDescription = "Wave smacks you in the face.";
            AbilityDescription = "+1/+0 to each creature til next turn.";
            CardType = "Spell";
            Attack = 0;
            Health = 0;
            Cost = 1;
        }
    }
    public class EyeOfTheStorm : Card
    {
        //string CardName = "Imp";
        //string CardDescription = "Totally not a Warlock pet.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 1;
        //int Cost = 1;
        public EyeOfTheStorm()
        {
            CardName = "Eye of The Storm";
            CardDescription = "Can't see the beach now, bruh.";
            AbilityDescription = "N/A";
            CardType = "Spell";
            Attack = 0;
            Health = 0;
            Cost = 2;
        }
    }
    public class Maelstrom : Card
    {
        //string CardName = "Imp";
        //string CardDescription = "Totally not a Warlock pet.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 1;
        //int Cost = 1;
        public Maelstrom()
        {
            CardName = "Maelstrom";
            CardDescription = "You can't do anything.";
            AbilityDescription = "Opponent can't attack.";
            CardType = "Spell";
            Attack = 0;
            Health = 0;
            Cost = 3;
        }
    }

}

//Mino	0	1	1	The Smallest Fish	Creature	Rally: Up to 2 Minos from your deck each mino gets +1/+0
//Little Serpent  1	3	1	A young water dragon    Creature
//SpiritOWater 3	3	2	Surfs up    Creature
//Water Dragon	4	3	3	Might one day be a threat   Creature Penetrate
//Crash n/a n/a	1	When a wave smacks you Spell   Give +1/0 to each creature on the field until the end of the turn.
//Eye of the Storm n/a n/a 2	You can see everything  Spell Discard one card from your opponents hand
//Maelstrom n/a n/a 3	You can't do anything	Spell	Your opponent cannot attack you for one turn