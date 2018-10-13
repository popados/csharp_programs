using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameMain
{
    class Deck
    {
        Random ran = new Random();
        public int deckSize { get; set; }
        public string deckName { get; set; }
        public int creatureCardCount { get; set; }
        public int magicCardCount { get; set; }
        public List<Deck> DeckList { get; set; }
        CardTest card = new CardTest(1, 2);


        public Deck()
        {
            DeckList = new List<Deck>();

            for (int i = 0; i < 13; i++)
            {
                //DeckList.Add(new CardTest(1, 2));

            }

            deckSize = 0; //20 max
            creatureCardCount = 0; //13 max
            magicCardCount = 0; //7 max
            deckName = "Fire Deck";
        }
    }
}



        //class CardTest
        //{
        //    public string CardNameTest;
        //    public string AbilityName;
        //    public int Attack { get; set; }
        //    public int Defense { get; set; }
        //    public int ManaCost;


        //    //Deck card = new CreatureCard();



        //    public void Print()
        //    {
        //        Console.WriteLine("printbase_deck");
        //        //card.Print();
        //    }
        //}







    //public void CreatureCard() {

    //}


    //public class CreatureCard : Deck {
    //    //maybe use xp instead of mana
    //    private string CardName { get; set; }
    //    public int ManaCost { get; set; }
    //    public int Attack { get; set; }
    //    public int Defense { get; set; }
    //    public string CardDesc { get; set; }

    //    public CreatureCard() {

    //    }


    //}
    //public class MagicCard : Deck {
    //    public int ManaCost { get; set; }
    //    public string CardDesc { get; set; }
    //    public string CardName { get; set; }
    //    public bool abilityName { get; set; }


    //    public MagicCard() {

    //    }

    //}


//Little Draco Cost 1 Atk: 1 HP: 1
//Imp Cost 1 Atk: 1 HP: 1
//Spirit of Fire Cost 1 Atk: 1 HP: 2
//Fire Drake Cost 2 Atk: 0 HP: 0 Eff: Initiate: If you have a little draco on the field Gain +1/+1 for each Little Draco on the field.
 
//Spells: 
//Fireball Cost 1: Deal 1 Damage to target commander or creature
//Flamestrike Cost: 2: Deal 1 Damage to 3 creatures
//Wildfire Cost 3:: Deal 2 Damage to all creatures and commanders



//throwing error for recursion?
//add one creature card to list
//creatureCardCount = 0;

//for (int i = 0; i< 13; i++)
//{
//    DeckList.Add(new CreatureCard("Card name " + i));
//    creatureCardCount++;
//}

//do
//{

//} while (creatureCardCount < 12);
