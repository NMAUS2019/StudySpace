using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddVideo : MonoBehaviour {

public Transform videoPrefab;
public AddWorkspace workspaceScript;

public void createVideo(){
	//	Transform created = Instantiate(videoPrefab, new Vector3(0,0,0),
	//											Quaternion.identity, workspaceScript.workspaces[workspaceScript.currentSpace]);
		PickVideo();
	}

	private void PickVideo()
{
	NativeGallery.Permission permission = NativeGallery.GetVideoFromGallery( ( path ) =>
	{
		Debug.Log( "Video path: " + path );
		if( path != null )
		{
			// Play the selected video
			Handheld.PlayFullScreenMovie( "file://" + path );
		}
	}, "Select a video" );

	Debug.Log( "Permission result: " + permission );
}
}
