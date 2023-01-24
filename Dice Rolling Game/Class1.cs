using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_Rolling_Game
{
    public class DiceRoll
    {
       // create the "DiceRoll" method which will simulate the rolling of the two dice and print the resulting histogram
        public DiceRoll()
        {
        
        }

        // the RollTwoDice method simulates the rolling of the dice and tracks the totals for each number in an array called "rollArray"
        public void RollTwoDice(int numRolls)
        {
            Random rnd = new Random();
            float[] rollArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for(int i=0; i<numRolls; i++)
            {
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int dieTotal = dice1 + dice2;
                if (dieTotal == 2)
                {
                    rollArray[0] += 1;
                }
                else if(dieTotal == 3)
                {
                    rollArray[1] += 1;
                }
                else if (dieTotal == 4)
                {
                    rollArray[2] += 1;
                }
                else if (dieTotal == 5)
                {
                    rollArray[3] += 1;
                }
                else if (dieTotal == 6)
                {
                    rollArray[4] += 1;
                }
                else if (dieTotal == 7)
                {
                    rollArray[5] += 1;
                }
                else if (dieTotal == 8)
                {
                    rollArray[6] += 1;
                }
                else if (dieTotal == 9)
                {
                    rollArray[7] += 1;
                }
                else if (dieTotal == 10)
                {
                    rollArray[8] += 1;
                }
                else if (dieTotal == 11)
                {
                    rollArray[9] += 1;
                }
                else
                {
                    rollArray[10] += 1;
                }
            }
            // this for loop converts the roll totals into percentages
            for (int i = 0; i < rollArray.Length; i++)
            {
                rollArray[i] = (rollArray[i] / numRolls) * 100;
            }
            // this nested for loop iterates through the array of percentages and prints the appropriate number of *s
            for (int i=2; i<rollArray.Length+2; i++)
            {
                Console.Write(i + ": ");
                for (int j = 0; j < rollArray[i - 2]; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

    }
}
