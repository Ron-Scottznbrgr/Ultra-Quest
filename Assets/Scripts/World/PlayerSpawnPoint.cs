using UnityEngine;
using System.Collections;

public class PlayerSpawnPoint : MonoBehaviour
{

	//setting up references to the Player and the Camera
	private PlayerController thePlayer;
	private CameraController theCamera;

	//This is the Name of the object the player will spawn on when warping around/loading a scene
	public string entryPoint;


	// Use this for initialization
	void Start ()
	{
		/* Lists all entry points in the map
		Debug.Log (entryPoint); */


		//initializing the player/cam
		thePlayer = FindObjectOfType<PlayerController> ();
		theCamera = FindObjectOfType<CameraController> ();

		//if the player has a entry location they are looking for and it matches this location...
		if (thePlayer.entryPoint == entryPoint) { 
			//move the player/cam to this location
			thePlayer.transform.position = transform.position;
			theCamera.transform.position = new Vector3 (transform.position.x, transform.position.y, theCamera.transform.position.z);
		}
	}
	


	// Update is called once per frame
	void Update ()
	{
	
	}


	// This method accepts a name of an entrance. This method looks through gameobjects and finds that entrance.
	//Note, that in the editor, the GameObject must be named "warpName" and have a child called "Entrance"
	public void Warp (string warpName)
	{
		//Debug text showing what we are trying to warp to
		//Debug.Log ("Try to Warp with : " + thePlayer.entryPoint + " // " + warpName);

		//Finds the entrance object under the name passed to the method
		GameObject warpFinder = GameObject.Find (warpName + "/Entrance");

		//If the player is looking for the same entry point the warp function recieved...
		if (thePlayer.entryPoint == warpName) { 
			//Debug.Log ("Succeed to Warp");
			//Move Player/Cam to entrance object
			thePlayer.transform.position = warpFinder.transform.position;
			theCamera.transform.position = new Vector3 (warpFinder.transform.position.x, warpFinder.transform.position.y, theCamera.transform.position.z);

		}
		//warpFinder = null;
	}

}
