using System;
using System.Threading;

namespace gptgame
{
    internal class GamePlay
    {

        public static void GameIntro()
        {
            Console.Title = "MEMPHIS-MEMPHIS-MEMPHIS";
            //Console.BackgroundColor = ConsoleColor.Gray;

            Console.WriteLine(@" ##   ##  ######   ##   ##  #####    ##  ##    ####     ####   
 ### ###  ##       ### ###  ##  ##   ##  ##     ##     ##  ##  
 #######  ##       #######  ##  ##   ##  ##     ##     ##      
 ## # ##  ####     ## # ##  #####    ######     ##      ####   
 ##   ##  ##       ##   ##  ##       ##  ##     ##         ##  
 ##   ##  ##       ##   ##  ##       ##  ##     ##     ##  ##  
 ##   ##  ######   ##   ##  ##       ##  ##    ####     ####   
                                                               
         ##   ##  ######   ##   ##  #####    ##  ##    ####     ####   
         ### ###  ##       ### ###  ##  ##   ##  ##     ##     ##  ##  
         #######  ##       #######  ##  ##   ##  ##     ##     ##      
         ## # ##  ####     ## # ##  #####    ######     ##      ####   
         ##   ##  ##       ##   ##  ##       ##  ##     ##         ##  
         ##   ##  ##       ##   ##  ##       ##  ##     ##     ##  ##  
         ##   ##  ######   ##   ##  ##       ##  ##    ####     ####   
                                                               
                 ##   ##  ######   ##   ##  #####    ##  ##    ####     ####   
                 ### ###  ##       ### ###  ##  ##   ##  ##     ##     ##  ##  
                 #######  ##       #######  ##  ##   ##  ##     ##     ##      
                 ## # ##  ####     ## # ##  #####    ######     ##      ####   
                 ##   ##  ##       ##   ##  ##       ##  ##     ##         ##  
                 ##   ##  ##       ##   ##  ##       ##  ##     ##     ##  ##  
                 ##   ##  ######   ##   ##  ##       ##  ##    ####     ####   ");

            Thread.Sleep(3000);
            Console.Clear();
            

            Console.ReadKey();


            Console.WriteLine("ENTER to LEAVE MEMPHIS");


            Console.ReadKey();


        }

        public static void GameExit()
        {
            Console.Clear();
            Console.WriteLine(@" ##           # #                                                    #                           #  
#   ### ### ### ### # # ###         ### ### ### ###      ## ###  ##     ##       ## ### ### ##   #  
# # # # # # # # # # ### ##          #   # # ### ##      # # # # # #  #  # #      #  # # # # # #  #  
# # ### ### ### ###   # ###  #      ### ### # # ###     ###  ## ###  ## # #     ##  ### ### # #     
 ##                 ###     #                               ###                                  # ");

            Console.Clear();

            Thread.Sleep(1000);
            
            Console.WriteLine("Press any key to exit the game!");

            Console.ReadKey();
        }




    }

}
