using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace gptgame
{
    internal class Program
    {
        static void Main( string[] args )
        {
            
            Player.Introduction();
            //Player.SelectPlayer();
            //Player.SelectRandomEnemy();
            //Battle.SequenceOne();
            //Thread.Sleep( 1000 );
            //Console.Clear();
            //Battle.SequenceTwo();
            //Console.Clear();
            Battle.RandomStartString();

           







            // Keep console open
            Console.ReadLine();
            
        }
    }
}
