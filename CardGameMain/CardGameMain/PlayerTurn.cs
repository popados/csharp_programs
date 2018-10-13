using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameMain
{
    class PlayerTurn
    {
        Random ran = new Random();
        Player player = new Player();
        int result;


        public void TurnOne()
        {
            Console.WriteLine("PLAYER ONE TURN");
            Console.WriteLine();
            PlayerChoice();
            //Console.ReadKey();
        }
        public void TurnTwo()
        {
            Console.WriteLine("THIS IS THE NEXT PLAYERS TURN");
            Console.WriteLine();
            PlayerChoice();
            //Console.ReadKey();
        }
        public void EndPhase() {
            //write my checks here
            Console.WriteLine("You ended your turn. Press a key to end game.");
            Console.ReadKey();
            //start turn two
            //TurnTwo();
        }
        public void drawCards() {
            //attack and defense stats
            //List<Card> hand = new List<Card>
            //{
            //    new Card(){ Attack = ran.Next(1,5), Defense  = ran.Next(1,5)}
            //};
            CardTest card1 = new CardTest(ran.Next(1, 5), ran.Next(1, 5));
            CardTest card2 = new CardTest(ran.Next(1, 5), ran.Next(1, 5));
            CardTest card3 = new CardTest(ran.Next(1, 5), ran.Next(1, 5));

            card1.Print();
            card2.Print();
            card3.Print();
        }

        //Method to show player the choices that can be made
        public int PlayerChoice()
        {
            //draw cards at start of player turn(using player choice to simulate the action of player > actions)
            drawCards();

            Console.WriteLine("1. Show Play Area");
            Console.WriteLine("2. Show Hand");
            Console.WriteLine("3. Show Health, etc");
            Console.WriteLine("4. Pass Turn");
            var choice = Console.ReadLine();
            Int32.TryParse(choice, out result);

            //switch statement show option results
            switch (result) {
                case 1:
                    Console.WriteLine("you attacked");
                    EndPhase();
                    //attack phase
                    break;
                case 2:
                    //draw a card
                    Console.WriteLine("You checked your health pool");
                    drawCards();
                    break;
                case 3:
                    Console.WriteLine("Your hand looks like this");
                    //showCards();
                    EndPhase();
                    break;
                default:
                    Console.WriteLine("press a key with an option");
                    TurnOne();
                    break;
            }
            return result;

        }
    }
}
//public void DrawPhase() {
//    int handCount = 3;
//    if (handCount < 3) {
//        handCount++;
//    }
//}

//var result = Console.ReadLine();
//return Int32.TryParse(result);
