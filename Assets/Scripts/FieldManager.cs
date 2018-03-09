using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour {

    private struct Player
    {
        int totalOne, totalTwo, totalThree, totalFour, grandTotal;
    }
    Player player1;
    Player player2;
    [SerializeField]
    private int currentNumber;

    public void setNumber(int number)
    {
        currentNumber = number;
    }
    
}
