using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNote : MonoBehaviour {

public Transform notePrefab;
public AddWorkspace workspaceScript;
private int menuOpen = 0;

	public void createNote(){
		Transform created = Instantiate(notePrefab, new Vector3(transform.parent.position.x,transform.parent.position.y, transform.parent.position.z),
												Quaternion.identity, workspaceScript.workspaces[workspaceScript.currentSpace]);
	/*	foreach(Transform child in transform){
			child.gameObject.SetActive(false);
			print("Deactived!");
		}*/
		//GetComponent<Image>().enabled = true;
	}

	public void showMenu(){
		if(menuOpen == 0){
			foreach(Transform child in transform){
				child.gameObject.SetActive(true);
			}
			menuOpen = 1;
		}
		else{
			foreach(Transform child in transform){
				child.gameObject.SetActive(false);
			}
			menuOpen = 0;
		}
	//	GetComponent<Image>().enabled = false;
	}
}
