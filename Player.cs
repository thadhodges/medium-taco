using System;
using System.Collections.Generic;
using System.Threading;

namespace gptgame
{
    public class Player
    {
        string chosenEnemy;

        public static void Introduction()
        {



            Console.WriteLine("Welcome to Memphis, Memphis, Memphis!");

            Thread.Sleep(2000);

            Console.Write("Enter your character's name: ");

            Thread.Sleep(2000);

            string characterName = Console.ReadLine();

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
            Console.WriteLine($"Initial Stats: Strength {strength}, Intelligence {intelligence}, Agility {agility}");


        }


        public static void SelectRandomEnemy()
        {
           

            // List of enemy types


            List<string> enemyTypes = new List<string>() { "Trollip", "Skank", "Car Salesman", "Hoodlum", "Priest", "Chammy Sweep", "Proper Cunt", "Chicken Head", "Pimp" };

            // Create a random object
            Random enemy = new Random();

            // Get random index from 0 to enemyTypes.Count - 1
            int randomIndex = enemy.Next(enemyTypes.Count);

            // Choose a random enemy type
            string randomEnemy = enemyTypes[randomIndex];



            // User Story 2: Combat System

            // Acceptance Criteria 1: Initiate combat
            Console.WriteLine($"You have encountered a {randomEnemy}!");

        }
        //need to redo this section, something aint right.
        public static void EnemyEncounter()
        {
            
            int enemyHealth = 10;
            int playerHealth = enemyHealth + 2;

            // Acceptance Criteria 2 & 3: Take turns and use skills/items
            while ( enemyHealth > 0 && playerHealth > 0 )
            {
                Console.WriteLine("\nIt's your turn! Choose your action: [Attack | Heal | Stats]");
                string action = Console.ReadLine();
                Random enemyAttack = new Random();
                int damage = enemyAttack.Next(5);

                // Player turn
                if ( action.ToLower() == "attack" )
                {
                    Console.WriteLine($"You attacked the {SelectRandomEnemy}");
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

                // Enemy turn
                Console.WriteLine($"The {Player.chosenEnemy} attacks you!");
                // Implement player damage logic here
                Random playerAttack = new Random();
                int playerDamage = playerAttack.Next(5);
                playerHealth -= playerDamage;


                // Display enemy health
                Console.WriteLine($"Enemy Health: {enemyHealth}\n" +
                    $"Player Health: {playerHealth}");
            }

            Console.WriteLine($"You have defeated the {chosenEnemy}!!!");

        }
    }
}
