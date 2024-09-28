using UnityEngine;
//using UnityEngine.SceneManagement;//for garbage collision code thing
using System.Collections;

public class BanditController : MonoBehaviour {

	public float moveSpeed;
	private Animator anim;
	private Rigidbody2D myRigidBody;
	public bool banditMoving;
	public float timeToMove, timeBetweenMove;
	private float timeBetweenMoveCounter, timeToMoveCounter;
	private Vector3 moveDirection;
	private Vector2 lastMove;

	//public float waitToReload;
	//private bool reloading;


	private PlayerController thePlayer;


	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

		timeBetweenMoveCounter =  Random.Range(timeBetweenMove*0.75f,timeBetweenMove*1.25f);

		timeToMoveCounter =  Random.Range(timeToMove*0.75f,timeToMove*1.25f);

		thePlayer = FindObjectOfType<PlayerController> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		if (banditMoving) 
		{
			timeToMoveCounter -= Time.deltaTime;
			myRigidBody.velocity = moveDirection;


			//Tells animoator we are moving on X axis/Y axis

			//Tells the animator we are moving
		

			if (timeToMoveCounter < 0f) {
				banditMoving = false;
				timeBetweenMoveCounter = Random.Range(timeBetweenMove*0.75f,timeBetweenMove*1.25f);

			}
		}
		else 
		{
			timeBetweenMoveCounter -= Time.deltaTime;
			myRigidBody.velocity = Vector2.zero;


			if (timeBetweenMoveCounter < 0f) 
			{
				banditMoving = true;
				timeToMoveCounter = Random.Range(timeToMove*0.75f,timeToMove*1.25f);

				if (thePlayer.transform.position.x <= myRigidBody.transform.position.x)
				{
					moveDirection = new Vector3(Random.Range(-1f,0f)*moveSpeed,moveDirection.y,0f);
				}
				else
				{
					moveDirection = new Vector3(Random.Range(0f,1f)*moveSpeed,moveDirection.y,0f);
				}

				if (thePlayer.transform.position.y <= myRigidBody.transform.position.y)
				{
					moveDirection = new Vector3(moveDirection.x, Random.Range(-1f,0f)*moveSpeed,0f);
				}
				else
				{
					moveDirection = new Vector3(moveDirection.x, Random.Range(0f,1f)*moveSpeed,0f);
				}




				//moveDirection = new Vector3(Random.Range(-1f,1f)*moveSpeed,Random.Range(-1f,1f)*moveSpeed,0f);
				lastMove = new Vector2 (moveDirection.x, moveDirection.y);

			}
		}
		anim.SetFloat ("MoveX", lastMove.x);
		anim.SetFloat ("MoveY", lastMove.y);
		anim.SetBool ("BanditMoving", banditMoving);
		anim.SetFloat ("LastMoveX", lastMove.x);
		anim.SetFloat ("LastMoveY", lastMove.y);


		/*if (reloading) {

			waitToReload -= Time.deltaTime;
			if (waitToReload < 0) {
				SceneManager.LoadScene ("Test_2");
			}
		}*/



	}

	void OnCollisionEnter2D (Collision2D other){
		/*
		if (other.gameObject.name == "player") {
			//This kills the player lol. Do damage code here
			other.gameObject.SetActive (false);
			reloading = true;

		}
	}*/
	}
}
