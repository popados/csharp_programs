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

        public class Battle
        {
            public Battle(Hero hero, Enemy target)
            {
                //can attack with this
                //else
            }
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
                            //Attack function
                            while (target.Health > 0)
                            {
                                hero.BasicAttack(target);
                                target.PrintStats();
                                if (target.Health <= 0)
                                {
                                    target.IsDead = true;

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
