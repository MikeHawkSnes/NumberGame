using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeText : MonoBehaviour {
    private string cubeText;
    [SerializeField]
    private float movingMax, movingRate;
    private int timer;

    private void moveEffect()
    {
        transform.Rotate(Vector3.forward * movingRate);
    }

	void Awake () {this.GetComponent<TextMesh>().text = GetComponentInParent<CubeControls>().getText();}

	void Update ()
    {
        moveEffect();
        timer++;
        if(timer >= movingMax)
        {
            movingRate *= -1;
            timer = 0;
        }
	}
}
