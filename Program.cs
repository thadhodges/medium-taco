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
            Player.SelectRandomEnemy();



            

           

            // Keep console open
            Console.ReadLine();
            
        }
    }
}
