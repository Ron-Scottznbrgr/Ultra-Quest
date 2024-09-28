using UnityEngine;
using System.Collections;

public class SpotlightController : MonoBehaviour {


	private SunController GlobalLight;
	private Light myLight; 
	public bool isTorch, torchOverride, spotlightOverride;
	// Use this for initialization
	void Start () {
		GlobalLight = FindObjectOfType<SunController> ();
		myLight = GetComponent<Light> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (GlobalLight.theSun.intensity < 0.6f && isTorch) {
			if (!torchOverride) {
				myLight.intensity = 1f;
				myLight.spotAngle = 100f;
				myLight.range = 15;
			}
		} else 
		{
			if (GlobalLight.theSun.intensity < 0.4f) {
				if (!spotlightOverride){

				myLight.intensity = 0.72f;
					myLight.spotAngle = 51.3f;
					myLight.range = 10;
				}
			} else {
				myLight.intensity = 0f;

			}

			
		}




	}
}
