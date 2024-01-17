using Mission_2;
using System.Linq;

//Parker Watts Group 3-7 Mission #2
internal class Program
{
    private static void Main(string[] args)
    {

        //Start the welcome message

        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");

        //Ask User how many rolls to simulate and set the variable.

        System.Console.Write("How many dice rolls would you like to simulate? ");
        int NumRolls = int.Parse(System.Console.ReadLine());

        //Start Game - Simulate dice rolls and add that to the int array

        int[] ResultsArray = Mission_2.SimulateRoll.RollDice(NumRolls);

        //Give the results message

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + NumRolls + ".\n");

        // Find the percent of each result by using the count function

        for (int iCount = 2; iCount < 13; iCount++)
        {
            float percentage = ((float)ResultsArray.Count(value => value == iCount) / NumRolls) * 100;

            string sOutput = "";

            //Use the Percentage to print out the histogram

            for (int iCount2 = 0; iCount2 < percentage; iCount2++)
            {
                sOutput = sOutput + "*";
            }

            System.Console.WriteLine(iCount + ": " + sOutput);

        }

        //Display the end message
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}