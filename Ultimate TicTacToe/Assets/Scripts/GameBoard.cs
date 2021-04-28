using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Abstract class that all gameboards implement
public interface GameBoard 
{
    /*Boolean value that tracks the two state of the gamboard: active or inactive
     * Active = the board reacts to player input
     * Inactive = the board does not react to player input
     */
    public bool isActive();
    //Event listener that checks if the game board has been clicked
    public bool isClicked();
}
