using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDeckTest
{
    //
    //Objects needed for TCG Battle System:
    //Card[x]
    //Deck[x] - shuffling done
    //Hand[x] - idea is to remove from shuffled[deck.Count-1] and add to hand list
    //drawCards[x] - need to refactor into methods that call the lists after they are made
    //Play Area[x] -- remove from hand and add to play area(no larger than 5)
    //Graveyard[]
    //player avatar card[x]
    //enemy avatar card[]
    //attack conditions[]
    //mana cost and counting[]
    //turns[]
    class Program
    {
        public bool createDeck = true;
        static void Main(string[] args)
        {
            Console.SetWindowSize(65, 50);
            CreateMainStory();

            //using lists for each of the areas areas 
            List<Card> shuffled = new List<Card>();
            List<Card> startHand = new List<Card>();
            List<Card> fieldArea = new List<Card>(5);
            List<Card> graveyardArea = new List<Card>();
            //create the enemy avatar
            Card enemy = new Avatar();

            List<Card> deck = new List<Card>
            {
            //deck created with card objects
                new ImpCard(), new ImpCard(), new ImpCard(),
                new LittleDraco(), new LittleDraco(), new LittleDraco(),
                new SpiritOFire(), new SpiritOFire(), new SpiritOFire(),
                new FireDrake(), new FireDrake(), new FireDrake(),
                new FireBall(), new FireBall(), new FireBall(),
                new FlameStrike(), new FlameStrike(), new FlameStrike(),
                new WildFire(), new WildFire(), new WildFire() };

            foreach (var card in deck) //print deck
            {
                //Console.WriteLine(draco.CardName);
                Console.WriteLine(card.ToString());
                // + "\n Card: {0}" , deck.IndexOf(card) + 1
            }
            //turn based system
            //use card for the object constructor for both the player and the target
            //steps to take for a single turn
            //draw[x]
            //select card[x]
            //show field(use field)[]
            //end turn[x]


            //->if creature summonedSickness = false 
            //-- ask if they want to attack
            //->if spell cast it or go back to hand
            //->if creature select to play or go back to hand
            //-->same steps for player 2

            //show player health and mana crystals(have 1 at the start, mana++ each looping turn to a max of 5) 
            //have main loop be while (enemy.hp || player.hp > 0)  { // do logic}
            //inside the main loop have a while (mana < 5) { mana++; }
            //conditions of player.draw == true && player.playCard == true && player.endTurn??
            //or give player options and use conditions to say playing this card isnt possible?
            //
            //maybe do a turn one bool
            //one single turn is draw > pick > play > show field > pick > attack > end
            //Second turn > automate the steps with the idea that the AI will play one > two > three mana costs
            //OR I can do player turn and have player input
            shuffleFunction(deck, shuffled);
            //hand print statement
            //Console.WriteLine("~~~~~~Your Hand~~~~~~");
            createHand(shuffled, startHand);

            //first turn selection
            isFirstTurn(startHand, shuffled);
            printHand(startHand);

            //hand selection
            handSelection(startHand, fieldArea, enemy);

            Console.WriteLine("*FIELD AREA*");

            Console.WriteLine();
            foreach (var card in fieldArea)
            {
                Console.WriteLine("Field slot {0}: " + card.CardName, fieldArea.IndexOf(card) + 1);
            }

            Console.WriteLine("End turn? Press 1 for yes 2 for no.");
            var input = Console.ReadLine();
            Int32.TryParse(input, out int result);
            switch (result)
            {
                case 1:
                    break;
                case 2:
                    handSelection(startHand, fieldArea, enemy);
                    break;
                default:
                    Console.WriteLine("nothing here");
                    //ends
                    break;
            }
            Console.ReadKey();
        }


        public static void CreateMainStory()
        {
            Console.WriteLine("    |<--- Trading Card Game! --->|");
            Console.WriteLine("|<--- Press Enter to Continue --->|");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void shuffleFunction(List<Card> deck, List<Card> shuffled) {

            Random ran = new Random();

            int count = deck.Count();
            int selection = 0;

            for (int i = 0; i < count; i++)
            {
                selection = ran.Next(deck.Count - 1);
                shuffled.Add(deck[selection]);
                deck.RemoveAt(selection);
            }

            //shuffled deck
            Console.WriteLine("~~~~~~SHUFFLED~~~~~~");

            //dont need to print deck
            //foreach (var card in shuffled)
            //{
            //    //Console.WriteLine(draco.CardName);
            //    Console.WriteLine("Deck number: " + (shuffled.IndexOf(card) + 1) + card.ToString());
            //    // + "\n Card: {0}", shuffled.IndexOf(card) + 1)
            //}

        }

        public static void createHand(List<Card> shuffled, List<Card> startHand) {
            int drawSize = 3;
            int deckIndex = shuffled.Count();

            for (int i = 0; i < drawSize; i++)
            {
                startHand.Add(shuffled[0]);
                shuffled.RemoveAt(0);
            }
        }

        public static void isFirstTurn(List<Card> startHand, List<Card> shuffled) {
            Console.WriteLine();
            Console.WriteLine("Are you going first or second? Press 1 for first and 2 for second.");
            //create a drawCard function
            //if firstTurn
            //add one
            //else add two
            var input = Console.ReadLine();
            Int32.TryParse(input, out int result);
            switch (result)
            {
                case 1:
                    Console.WriteLine("Adding one card to your hand.");
                    startHand.Add(shuffled[0]);
                    shuffled.RemoveAt(0);
                    break;
                case 2:
                    Console.WriteLine("Adding two cards to your hand.");
                    startHand.Add(shuffled[0]);
                    shuffled.RemoveAt(0);
                    startHand.Add(shuffled[0]);
                    shuffled.RemoveAt(0);
                    break;
                default:
                    isFirstTurn(startHand, shuffled);
                    //loop
                    break;
            }
        }

        public static void handSelection(List<Card>startHand, List<Card> fieldArea, Card avatar) {
            Console.WriteLine();
            Console.WriteLine("Look at card in your hand using 1-6. 7 to view hand and 9 to quit.");
            var input = Console.ReadLine();
            Int32.TryParse(input, out int numCard);

            switch (numCard)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("You selected: " + startHand[0].CardName);
                        Console.WriteLine("Press 1 to play the card. 2 to go back to hand.");
                        var numInput = Console.ReadLine();
                        Int32.TryParse(numInput, out int choice);
                        switch (numCard) {
                            case 1:
                                Console.WriteLine("You played: " + startHand[0].CardName);
                                if (startHand[0].isCreature == true)
                                {
                                    //if creature place on field && summonSickness == true
                                    //remove from hand and place on field
                                    fieldArea.Add(startHand[0]);
                                    startHand.RemoveAt(0);
                                    startHand[0].summonSickness = true;
                                }
                                else
                                {
                                    //card action and select targets etc
                                    startHand[0].dealDamage(avatar);
                                    startHand.RemoveAt(0);
                                }
                            break;
                        case 2:
                            handSelection(startHand,fieldArea, avatar);
                            break;
                        default:
                            handSelection(startHand, fieldArea, avatar);
                            break;
                    }
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                        handSelection(startHand, fieldArea, avatar);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("You selected: " + startHand[1].CardName);
                        ///Console.WriteLine("You selected: " + startHand[0].CardName);
                        Console.WriteLine("Press 1 to play the card. 2 to go back to hand.");
                        var numInput = Console.ReadLine();
                        Int32.TryParse(numInput, out int choice);
                        switch (numCard)
                        {
                            case 1:
                                if (startHand[1].isCreature == true)
                                {
                                    //if creature place on field && summonSickness == true
                                    //remove from hand and place on field
                                    fieldArea.Add(startHand[1]);
                                    startHand.RemoveAt(1);
                                    startHand[0].summonSickness = true;
                                }
                                else
                                {
                                    //card action and select targets etc
                                    startHand[0].dealDamage(avatar);
                                    startHand.RemoveAt(1);
                                }
                                break;
                            case 2:
                                handSelection(startHand, fieldArea, avatar);
                                break;
                            default:
                                handSelection(startHand, fieldArea, avatar);
                                break;
                        }
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        //throw new ArgumentOutOfRangeException("no card in this slot", e);
                        Console.WriteLine(e.Message);
                        handSelection(startHand, fieldArea, avatar);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("You selected: " + startHand[2].CardName);
                        fieldArea.Add(startHand[2]);
                        startHand.RemoveAt(2);
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        //throw new ArgumentOutOfRangeException("no card in this slot", e);
                        Console.WriteLine(e.Message);
                        handSelection(startHand, fieldArea, avatar);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("You selected: " + startHand[3].CardName);
                        fieldArea.Add(startHand[3]);
                        startHand.RemoveAt(3);
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        //throw new ArgumentOutOfRangeException("no card in this slot", e);
                        Console.WriteLine(e.Message);
                        handSelection(startHand, fieldArea, avatar);
                    }
                    break;
                case 5:
                    try
                    {
                        Console.WriteLine("You selected: " + startHand[4].CardName);
                        fieldArea.Add(startHand[4]);
                        startHand.RemoveAt(4);
                    }
                    catch(ArgumentOutOfRangeException e) {
                        //throw new ArgumentOutOfRangeException("no card in this slot", e);
                        Console.WriteLine(e.Message);
                        handSelection(startHand,fieldArea,avatar);
                    }
                    break;
                case 6:
                    try
                    {
                        Console.WriteLine("You selected: " + startHand[5].CardName);
                        fieldArea.Add(startHand[5]);
                        startHand.RemoveAt(5);
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        //throw new ArgumentOutOfRangeException("no card in this slot", e);
                        Console.WriteLine(e.Message);
                        handSelection(startHand, fieldArea, avatar);
                    }
                    break;
                case 7:
                    printHand(startHand);
                    break;
                default:
                    handSelection(startHand, fieldArea, avatar);
                    break;
            }
        }


        public static void printHand(List<Card>startHand) {
            //print hand
            Console.WriteLine("~~~~~~Your Hand~~~~~~");

            foreach (var card in startHand)
            {

                Console.WriteLine("Card: {0} " + card.ToString(), (startHand.IndexOf(card) + 1));
            }
        }
        //function to create cards and add to a list?
    }
}

//~~~~STEPS TO DO FOR TCG~~~//~~NOTES INCLUDED IN THIS~~//
//Create Deck object x
//create player object that takes inputs for other objects x
//find out what variables x
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

////
//ways of creating a deck
//hard code the deck of 21 with specific cards and use loops to make multiples
//i need to put the cards into a list and then create a shuffle loop to display 3 random card names 
//to hard code the deck i need to add the number of cards at cost and duplicates
//21 cards in a deck 
//3 of each card
//
//create the cards that make the deck
//7 cards and 3 of each
//chose to create each card individually
//now I need to to shuffle the deck
////