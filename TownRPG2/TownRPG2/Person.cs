using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownRPG2
{
    public class Person
    {
        public string InstanceName {get;set;}
        public int Health { get; set; }
        public int Attack { get; set; }
        public bool IsDead { get; set; }

        public Person() {
            InstanceName = "Default Name";
            Health = 15;
            Attack = 5;
            IsDead = false;
        }
        public void PrintStats()
        {
            Console.WriteLine("Name: " + InstanceName);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Attack: " + Attack);
            Console.WriteLine();
            Console.ReadKey();
        }
        public void BasicAttack(Person target) {
            target.Health -= Attack;
        }
    }
    public class Hero : Person {
        public Hero(string _name) {
            InstanceName = _name;
        }
    }

    public class Enemy : Person {
        public Enemy() {
            InstanceName = "Default Enemy/Token";
            Health = 1;
            Attack = 1;
        }
    }
    public class Goblin : Enemy {
        public Goblin() {
            InstanceName = "Goblin";
            Health = 8;
            Attack = 3;
        }

    }
}
