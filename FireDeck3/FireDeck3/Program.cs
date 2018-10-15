using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDeck3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Card> deck = new List<Card>();
            //create the 7 cards that make the deck
            Card draco = new Card.LittleDraco();
            Card imp = new Card.ImpCard();
            Card fireDrake = new Card.FireDrake();
            Card spiritFire = new Card.SpiritOFire();
            Card fireball = new Card.FireBall();
            Card flameStrike = new Card.FlameStrike();
            Card wildFire = new Card.WildFire();

            deck.Add(draco);
            deck.Add(imp);
            deck.Add(fireDrake);
            deck.Add(spiritFire);
            deck.Add(fireball);
            deck.Add(flameStrike);
            deck.Add(wildFire);



            //put the cards into a list called deck
            //foreach (Card Card in deck)
            //{
            //    Console.WriteLine(Card);
            //    Console.ReadKey();
            //}

            Random ran = new Random();
            int random = ran.Next(1, 9);
            Console.WriteLine(random);
            Console.ReadLine();


        }
        public static void CreateMainStory()
        {
            Console.WriteLine("    |<--- Trading Card Game! --->|");
            Console.WriteLine("|<--- Press Enter to Continue --->|");
            Console.WriteLine();
            Console.ReadKey();
        }

        //function to create cards and add to a list?
    }
}

//~~~~STEPS TO DO FOR TCG~~~//
//Create Deck object
//create player object that takes inputs for other objects
//find out what variables
//i need to figure out a curve for 20 cards with the 7 cards
//8 random 1 cost, 6 random 2 cost, 6 random 3 cost
//create a hand
//create a field
//create a graveyard
//each turn: draw > main phase(play cards to field) > attack phase(move to field from graveyard) > end turn
//loop turn until a player is below 0 health

//start creating program here
//for a card game the steps i need are
//create deck
//create hand
//select card from hand
//play card
//end turn