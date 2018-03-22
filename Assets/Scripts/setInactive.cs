using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setInactive : MonoBehaviour {
    [SerializeField]
    private int slotLocationX, slotLocationY;
    [SerializeField]
    private GameObject gameManager;
    private FieldManager fieldGM;

	public void deactivateSquare(int value)
    {
        GetComponent<Collider>().enabled = fieldGM.setNumber(value, slotLocationX, slotLocationY);
    }
    public void Start()
    {
        fieldGM = gameManager.GetComponent<FieldManager>();
    }
}
