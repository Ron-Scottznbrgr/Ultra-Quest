using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

	public int minutes,hours,days;
	public float timeBetweenMinutes,timeCounter;
	private SunController theSun;
	private WorldManager theWorld;
	private Color newSunColor;
	private float newSunIntensity;

	// Use this for initialization
	void Start () {
		theSun = FindObjectOfType<SunController> ();
		theWorld = FindObjectOfType<WorldManager> ();
		timeBetweenMinutes = 2.5f;
		timeCounter = 0;	//timeBetweenMinutes;
	



	}
	
	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime;//*timeBetweenMinutes;

		if (timeCounter>= timeBetweenMinutes) {
			minutes += 1;
			if (minutes == 60) {
				hours += 1;
				minutes = 0;
			}
			if (hours == 24) {
				hours = 0;
				days += 1;
			}
		timeCounter = 0f;//timeBetweenMinutes;
		}



		if (minutes == 2) {
			newSunColor.r = 100f /255f;
			newSunColor.b = 255f /255f;
			newSunColor.g = 100f /255f;
			newSunColor.a = 1f;


			theWorld.UpdateSun (newSunColor, newSunIntensity);
			//theSun.SetSunColor (newSunColor);
		
			//theSun.SetSunIntensity (0.3f);
		}
	}


	public void getSunValues (){
		newSunColor.a = 1f;

		switch (hours) {
		case 0:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 1:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 2:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 3:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 4:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 5:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 6:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 7:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 8:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 9:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 10:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 11:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 12:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 13:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 14:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 15:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 16:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 17:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 18:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 19:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 20:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 21:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 22:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		case 23:
			newSunColor.r = 255f / 255f;
			newSunColor.b = 255f / 255f;
			newSunColor.g = 255f / 255f;
			newSunIntensity = 1.0f;
			break;
		}
		theSun.SetSunColor (newSunColor);
		theSun.SetSunIntensity (newSunIntensity);
	}

}
