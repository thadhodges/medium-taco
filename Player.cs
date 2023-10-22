using System;
using System.Collections.Generic;
using System.Threading;

namespace gptgame
{
    public class Player
    {
        public static void Introduction()
        {



            Console.WriteLine("Welcome to Memphis, Memphis, Memphis!");

            Thread.Sleep(2000);

            Console.Clear();

            Console.Write("Enter your character's name: ");

            Thread.Sleep(2000);

            string characterName = Console.ReadLine();

            Thread.Sleep(2000);

            Console.Clear();

            Thread.Sleep(2000);

            Console.WriteLine($"Hello, {characterName}!");





        }

        public static void SelectPlayer()
        {

            // Acceptance Criteria 2: Choose from predefined classes
            Console.WriteLine("Choose your class: [Warrior | Mage | Thief | Streaker]");
            string characterClass = Console.ReadLine();

            int strength;
            int intelligence;
            int agility;
            // Acceptance Criteria 3: Assign initial stats based on class
            switch ( characterClass.ToLower() )
            {
                case "warrior":
                    strength = 10;
                    intelligence = 4;
                    agility = 6;
                    break;
                case "mage":
                    strength = 4;
                    intelligence = 10;
                    agility = 6;
                    break;
                case "thief":
                    strength = 6;
                    intelligence = 4;
                    agility = 10;
                    break;
                case "streaker":
                    strength = 20;
                    intelligence = 20;
                    agility = 4;
                    break;
                default:
                    Console.WriteLine("Invalid class selected. Defaulting to Warrior.");
                    characterClass = "Warrior";
                    strength = 10;
                    intelligence = 4;
                    agility = 6;
                    break;
            }

            Console.WriteLine($"You chose the {characterClass} class.");
            Console.WriteLine($"Initial Stats: \n" +
                $"Strength {strength}\n" +
                $"Intelligence {intelligence}\n" +
                $"Agility {agility}");
            Thread.Sleep(3000);


        }


        public static void SelectRandomEnemy()
        {


            // List of enemy types


            List<string> enemyTypes = new List<string>()
            { "Trollip",
                "Skank",
                "Car Salesman",
                "Hoodlum",
                "Priest",
                "Chammy Sweep",
                "Proper Cunt",
                "Chicken Head",
                "Pimp"
            };
            List<string> introEnemy = new List<string>()
            {
                "What--something is amiss, careful lads...",
                "The day is headed downhill!!",
                "Shhhh...Listen!",
                "What was that?"
            };

            // Create a random enemy
            Random enemy = new Random();
            //Create a random starting saying
            Random intro = new Random();

            // Get random index from 0 to enemyTypes.Count - 1
            int randomIndex = enemy.Next(enemyTypes.Count);
            int randomSaying = intro.Next(introEnemy.Count);

            // Choose a random enemy type
            string randomEnemy = enemyTypes[randomIndex];
            string randomIntro = introEnemy[randomSaying];



            // User Story 2: Combat System

            // Acceptance Criteria 1: Initiate combat
            Console.WriteLine("You continue on your journey, when something grabs your attention...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"{randomIntro}");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("....");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("........");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("...........");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine($"You have encountered a {randomEnemy}!\n" +
                $"Gather your whits and arm yourself!");
            Thread.Sleep(3000);

            int enemyHealth = 10;
            int playerHealth = enemyHealth + 2;

            // Acceptance Criteria 2 & 3: Take turns and use skills/items
            while ( enemyHealth > 0 && playerHealth > 0 )
            {
                Console.WriteLine("\nIt's your turn! Choose your action: [Attack | Heal | Stats]");
                string action = Console.ReadLine();
                Thread.Sleep(3000);
                Console.Clear();
                Random enemyAttack = new Random();
                int damage = enemyAttack.Next(5);

                // Player turn
                if ( action.ToLower() == "attack" )
                {
                    Thread.Sleep(2000);
                    Console.WriteLine($"You attacked the {randomEnemy}");
                    Thread.Sleep(3000);
                    enemyHealth -= damage;
                }
                else if ( action.ToLower() == "heal" )
                {
                    Console.WriteLine("You healed yourself!");
                    // Implement healing logic here
                }
                else if ( action.ToLower() == "stats" )
                {
                    //Console.WriteLine($"your stats are\n" +
                    //$"current strength: {Player.strength}\n" +
                    //$"current intelligence: {intelligence}\n" +
                    //$"current agility: {agility}");
                }
                else
                {
                    Console.WriteLine("Invalid action. You lose your turn.");
                }

                Console.WriteLine("......");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("...........");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("................");
                Thread.Sleep(1000);
                Console.Clear();

                // Enemy turn
                Thread.Sleep(3000);
                Console.WriteLine($"The {randomEnemy} attacks you!");

                // Implement player damage logic here
                Random playerAttack = new Random();
                int playerDamage = playerAttack.Next(5);
                playerHealth -= playerDamage;
                //add pause
                Thread.Sleep(2000);

                // Display enemy health
                Console.WriteLine($"Enemy Health: {enemyHealth}\n" +
                    $"Player Health: {playerHealth}");
                Console.Clear();

                //add pause
                Thread.Sleep(2000);
            }
            if ( playerHealth < 0 )
            {
                Thread.Sleep(2000);
                Console.WriteLine($"You have defeated the {randomEnemy}!!!");
            }
            else
            {
                Console.WriteLine($"You Have Been Defeated");
            }
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int AttackStrength { get; set; }
        public int Defense { get; set; }
        public int ExperiencePoints { get; private set; }
        public int Level { get; private set; }

        // Constructor to initialize the hero
        //public Hero( string name,  )
        //{
        //    Name = name;
        //    MaxHealth = 100; // Default value
        //    Health = MaxHealth;
        //    AttackStrength = 15; // Default value
        //    Defense = 10; // Default value
        //    ExperiencePoints = 0;
        //    Level = 1;
        //}

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
