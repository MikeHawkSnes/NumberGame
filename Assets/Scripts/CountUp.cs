using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountUp : MonoBehaviour
{
    public void displayValue(int total)
    {
        GetComponentInChildren<TextMesh>().text = total.ToString();
    }
    public void displayValue(string display)
    {
        GetComponentInChildren<TextMesh>().text = display;
    }
    private void Awake()
    {
        GetComponentInChildren<TextMesh>().text = "";
    }
}
