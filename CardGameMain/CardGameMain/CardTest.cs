using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameMain
{
    class CardTest
    {
        public string CardNameTest;
        public string AbilityName;
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int ManaCost;
        

        public CardTest(int attack, int defense)
        {
            Random ran = new Random();
            CardNameTest = "Card";
            AbilityName = "random name";
            Attack = attack;
            Defense = defense;
            ManaCost = 1;

        }

        public void PlayerInput()
        {

            string userInput = Console.ReadLine();
        }
        public void Print()
        {
            Console.Write("Card name: " + CardNameTest
                +Environment.NewLine + "Attack: " + Attack
                +Environment.NewLine + "Defense: " +Defense +"\n");
            Console.ReadKey();
            //Console.WriteLine(Attack);
            //Console.WriteLine(Defense);
            //Console.ReadLine();
        }

    }

}

