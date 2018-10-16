using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindDeck
{
    class Program
    {
            public bool createDeck = true;
            static void Main(string[] args)
            {

                CreateMainStory();
                Console.SetWindowSize(60, 45);
                Random ran = new Random();
                int random = ran.Next(1, 9);

                List<Card> deck = new List<Card>
            {
                //create the cards that make the deck
                //7 cards and 3 of each
                //chose to create each card individually
                //now I need to to shuffle the deck


                new Pigeon(), new Pigeon(), new Pigeon(),
                new LittleGriff(), new LittleGriff(), new LittleGriff(),
                new SpiritOfWind(), new SpiritOfWind(), new SpiritOfWind(),
                new SkyGriffin(), new SkyGriffin(), new SkyGriffin(),
                new Gale(), new Gale(), new Gale(),
                new Tornado(), new Tornado(), new Tornado(),
                new BirdsOfFeather(), new BirdsOfFeather(), new BirdsOfFeather() };

                foreach (var card in deck)
                {
                    //Console.WriteLine(draco.CardName);
                    Console.WriteLine(card.ToString());
                    // + "\n Card: {0}" , deck.IndexOf(card) + 1
                }

                List<Card> shuffled = new List<Card>();
                List<Card> startHand = new List<Card>();
                List<Card> fieldArea = new List<Card>(5);


                int count = deck.Count();
                int selection = 0;

                for (int i = 0; i < count; i++)
                {
                    selection = ran.Next(deck.Count - 1);
                    shuffled.Add(deck[selection]);
                    deck.RemoveAt(selection);
                }

                Console.WriteLine("~~~~~~SHUFFLING~~~~~~");

                foreach (var card in shuffled)
                {
                    //Console.WriteLine(draco.CardName);
                    Console.WriteLine("Deck number: " + (shuffled.IndexOf(card) + 1) + card.ToString());
                    // + "\n Card: {0}", shuffled.IndexOf(card) + 1)
                }


                //next step is creating the hand

                //ways of creating a deck
                //hard code the deck of 21 with specific cards and use loops to make multiples
                //i need to put the cards into a list and then create a shuffle function to display 3 random card names 
                //to hard code the deck i need to add the number of cards at cost and duplicates
                //21 cards in a deck 
                //3 of each card
                //
                //var deckCount = deck.Count();



                //put the cards into a list called deck
                //foreach (Card Card in deck)
                //{
                //    Console.WriteLine(Card);
                //    Console.ReadKey();
                //}


                //Console.WriteLine(draco);
                //Console.WriteLine(deck.ToString());
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
    //i need to figure out a curve for 21 cards with the 7 cards
    //3 of each card
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
