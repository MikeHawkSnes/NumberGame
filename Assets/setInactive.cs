using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setInactive : MonoBehaviour {
    [SerializeField]
    private int slotValue;

	public void deactivateSquare(int value, bool isEnabled)
    {
        slotValue = value;
        GetComponent<Collider>().enabled = isEnabled;
    }
}
