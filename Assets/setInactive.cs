using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setInactive : MonoBehaviour {
    [SerializeField]
    private int slotLocation;
    [SerializeField]
    private GameObject gameManager;
    private FieldManager fieldGM;

	public void deactivateSquare(int value, bool isEnabled)
    {
        GetComponent<Collider>().enabled = isEnabled;
    }
    public void Start()
    {
        fieldGM = gameManager.GetComponent<FieldManager>();
    }
}
