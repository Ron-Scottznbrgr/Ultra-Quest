﻿using UnityEngine;
using System.Collections;

public class DamageEnemy : MonoBehaviour {

	//Add this to sword, give it collider, and animation


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") {
			Destroy (other.gameObject);
		}
	}

}
