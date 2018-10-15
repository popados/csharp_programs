using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownRPG2
{
    public class Tower
    {
        public static Goblin CreateGoblin()
        {
            Console.WriteLine("You found a goblin!");
            Console.WriteLine();
            Goblin goblin = new Goblin();
            return goblin;
        }
        public static Hero CreateHero()
        {
            Console.WriteLine("Please Enter Hero name.");
            string _name = Console.ReadLine();
            Hero hero = new Hero(_name);
            hero.PrintStats();
            return hero;
        }

        public class Battle
        {
            public Battle(Hero hero, Enemy target)
            {
                //can attack with this
                //else
            }

            //fight to select hero and target objects
            //isDead check for both objects
            //put 
            public static void Fight(Hero hero, Enemy target)
            {
                if (hero.IsDead == false && target.IsDead == false)
                {
                    Console.WriteLine("You may attack the goblin!");
                    Console.WriteLine("Please Select an option");
                    Console.WriteLine("1. Attack");
                    Console.WriteLine("2. Look/etc");


                    int userInput = 0;
                    string result = Console.ReadLine();
                    Int32.TryParse(result, out userInput);
                    switch (userInput)
                    {
                        case 1:
                            //Attack method that changes bool to exit attack selection
                            while (target.Health > 0)
                            {
                                hero.BasicAttack(target);
                                //goblin attack phase here
                                target.PrintStats();
                                if (target.Health <= 0)
                                {
                                    target.IsDead = true;
                                    //add to list of killed enemies?
                                }
                            }
                            break;
                        case 2:
                            //look or whatever
                            break;
                        default:
                            //default to somewhere(best place to loop the switch statement)
                            break;
                    }
                }
            }

        }
    }
}
