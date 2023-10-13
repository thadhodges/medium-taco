using System;
using System.Collections.Generic;

namespace gptgame
{
    internal class Program
    {
        static void Main( string[] args )
        {

            Player.Introduction();
            Player.SelectPlayer();
            



            

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
                    Console.WriteLine($"You attacked the {chosenEnemy}");
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
                Console.WriteLine($"The {chosenEnemy} attacks you!");
                // Implement player damage logic here
                Random playerAttack = new Random();
                int playerDamage = playerAttack.Next(5);
                playerHealth -= playerDamage;


                // Display enemy health
                Console.WriteLine($"Enemy Health: {enemyHealth}\n" +
                    $"Player Health: {playerHealth}");
            }

            Console.WriteLine($"You have defeated the {chosenEnemy}!!!");

            // Keep console open
            Console.ReadLine();
            
        }
    }
}
