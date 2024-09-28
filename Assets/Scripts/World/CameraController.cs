using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject followTarget;
	private Vector3 targetPosition;
	public float moveSpeed;

	private static bool cameraExists;
	private float minZoom = 2.0f;
	private float torchZoom = 3.0f;
	private float maxZoom = 5.0f;
	private float zoomSpeed = 2.5F;
	private float tempZoom;

	public bool camSizeOverride; //to be private
	private Camera myCam;
	public float camZoom;
	public double roundCam;
	private SunController theSun;
	private SpotlightController playerLight;
	//private float sunFloat;
	// Use this for initialization
	void Start () {

		myCam = GetComponent<Camera> ();
		playerLight = FindObjectOfType<SpotlightController> ();
		theSun = FindObjectOfType<SunController> ();
		if (!cameraExists) {
			cameraExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} 
		else 
		{
			Destroy (gameObject);
		}
	}

	
	// Update is called once per frame
	void Update () {
		//Camera destination = Targets X, Targets Y, keep Z the same
		targetPosition = new Vector3 (followTarget.transform.position.x + 0.5f, followTarget.transform.position.y - 0.5f, transform.position.z);

		//Move Camera = Movefrom Camera pos -> Target pos, over the course of Movespeed per frame
		transform.position = Vector3.Lerp (transform.position, targetPosition, moveSpeed * Time.deltaTime);


		if (!camSizeOverride) {
			roundCam = System.Math.Round (myCam.orthographicSize, 1);
			if (playerLight.isTorch && (minZoom + (theSun.theSun.intensity * 3)) < 3) {
				camZoom = torchZoom;
				if (camZoom < myCam.orthographicSize) {
			
					myCam.orthographicSize -= Time.deltaTime * zoomSpeed;
					//Mathf.Clamp(myCam.orthographicSize,2,3);
					//		System.Math.Round (myCam.orthographicSize -= Time.deltaTime,1);
				} else if (camZoom > myCam.orthographicSize) {
					myCam.orthographicSize += Time.deltaTime * zoomSpeed;
					//Mathf.Clamp(myCam.orthographicSize,2,3);
					//System.Math.Round (myCam.orthographicSize  += Time.deltaTime,1);
				} else {
				}

				if (camZoom == (System.Math.Round (myCam.orthographicSize, 1))) {
					myCam.orthographicSize = camZoom;
				}
			} else {
				camZoom = (minZoom + (theSun.theSun.intensity * 3));
				//myCam.orthographicSize  = (2 + (theSun.theSun.intensity * 3));
				if (camZoom < myCam.orthographicSize) {
					myCam.orthographicSize -= Time.deltaTime * zoomSpeed;
					//Mathf.Clamp(myCam.orthographicSize,2,5);				
//					System.Math.Round (myCam.orthographicSize -= Time.deltaTime,1);
				} else if (camZoom > myCam.orthographicSize && myCam.orthographicSize <= maxZoom) {
					myCam.orthographicSize += Time.deltaTime * zoomSpeed;
					//Mathf.Clamp(myCam.orthographicSize,2,5);
					//System.Math.Round (myCam.orthographicSize += Time.deltaTime,1);
				} else {
				}

				if ((System.Math.Round (camZoom, 1)) == (System.Math.Round (myCam.orthographicSize, 1))) {
					myCam.orthographicSize = camZoom;
				} else if (myCam.orthographicSize > maxZoom) {
					myCam.orthographicSize = maxZoom;
				}

			}
			//sunFloat = theSun.theSun.intensity;
			//camType = theSun.theSun.intensity.ToString();
			//	myCam.orthographic = true;
			//Debug.Log (sunFloat);
			//("DERP "+(2 + (theSun.theSun.intensity * 3)));
		
		} else {

			if (tempZoom < myCam.orthographicSize) {
				myCam.orthographicSize -= Time.deltaTime * zoomSpeed;
				//Mathf.Clamp(myCam.orthographicSize,2,5);				
				//					System.Math.Round (myCam.orthographicSize -= Time.deltaTime,1);
			} else if (tempZoom > myCam.orthographicSize && myCam.orthographicSize <= maxZoom) {
				myCam.orthographicSize += Time.deltaTime * zoomSpeed;
				//Mathf.Clamp(myCam.orthographicSize,2,5);
				//System.Math.Round (myCam.orthographicSize += Time.deltaTime,1);
			} else {
			}

			if ((System.Math.Round (tempZoom, 1)) == (System.Math.Round (myCam.orthographicSize, 1))) {
				myCam.orthographicSize = tempZoom;
			} else if (myCam.orthographicSize > maxZoom) {
				myCam.orthographicSize = maxZoom;
			}
		}

	}


	public void CameraOverride (bool changeZoom, float newZoom)
	{
		camSizeOverride = changeZoom;
		tempZoom = newZoom;
	}

	/*
	public void Warp(Vector2 warpCoords){

		this.transform.position = new Vector3 (warpCoords.x, warpCoords.y, this.transform.position.z);

	}*/

}
