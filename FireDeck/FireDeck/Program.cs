using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDeck
{
    class Program
    {
        Avatar enemyGod = new Avatar("Enemy God");

        static void Main(string[] args)
        {
            //scale console window
            Console.SetWindowSize(Console.LargestWindowWidth/2,Console.LargestWindowHeight/3);
            //Avatar fireGod = new Avatar("Fire God");
            //Avatar enemyGod = new Avatar("Enemy God");

            
            //starts story
            StoryPartOne();
            
            //fireGod.PrintStats();
            //ExitFunction();

            //chain of events
            //avatar object for player //done
            //avatar object for enemy //done
            //player gains card object 
            //player choose card(for attack int)
            //attack target avatar
            //PlayerSelection();
                        
        }

        //int playerInput = 0;

        //~~Need bool for while condition~~//
        //int playerInput = 0;
        //do {
        //    var input = playerInput;
        //    playerSelection();
        //} while ();

        //function with switch statement to get input
        public static void CreateObjects()
        {
            Avatar fireGod = new Avatar("Fire God");
            Avatar enemyGod = new Avatar("Enemy God");

            Card card1 = new Card.LittleDraco();
            Card card2 = new Card.ImpCard();
            Card card3 = new Card.SpiritOFire();
            Card card4 = new Card.FireBall();
            Card card5 = new Card.FireDrake();
            Card card6 = new Card.WildFire();
            Card card7 = new Card.FlameStrike();
            PlayerSelection();

            void PlayerSelection() {
                Console.WriteLine("1. Show cards");
                Console.WriteLine("2. Show Enemy Health");
                Console.WriteLine("3. Show Player Health");
                Console.WriteLine("4. Go back to main screen(Will reset all objects)");
                Console.WriteLine("5. Exit Program");
                Console.WriteLine();
                var input = Console.ReadLine();
                Int32.TryParse(input, out int result);
                switch (result)
                {
                    case 1:
                        DisplayCards();
                        break;
                    case 2:
                        enemyGod.PrintStats();
                        PlayerSelection();
                        break;
                    case 3:
                        fireGod.PrintStats();
                        PlayerSelection();
                        break;
                    case 4:
                        StoryPartOne();
                        break;
                    case 5:
                        Console.WriteLine("Enter key to exit");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Please select a displayed option.");
                        PlayerSelection();
                        break;
                }
            }
            void DisplayCards()
            {

                //    //use list to create new cards in a list deck??
                //    //looking to change this
                //    //TestImpCard card2 = new TestImpCard();
                //card1.Print();
                //card2.Print();
                //card3.Print();
                //card4.Print();
                //card5.Print();
                //card6.Print();
                //card7.Print();
                Console.WriteLine("Select a card 1 or 2 to display. Press 9 to go to main menu.");
                Console.WriteLine();

                int inputCard = 0;
                string resultCard = Console.ReadLine();
                Int32.TryParse(resultCard, out inputCard);

                switch (inputCard)
                {
                    case 1:
                        card1.Print();
                        card1.attackEnemy(enemyGod);
                        Console.WriteLine("health remaining: " + enemyGod.Health);
                        Console.ReadKey();
                        DisplayCards(); 
                        break;
                    case 2:
                        card2.Print();
                        card2.attackEnemy(enemyGod);
                        Console.WriteLine("health remaining: " + enemyGod.Health);
                        Console.ReadKey();
                        DisplayCards();
                        break;
                    case 3:
                        card3.Print();
                        card3.attackEnemy(enemyGod);
                        Console.WriteLine("health remaining: " + enemyGod.Health);
                        Console.ReadKey();
                        DisplayCards();
                        break;
                    case 5:
                        card5.Print();
                        card5.attackEnemy(enemyGod);
                        Console.WriteLine("health remaining: " + enemyGod.Health);
                        Console.ReadKey();
                        DisplayCards();
                        break;
                    case 9:
                        PlayerSelection();
                        break;
                    default:
                        Console.WriteLine("Pick a card");
                        DisplayCards();
                        break;

                }
            }
        }


        //CreateCards();
        //ExitFunction();


            //my init function
        public static void StoryPartOne() {
            Console.WriteLine("You are an Avatar of Fire.");
            Console.WriteLine("Choose cards to attack within your mana cost.");
            Console.WriteLine("Good Luck");
            Console.WriteLine("Press 1 to continue..");
            Console.WriteLine();
            int input = 0;
            string result = Console.ReadLine();
            Int32.TryParse(result, out input);
            switch (input) {
                case 1:
                    CreateObjects();
                    break;
                default:
                    Console.WriteLine("Press 1 to Continue.. will keep looping!");
                    StoryPartOne();
                    break;

            }
        }

        public static void ExitFunction()
        {

            Console.WriteLine("Press any key to end program");
            Console.ReadKey();

        }

}

}