using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_Rolling_Game
{
    public class DiceRoll
    {
        //private int numRolls = 0;
        public DiceRoll()
        {
            //numRolls = temp;
        }

        public void RollTwoDice(int numRolls)
        {
            Random rnd = new Random();
            int[] rollArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] rollArray2 = { 7, 7, 7 };

            for(int i=0; i<numRolls; i++)
            {
                int dice1 = rnd.Next(1, 6);
                int dice2 = rnd.Next(1, 6);
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
            for(int i=0; i<rollArray.Length; i++)
            Console.WriteLine(rollArray[i]);
        }

    }
}
