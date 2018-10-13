using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_CharacterSheet
{
    public class Character {
        //public void AttributeScores()
        //{

        //    //int STR, INT, DEX, CHA, CON;

        //}

        //protected int StrengthScore() {
        //    Console.Write("Enter Strength Attribute: ");
        //    string strength = Console.ReadLine();
        //    //checks with throwing exceptions
        //    Int32.TryParse(strength, out int STR);
        //    //Console.WriteLine("Your STR is: " + STR);
        //    return STR;

        //}
        //protected int IntelligenceScore() {
        //    Console.Write("Enter Intelliect Attribute: ");
        //    string intelligence = Console.ReadLine();
        //    //checks with throwing exceptions
        //    Int32.TryParse(intelligence, out int INT);
        //    //Console.WriteLine("Your INT is: " + INT);
        //    return INT;
        //}
        //protected int DexterityScore() {
        //    Console.Write("Enter Dexterity Attribute: ");
        //    string dexterity = Console.ReadLine();
        //    //checks with throwing exceptions
        //    Int32.TryParse(dexterity, out int DEX);
        //    //Console.WriteLine("Your DEX is: " + DEX);
        //    return DEX;
        //}
        //protected int CharismaScore() {
        //    Console.Write("Enter Charisma Attribute: ");
        //    string charisma = Console.ReadLine();
        //    //checks with throwing exceptions
        //    Int32.TryParse(charisma, out int CHA);
        //    //Console.WriteLine("Your CHA is: " + CHA);
        //    return CHA;
        //}
        //protected int ConstitutionScore()
        //{
        //    Console.Write("Enter Constitution Attribute: ");
        //    string constituion = Console.ReadLine();
        //    //checks with throwing exceptions
        //    Int32.TryParse(constituion, out int CON);
        //    //Console.WriteLine("Your CON is: " + CON);
        //    return CON;
        //}
    }

    //class Program
    //{
    //    string INT, STR, DEX, CHA, CON;

    //    static void Main(string[] args)
    //    {
    //        string str = "hi";
    //        Console.WriteLine(str);
    //        Console.WriteLine("Enter your INT: ");
    //        string INT = Console.ReadLine();
    //        Console.ReadKey();
    //    }
    //}


         

    class TestCharacter : Character {
     
        //string strength, intelligence, dexterity, charisma, constitution;
        static void Main(string[] args) {
            //attributeScores();
            TestCharacter toon = new TestCharacter();

            //Console.WriteLine("1. Create Character");


            //this calls the method to get input for attribute scores
            //int strength = toon.StrengthScore();
            //int intelligence = toon.IntelligenceScore();
            //int dexterity = toon.DexterityScore();
            //int charisma = toon.CharismaScore();
            //int constitution = toon.ConstitutionScore();

            //Console.WriteLine("your strength score is: " + strength);
            //Console.WriteLine("your intelligence score is: " + intelligence);
            //Console.WriteLine("your dexterity score is: " + dexterity);
            //Console.WriteLine("your charisma score is: " + charisma);
            //Console.WriteLine("your constitution score is: " + constitution);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }     

    }
}
