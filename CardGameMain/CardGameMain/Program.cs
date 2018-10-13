using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class CardGame
    {
        static void Main(string[] args)
        {
            Card card = new Creature();


        }
        public class Card {

        }
        public class Creature : Card {

        }

        public class Magic : Card {
            
        }


    }
}



//List<Deck> deckList = new List<Deck>();

//PlayerTurn turn = new PlayerTurn();
//Player player = new Player();
//Deck deck = new Deck();
//deck.d

//deck.Print();


//deckList.Add(new CreatureCard() { });




//card.Print();

//Start game with turn one method
//turn.TurnOne();

//turn.TurnTwo();

//card.Print();

//int hp = player.playerHealth;

//turn.PlayerChoice();
//string playerInput = Console.ReadLine();
//int userInput;
//Int32.TryParse(playerInput, out userInput);

//do
//{
//    userInput = turn.PlayerChoice();
//} while (userInput != 3);

//switch ()
//{
//    case 1:
//        Console.Write("You pressed attack");
//        Console.ReadKey();
//        break;
//    default:
//        Console.WriteLine();
//        break;
//}