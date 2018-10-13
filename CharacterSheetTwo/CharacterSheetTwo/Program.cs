using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetTwo
{
       //class variables for character
    class Character {
        public string name;
        public string characterClass;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int wisdom;
        public int constitution;

        public Character()
        {
            Random ran = new Random();
            name = "Hammond";
            characterClass = "Rogue";
            strength = ran.Next(1,21);
            intelligence = ran.Next(1, 21);
            dexterity = ran.Next(1, 21);
            wisdom = ran.Next(1, 21);
            constitution = ran.Next(1, 21);

        }

        public void Print() {
            Console.WriteLine("Name: " + name
                +Environment.NewLine + "Class: " +characterClass
                +Environment.NewLine + "Strength: " + strength
                +Environment.NewLine + "Intelligence: " + intelligence
                +Environment.NewLine + "Dexterity: " + dexterity
                +Environment.NewLine + "Wisdom: " + wisdom
                +Environment.NewLine + "Constitution: " + constitution);

        }
    }


    class MainClass
    {
        static void Main(string[] args)
        {

            int inputSelection;
            int result;

            //character object?

            Character rogue = new Character();
            //create menu
            //Console.WriteLine("1. Create Character");
            //Console.WriteLine("2. View Characters");
            //Console.WriteLine("3. Exit Program");
            rogue.Print();
                         

            Console.ReadKey();
            
            //user input to show menu items
        }
    }
}
