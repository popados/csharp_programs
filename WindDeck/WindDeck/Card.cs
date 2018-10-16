using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindDeck
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
    public class Pigeon : Card
    {
        public Pigeon() {
            CardName = "Pigeon";
            CardDescription = "Stupid bird.. Pidgey is cooler.";
            AbilityDescription = "Initiate: Deal 1 damage equal to the number of Pigeons on the field.";
            CardType = "Creature";
            Attack = 1;
            Health = 2;
            Cost = 1;
        }
    }
    public class LittleGriff : Card
    {
        public LittleGriff() {
            CardName = "Little Griff";
            CardDescription = "Yung Griffin.";
            AbilityDescription = "N/A.";
            CardType = "Creature";
            Attack = 2;
            Health = 1;
            Cost = 1;
        }
    }
    public class SpiritOfWind : Card
    {
        public SpiritOfWind()
        {
            CardName = "Spirit Of Wind";
            CardDescription = "Fly like the Eagle.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 2;
            Health = 4;
            Cost = 2;
        }
    }
    public class SkyGriffin : Card
    {
        public SkyGriffin() {
            CardName = "Sky Griff";
            CardDescription = "When the lil' ones grow their WINGS!";
            AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
            CardType = "Spell";
            Attack = 5;
            Health = 2;
            Cost = 2;
        }
    }
    public class Gale : Card
    {
        public Gale() {
            CardName = "Gale";
            CardDescription = "Strong winds.";
            AbilityDescription = "Give a creature Hyper.";
            CardType = "Spell";
            Attack = 0;
            Health = 0;
            Cost = 1;
        }
    }
    public class Tornado : Card
    {
        public Tornado() {
            CardName = "Tornado";
            CardDescription = "Powerful destructive winds.";
            AbilityDescription = "Force: Can return an opponent's creature to their hand.";
            CardType = "Spell";
            Attack = 0;
            Health = 0;
            Cost = 2;
        }
    }
    public class BirdsOfFeather : Card
    {
        public BirdsOfFeather() {
            CardName = "Birds Of a Feather";
            CardDescription = "They flock together.";
            AbilityDescription = "Rally units up to the cost of this card from your deck.";
            CardType = "Spell";
            Attack = 0;
            Health = 0;
            Cost = 2;
        }
    }
}
