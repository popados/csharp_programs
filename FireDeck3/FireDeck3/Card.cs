﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDeck3
{
    class Card
    {
        //variables for cards
        private string CardName { get; set; }
        private string CardDescription { get; set; }
        private string AbilityDescription { get; set; }
        private string CardType { get; set; }
        private int Attack { get; set; }
        private int Health { get; set; }
        private int Cost { get; set; }
        private bool isDead { get; set; }
        private bool summonSickness { get; set; }


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
            summonSickness = true;
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
                isDead = false;
                summonSickness = true;
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
                isDead = false;
                summonSickness = true;
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
                isDead = false;
                summonSickness = true;
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
                isDead = false;
                summonSickness = true;
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
                isDead = false;
                summonSickness = true;
            }

        }
        public class FlameStrike : Card
        {
            public FlameStrike()
            {
                CardName = "Flamestrike";
                CardDescription = "Fire strikes the earth.";
                AbilityDescription = "1 damage three times to random enemies.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 3;
                isDead = false;
                summonSickness = true;
            }
        }
        public class WildFire : Card
        {
            public WildFire()
            {
                CardName = "Wildfire";
                CardDescription = "Uncontrollable flames.";
                AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 2;
                isDead = false;
                summonSickness = true;
            }
        }
        public class Pigeon : Card
        {
            public Pigeon()
            {
                CardName = "Wildfire";
                CardDescription = "Uncontrollable flames.";
                AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 2;
                isDead = false;
                summonSickness = true;
            }
        }
        public class LittleGriff : Card
        {
            public LittleGriff()
            {
                CardName = "Wildfire";
                CardDescription = "Uncontrollable flames.";
                AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 2;
                isDead = false;
                summonSickness = true;
            }
        }
        public class SpiritOfWind : Card
        {
            public SpiritOfWind()
            {
                CardName = "Wildfire";
                CardDescription = "Uncontrollable flames.";
                AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 2;
                isDead = false;
                summonSickness = true;
            }
        }
        public class SkyGriffin : Card
        {
            public SkyGriffin()
            {
                CardName = "Wildfire";
                CardDescription = "Uncontrollable flames.";
                AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 2;
                isDead = false;
                summonSickness = true;
            }
        }
        public class Gale : Card
        {
            public Gale()
            {
                CardName = "Wildfire";
                CardDescription = "Uncontrollable flames.";
                AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 2;
                isDead = false;
                summonSickness = true;
            }
        }
        public class Tornado : Card
        {
            public Tornado()
            {
                CardName = "Wildfire";
                CardDescription = "Uncontrollable flames.";
                AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 2;
                isDead = false;
                summonSickness = true;
            }
        }
        public class BirdsOfFeather : Card
        {
            public BirdsOfFeather()
            {
                CardName = "Wildfire";
                CardDescription = "Uncontrollable flames.";
                AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
                CardType = "Spell";
                Attack = 0;
                Health = 0;
                Cost = 2;
                isDead = false;
                summonSickness = true;
            }
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
        public void Name() {
            Console.WriteLine("Name: " + CardName);
        }

    }
}
//public void attackEnemy(Avatar target)
 //{
//    target.Health -= Attack;
//}
