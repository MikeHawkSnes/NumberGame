using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour {

    private struct Player
    {
        public int totalOne, totalTwo, totalThree, totalFour, grandTotal;
        public int playerNumber;
        public Player(int number = 0, int One = 0, int Two = 0, int Three = 0, int Four = 0, int total = 0)
        {
            playerNumber = number;
            totalOne = One;
            totalTwo = Two;
            totalThree = Three;
            totalFour = Four;
            grandTotal = total;
        }
    }
    Player player1 = new Player(1);
    Player player2 = new Player(2); 
    private int slotRow, slotCol;
    [SerializeField]
    private int[,] slotLocation = new int[slotRow, slotCol]; /*{   { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 },
                                                    { 0, 0, 0, 0 }};*/

    public void setNumber(int number, int row, int col)
    {
        slotLocation[row, col] = number;
    }
    private void updatePlayers(ref Player player)
    {
        switch (player.playerNumber)
        {
            case (1):break;
            case (2):break;
            default: break;
        }
    }
    
}
