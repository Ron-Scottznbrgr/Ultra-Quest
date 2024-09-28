using UnityEngine;
using System.Collections;

public class WorldManager : MonoBehaviour {
	private static bool worldManagerExists;

	private SunController theSun;
	private SceneController theScene;

	private TimeManager theTime;
	// Use this for initialization



	private Color SceneLightColor;
	private float SceneLightIntensity;
	private bool SceneInside;

	void Start () {
		theSun = FindObjectOfType<SunController> ();

		theTime = FindObjectOfType<TimeManager> ();


		if (!worldManagerExists) {
			worldManagerExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} 
		else 
		{
			Destroy (gameObject);
		}

		theScene = FindObjectOfType<SceneController> ();
		Debug.Log ("Checking to set sun");
		if (SceneInside==true) {
			theSun.SetSunIntensity (SceneLightIntensity);
			theSun.SetSunColor (SceneLightColor);
		} else {
			theTime.getSunValues();
		}
		//Debug.Log ("derp");


		//Debug.Log ("World Class");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateSun(Color sunColor, float sunIntensity){
		if (SceneInside==true) {
			
		} else {
		//	theTime.getSunValues();
			//Debug.Log ("Update Sun Values");
		}
	}

	public void UpdateSceneData (bool isInside, Color sunColor,float sunIntensity){
		SceneInside= isInside;
		SceneLightIntensity = sunIntensity;
		SceneLightColor = sunColor;
		Debug.Log (SceneInside);
		Debug.Log (SceneLightIntensity);


		if (SceneInside==true) {
			theSun.SetSunIntensity (SceneLightIntensity);
			theSun.SetSunColor (SceneLightColor);
			Debug.Log ("Sun Set");
			//UpdateSun (SceneLightColor, SceneLightIntensity);
		} //else {
			//theTime.getSunValues();
	//	}
	}
}
