using System;

namespace Dice_Rolling_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates an instance of the DiceRoll class for later use/reference
            DiceRoll dr = new DiceRoll();

            // initialize the numRolls variable, welcome the user, and parse their input to an integer
            int numRolls = 0;
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many times would you like to throw the dice?");
            numRolls = Int16.Parse(Console.ReadLine());

            dr.RollTwoDice(numRolls);
        }
    }
}
