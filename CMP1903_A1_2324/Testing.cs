using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public void Test() //Declaring a public void so no return is required and the game can therefore be ran as necessary
        {
            Game game = new Game(); //Instantiating a new game object
            int[] Dice = game.AllDieRolls(); //Declaring the integer array of "Dice" which will later store the values of "AllDieRolls"
            int gamesum = game.RollTotal(Dice); //Creates an array to store the value of all of the rolls which have been made in the "Game" class - this will be the given outcome
            int expected = Dice[0] + Dice[1] + Dice[2]; //This integer adds the variables locally within the "Testing" class - this will be the expected outcome
            Debug.Assert(gamesum == expected, message: "The sums don't match!");

           Die Die = new Die();
            int TestRoll = Die.RollTheDice();
            Debug.Assert(TestRoll >= 1 & TestRoll <= 6, "The die roll is outside of set Parameters");
        }
    }
}
