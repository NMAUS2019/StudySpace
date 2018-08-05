using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddImage : MonoBehaviour {

public Transform notePrefab;
//public GameObject testObject;
//public Texture2D test;
public AddWorkspace workspaceScript;

	public void createImage(){
		Transform created = Instantiate(notePrefab, new Vector3(0,0,0),
												Quaternion.identity, workspaceScript.workspaces[workspaceScript.currentSpace]);
		PickImage(512, created.gameObject);
	}

	private void PickImage( int maxSize, GameObject imageObj)
{
	NativeGallery.Permission permission = NativeGallery.GetImageFromGallery( ( path ) =>
	{
		Debug.Log( "Image path: " + path );
		if( path != null )
		{
			// Create Texture from selected image
			Texture2D test = NativeGallery.LoadImageAtPath( path, maxSize );
			if( test == null )
			{
				Debug.Log( "Couldn't load texture from " + path );
				return;
			}

			// Assign texture to a temporary quad and destroy it after 5 seconds
		/*	GameObject quad = GameObject.CreatePrimitive( PrimitiveType.Quad );
			quad.transform.position = new Vector3(0,0,0);//Camera.main.transform.position + Camera.main.transform.forward * 2.5f;
			quad.transform.forward = Camera.main.transform.forward;
			quad.transform.localScale = new Vector3( 1f, test.height / (float) test.width, 1f );

			Material material = quad.GetComponent<Renderer>().material;
			if( !material.shader.isSupported ) // happens when Standard shader is not included in the build
				material.shader = Shader.Find( "Legacy Shaders/Diffuse" );
*/
			//material.mainTexture = test;
			Sprite mySprite = Sprite.Create(test, new Rect(0.0f, 0.0f, test.width, test.height), new Vector2(0.5f, 0.5f), 100.0f);
			imageObj.GetComponent<Image>().sprite = mySprite;

		//	Destroy( quad, 5f );

			// If a procedural texture is not destroyed manually,
			// it will only be freed after a scene change
			//Destroy( texture, 5f );
		}
	}, "Select a PNG image", "image/png", maxSize );

	Debug.Log( "Permission result: " + permission );
}
}
