using System;

namespace SNAKE_AND_LADDER
{
    class Program
    {

        private static Random rand = new Random();
        
        static void Main(string[] args)
        {
            int roll = rand.Next(1, 6);
            Console.WriteLine("WELCOME TO SNAKE AND LADDER GAME");
            Console.WriteLine( "dice roll a :" + roll );        
        }

    }
}
