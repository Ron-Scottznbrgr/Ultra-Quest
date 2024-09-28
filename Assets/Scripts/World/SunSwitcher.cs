using UnityEngine;
using System.Collections;

public class SunSwitcher : MonoBehaviour {

	public float SceneLightIntensity=1.0f;
	private SunController GlobalLight;
	private float defaultSun;
	// Use this for initialization
	void Start () {
		GlobalLight = FindObjectOfType<SunController> ();
		defaultSun = GlobalLight.theSun.intensity;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			GlobalLight.SetSunIntensity (SceneLightIntensity);
		}
	}


	void OnTriggerExit2D(Collider2D other){
	if (other.gameObject.name == "Player"){
			GlobalLight.SetSunIntensity(defaultSun);
	}
}
}
