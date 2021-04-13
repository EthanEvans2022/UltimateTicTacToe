using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class responsible for managing a basic game of TicTacToe
public class OneDimGameManager : MonoBehaviour
{
    //Players, who have methods specific to the game
    Player playerX, playerO;
    int[,] gameState = new int[3,3]{ 
        {0,0,0},
        {0,0,0},
        {0,0,0},
        };
    bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Loads the game board and starts the game
    private void StartGame()
    {

    }

    //Processes a player's turn, checks if the game is over, and updates the game state
    private void Turn(Player player)
    {
        
    }

    //Check if the game is over
    private void CheckGame()
    {

    }

    //Update the game board
    private void UpdateGameBoard()
    {

    }
}
