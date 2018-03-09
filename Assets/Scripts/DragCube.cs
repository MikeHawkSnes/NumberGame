using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragCube : MonoBehaviour {
    private struct setMouse
    {
        public Vector3 mouseVector;
        public Vector3 positionOffset;
        public Vector3 currentScreenSpace;
        public Vector3 currentPosition;
    }
    setMouse myMouse = new setMouse();
    private void onMouseDown()
    {
        myMouse.mouseVector  = Camera.main.WorldToScreenPoint(transform.position);
        myMouse.positionOffset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(
                                                        Input.mousePosition.x,Input.mousePosition.y, 
                                                        myMouse.mouseVector.z));
    }

    private void OnMouseDrag()
    {
        myMouse.currentScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y,
                                                                        myMouse.mouseVector.z);
        myMouse.currentPosition = Camera.main.ScreenToWorldPoint(myMouse.currentScreenSpace)
                                                                            + myMouse.positionOffset;
        transform.position = new Vector3(myMouse.currentPosition.x, myMouse.currentPosition.y);
    }
}
