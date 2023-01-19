using System;

namespace Dice_Rolling_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRolls = 0;
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many times would you like to throw the dice?");
            numRolls = Int16.Parse(Console.ReadLine());
        }
    }
}
