using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gptgame
{
    internal class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackStrength { get; set; }
        public int Defense { get; set; }

        // Constructor to initialize an enemy
        public Enemy( string name, int health, int attackStrength, int defense )
        {
            Name = name;
            Health = health;
            AttackStrength = attackStrength;
            Defense = defense;
        }

        // Method for the enemy to attack a target
        public int Attack()
        {
            Console.WriteLine($"{Name} attacks with strength of {AttackStrength}!");
            return AttackStrength;
        }

        // Method for the enemy to take damage
        public void TakeDamage( int damage )
        {
            int actualDamage = Math.Max(damage - Defense, 0); // Ensure damage is never negative
            Health -= actualDamage;
            Console.WriteLine($"{Name} takes {actualDamage} damage! Remaining health: {Health}");

            if ( Health <= 0 )
            {
                Console.WriteLine($"{Name} has been defeated!");
            }


        }
    }
}
