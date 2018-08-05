using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddWorkspace : MonoBehaviour {

	private int NUMB_SPACES = 3;

	public int currentSpace; //Index
	public GameObject workspacesHolder;
	public GameObject workspaceButtons;
	public Transform[] workspaces;
	private int workspaceOpen = 0;

	// Use this for initialization
	void Start () {
		currentSpace = 0;
		workspaces = new Transform[NUMB_SPACES];
		for(int i = 0; i < NUMB_SPACES; i++){
			workspaces[i] = workspacesHolder.transform.Find("Workspace " + (i + 1));
		}
		workspaces[currentSpace].gameObject.SetActive(true);
	}

	public void changeWorkspace(int change){
		workspaces[currentSpace].gameObject.SetActive(false);
		workspaces[change].gameObject.SetActive(true);
		currentSpace = change;
	}

	public void openWorkspaces(){
		print("Called!");
		if(workspaceOpen == 0){
			workspaceButtons.SetActive(true);
			workspaceOpen = 1;
		}
		else{
			workspaceButtons.SetActive(false);
			workspaceOpen = 0;
		}
	}
}
