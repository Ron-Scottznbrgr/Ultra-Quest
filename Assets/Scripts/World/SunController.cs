using UnityEngine;
using System.Collections;

public class SunController : MonoBehaviour {

	public Light theSun; 
	// Use this for initialization
	void Start () {


		theSun = GetComponent<Light> ();
		//SunIntensity.intensity = 5;
	
	}
	
	// Update is called once per frame
	void Update () {
		//theSun.color = Color.Lerp (color0,color1,timetoLerp);
		//sun intensity lerp(currentTime, next hour,mins remaining).;
	} 

	public void SetSunIntensity(float newIntensity){
		//Debug.Log ("Sun Class:");
		theSun.intensity = newIntensity;

	}

	public void SetSunColor(Color newColor){
		//Debug.Log ("Sun Class:");
		theSun.color=newColor;

	}

}
