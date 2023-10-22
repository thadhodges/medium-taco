using System;
using System.Collections.Generic;
using System.Threading;

namespace gptgame
{
    public class Player
    {
       

        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int AttackStrength { get; set; }
        public int Defense { get; set; }
        public int ExperiencePoints { get; private set; }
        public int Level { get; private set; }

        //Constructor to initialize the hero
        public Player( string name, int maxHealth, int health, int attackStrength, int defense, int experiencePoints, int level )
        {
            Name = name;
            MaxHealth = 100; // Default value
            Health = health;
            AttackStrength = 15; // Default value
            Defense = 6; // Default value
            ExperiencePoints = experiencePoints;
            Level = level;
        }

        // Method for the hero to attack a target
        public int Attack()
        {
            Console.WriteLine($"{Name} attacks with strength of {AttackStrength}!");
            return AttackStrength;
        }

        // Method for the hero to take damage
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

        // Method for the hero to gain experience
        public void GainExperience( int exp )
        {
            ExperiencePoints += exp;
            Console.WriteLine($"{Name} gains {exp} experience points!");

            // Level up if the hero has enough experience (this is a simple level-up mechanism for the example)
            if ( ExperiencePoints >= Level * 100 )
            {
                LevelUp();
            }
        }

        // Level up method
        private void LevelUp()
        {
            Level++;
            MaxHealth += 20;  // Increase max health by 20 points for each level
            Health = MaxHealth; // Restore full health upon leveling up
            AttackStrength += 5; // Increase attack strength
            Defense += 5; // Increase defense
            ExperiencePoints = 0; // Reset experience points for the next level

            Console.WriteLine($"{Name} has reached level {Level}!");

        }
    }
}
