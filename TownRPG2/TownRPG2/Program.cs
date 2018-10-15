using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//~~~~~~~~WHAT IS DONE NOW~~~~~~~//
//-Story Intro
//-Create Hero
//-Create Goblin
//-Fight
//~~~~~~~~NEXT TO DO TO END PHASE~~~~~~~//
//-Loop creation of goblin
//-Fight until hero HP is down
//-Add level per killed counter
//-Hero dead: display end stats(killed, floors cleared, etc)

namespace TownRPG2
{
    class Program
    {
        static void Main(string[] args)
        {
            //main header for story
            CreateMainStory();

            //create hero and ask player for name(doing this outside a function for now)
            Hero hero = Tower.CreateHero();
            //create goblin
            var gob = Tower.CreateGoblin();

            gob.PrintStats();
            //when goblin dead send to list?
            Tower.Battle.Fight(hero, gob);


            //create goblin object
            //Goblin goblin = new Goblin();
            //goblin.PrintStats();




        }



        public static void CreateMainStory()
        {
            Console.WriteLine("    |<--- Climb The Tower! --->|");
            Console.WriteLine("|<--- Press Enter to Continue --->|");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void ToTower() {
            Console.WriteLine("Welcome to the tower");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

//logic for battle
//player encounter enemy
//option to attack
//player attack - target.health then check if dead
//goblin attack - hero.health then check if dead
//if dead == true{ hero: game over}, you killed x goblins
//if goblin dead goblinKilled++
//give option for end game and display goblins killed after each fight --
//will use loop to create goblins while player has hp




//
//tower rpg to test my own story and ideas
//idea is a town at the bottom of a tower
//this town has supplies to go to the tower
//tower has levels with rooms to explore and items to find
//

//create a person class and contructor for all enemies and heroes
//get user input for hero name 
//hero has 15 Health and 5 attack
//create enemy objects
//create the town class //user selection to go to different places

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
//i want to figure out how to create a hero object with user input for name
//maybe create a HeroList class that is a list of heroes created using this function
//let player display and choose hero

//opening of the game and creation of first user input//THIS REMAKE MIGHT PROVE I CAN DO THIS BETTER!
//i think im misunderstanding something here
//i want to create the hero object then give it a name but it wont update the property

//
//next steps-
//player object meets goblins object//DONE-Tower.Battle.Fight
//create a battle phase that asks for player input//DONE
//Give goblin response turn //
//check if player or goblin is dead // DONE
//add to counter
//end screen