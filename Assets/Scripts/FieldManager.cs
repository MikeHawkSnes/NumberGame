using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FieldManager : MonoBehaviour {

    public GameObject col1, col2, col3, col4, row1, row2, row3, row4, Winner;

    private struct Player
    {
        //player 1 = columns, player 2 = rows
        public int totalOne, totalTwo, totalThree, totalFour, grandTotal;
        public int playerNumber;
        public Player(int number = 0, int One = 1, int Two = 1, int Three = 1, int Four = 1, int total = 0)
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
    private int[,] slotLocation = new int[4, 4]; 
    public bool setNumber(int number, int xValue, int yValue)
    {
        slotLocation[xValue-1, yValue-1] = number;
        return false;
    }
    public void resetscene()
    {
        SceneManager.LoadScene("main");
    }
    public void gameSet()
    {
        updatePlayers(ref player1, ref player2);
        col1.GetComponent<CountUp>().displayValue(player1.totalOne);
        col2.GetComponent<CountUp>().displayValue(player1.totalTwo);
        col3.GetComponent<CountUp>().displayValue(player1.totalThree);
        col4.GetComponent<CountUp>().displayValue(player1.totalFour);

        row1.GetComponent<CountUp>().displayValue(player2.totalOne);
        row2.GetComponent<CountUp>().displayValue(player2.totalTwo);
        row3.GetComponent<CountUp>().displayValue(player2.totalThree);
        row4.GetComponent<CountUp>().displayValue(player2.totalFour);
        if (player1.grandTotal > player2.grandTotal)
            Winner.GetComponent<CountUp>().displayValue("Player 1 Wins");
        else if (player1.grandTotal == player2.grandTotal)
            Winner.GetComponent<CountUp>().displayValue("Tie!");
        else
            Winner.GetComponent<CountUp>().displayValue("Player 2 Wins!");

    }
    private void updatePlayers(ref Player player1, ref Player player2)
    {
        int[] playerOneTotals = new int[4] { 1, 1, 1, 1 };
        int[] playerTwoTotals = new int[4] { 1, 1, 1, 1 };
        for (int x = 0; x < 4; ++x)
        {
            for(int y = 0; y < 4; ++y)
            {
                playerOneTotals[x] *= slotLocation[x, y];
                playerTwoTotals[x] *= slotLocation[y, x];
            }
            player1.grandTotal += playerOneTotals[x];
            player2.grandTotal += playerTwoTotals[x];
        }
        player1.totalOne = playerOneTotals[0];
        player2.totalOne = playerTwoTotals[0];

        player1.totalTwo = playerOneTotals[1];
        player2.totalTwo = playerTwoTotals[1];

        player1.totalThree = playerOneTotals[2];
        player2.totalThree = playerTwoTotals[2];

        player1.totalFour = playerOneTotals[3];
        player2.totalFour = playerTwoTotals[3];

    }
    
}
