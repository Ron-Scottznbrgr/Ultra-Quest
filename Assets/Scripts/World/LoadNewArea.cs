using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class LoadNewArea : MonoBehaviour {
	public string leveltoLoad;
	//public Vector2 warpCoords;
	public bool changeScenes = true;

	public string exitPoint;


	private PlayerController thePlayer;
	//private CameraController theCamera;
	private PlayerSpawnPoint theSpawn;


	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
	//	theCamera = FindObjectOfType<CameraController> ();
		theSpawn = FindObjectOfType<PlayerSpawnPoint> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other){

		if (other.gameObject.name == "Player") 
		{
			thePlayer.ControlsUnlocked (false);
			thePlayer.entryPoint = exitPoint;

			if (changeScenes == true) {
				SceneManager.LoadScene (leveltoLoad);
			

			} else {
				theSpawn.Warp (exitPoint);
			
			}

				//Application.LoadLevel (leveltoLoad);
			/*
			thePlayer.Warp (warpCoords);
			theCamera.Warp (warpCoords);
*/
			thePlayer.ControlsUnlocked (true);
		


		}
	}
}
