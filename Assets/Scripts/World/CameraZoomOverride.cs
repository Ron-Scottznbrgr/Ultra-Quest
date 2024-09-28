using UnityEngine;
using System.Collections;

public class CameraZoomOverride : MonoBehaviour {

	private CameraController theCamera;
	public float customZoom=5.0f;

	// Use this for initialization
	void Start () {
		theCamera = FindObjectOfType<CameraController> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			theCamera.CameraOverride (true, customZoom);
		}
	}


	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.name == "Player"){
			theCamera.CameraOverride (false, 0f);
		}
	}
}
