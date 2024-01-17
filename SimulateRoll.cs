using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    internal class SimulateRoll
    {
        
        //Constructor
        public SimulateRoll() 
         {
             // Nothing in setup
         }

        //Public Method called RollDice that has the paramater rolls
        public static int[] RollDice(int Rolls)
        {
            //Create the Int array and random object to use random method later

            System.Random random = new System.Random();

            int[] results = new int[Rolls];

            // Simulate the TWO 6 SIDED DICE rolling and put the results in a list

            for (int iCount = 0; iCount < Rolls; iCount++)
            {

                int diceOne = random.Next(1, 7);

                int diceTwo = random.Next(1, 7);

                int diceResult = (diceOne + diceTwo);

                results[iCount] = diceResult;

            }
            // The second class returns the array with the number of total rolls to the first class

            return results;

        }
    }
}
