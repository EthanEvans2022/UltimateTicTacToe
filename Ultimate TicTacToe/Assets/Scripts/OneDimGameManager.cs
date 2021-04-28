using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class responsible for managing a basic game of TicTacToe
public class OneDimGameManager : MonoBehaviour
{
    /**VARIABLES**/
    public Player[] players; //Players used in game
    public GameBoard gameBoard; //Gameboard used in the game
    /**METHODS**/

    //Initialize the game and gets everything set up
    public int newGame()
    {
        return 0;
    }

    //Sets the player who is going and sets things up to wait for action input
    public void nextTurn()
    {

    }

    //Checks the input and see if it is valid
    //Returns: 0 = bad input, 1 = valid
    public int processInput()
    {
        return 1;
    }

    //Checks the state of the game and if it is over
    public void checkGame()
    {

    }

    //Display results of game and promt user input
    public void gameOver()
    {

    }
}
