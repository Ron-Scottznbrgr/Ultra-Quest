using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {
	private CameraController theCamera;
	private MusicSwitcher theMusic;
	private WorldManager theWorld;
	public int SceneMusicTrackNumber=0;
	public float SceneLightIntensity;

	public bool Inside,useDifferentColor;
	public Color SceneLightColor;
	// Use this for initialization
	void Start () {
		theCamera = FindObjectOfType<CameraController> ();
		theWorld = FindObjectOfType<WorldManager> ();
		theMusic = FindObjectOfType<MusicSwitcher> ();
	
		if (Inside) {
			if (!useDifferentColor) {
				SceneLightColor.a = 1f;
				SceneLightColor.r = 1f;
				SceneLightColor.g = 1f;
				SceneLightColor.b = 1f;

			} else {

			}
		} else {
			//theTime.getSunValues();
		}


		//Debug.Log (SceneMusicTrackNumber);
		theMusic.SetMusicForScene (SceneMusicTrackNumber);

		theCamera.CameraOverride (false, 0f);
		Debug.Log ("Sending " + SceneLightIntensity);
		theWorld.UpdateSceneData (Inside, SceneLightColor, SceneLightIntensity);
	}

	
	// Update is called once per frame
	void Update () {

	
	
	}
}
