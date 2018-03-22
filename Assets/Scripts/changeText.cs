using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeText : MonoBehaviour {
    private string cubeText;
    [SerializeField]
    private float movingMax, movingRate;
    private int timer;
    private bool moving = true;

    private void moveEffect()
    {
        transform.Rotate(Vector3.forward * movingRate);
    }
    public void stopMovement()
    {
        moving = false;
        transform.rotation = (Quaternion.identity);
    }

	void Awake () {this.GetComponent<TextMesh>().text = GetComponentInParent<CubeControls>().getText();}

	void Update ()
    {
        if(moving)
            moveEffect();
        timer++;
        if(timer >= movingMax)
        {
            movingRate *= -1;
            timer = 0;
        }
	}
}
