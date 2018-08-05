using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteNote : MonoBehaviour {

	void OnTriggerEnter(Collider coll){
		print("Collided!");
		if(coll.gameObject.transform.parent.gameObject.tag == "Note"){
			Destroy(coll.gameObject.transform.parent.gameObject);
			Cursor.visible = true;
			print("Destroyed!");
		}
	}

	public void deleteNote(){
		Destroy(transform.parent.gameObject);
		print("Destroyed!");
    Cursor.visible = true;
	}
}
