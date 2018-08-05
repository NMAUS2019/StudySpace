using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(BoxCollider2D))]

public class MoveImage : MonoBehaviour {

private Vector3 screenPoint;
private Vector3 offset;
private float _lockedYPosition;

 void OnMouseDown() {
	 	screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.parent.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		Cursor.visible = false;
		print("Mouse down!");
 }

 void OnMouseDrag()
 {
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
    transform.parent.position = curPosition;
    print("Mouse input is: " + curScreenPoint);
    print("Screen translation is: " + Camera.main.ScreenToWorldPoint(curScreenPoint));
 }

 void OnMouseUp()
 {
    Cursor.visible = true;
  }
  
}
