using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControls : MonoBehaviour {
    [SerializeField]
    private int cubeValue;
    [SerializeField]
    private GameObject GM;
    private FieldManager Field;
    private Vector3 setInPlace;
    private bool colided;

    public string getText()
    {
        return cubeValue.ToString();
    }

    private void OnMouseUp()
    {
        if (colided)
        {
            transform.position = setInPlace;  
        }
            
    }
    private void OnTriggerEnter(Collider checkBoard)
    {
        if (checkBoard.gameObject.tag == "FieldSlot")
        {
            setInPlace = (checkBoard.gameObject.transform.position);
            colided = true;
        }
    }
    private void Start()
    {
        Field = GM.GetComponent<FieldManager>();
    }

}
