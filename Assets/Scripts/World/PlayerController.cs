using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private Animator anim;
	private Rigidbody2D myRigidBody;

	public bool playerMoving,controlsUnlocked;
	public string entryPoint;

	private Vector2 lastMove;

	private static bool playerExists;

	private SpotlightController myLight;

	//private Vector2 warpCoords;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		myRigidBody = GetComponent <Rigidbody2D> ();
		myLight = GetComponentInChildren<SpotlightController> ();


		if (!playerExists) {
			playerExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} 
		else 
		{
			Destroy (gameObject);
		}

		controlsUnlocked = true;
		//Input.ResetInputAxes();

	}
	
	// Update is called once per frame
	void Update () {

		playerMoving = false;
		//Moving Left or Right...
		if (controlsUnlocked == true) {

			if (Input.GetAxisRaw ("Horizontal") > 0.5f || (Input.GetAxisRaw ("Horizontal") < -0.5f)) {
				//Moves the player
				myRigidBody.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * moveSpeed, myRigidBody.velocity.y);
				//	//transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,0f,0f));	

				//Lets the Animator know the player has moved
				playerMoving = true;
				//Puts the Direction Moved into the lastMoved Vector2
				lastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
			}

			//Moving Up or Down...
			if (Input.GetAxisRaw ("Vertical") > 0.5f || (Input.GetAxisRaw ("Vertical") < -0.5f)) {
				myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, Input.GetAxisRaw ("Vertical") * moveSpeed);
				//	//transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime,0f));	
				playerMoving = true;
				lastMove = new Vector2 (0f, Input.GetAxisRaw ("Vertical"));
			}

			if (Input.GetAxisRaw ("Horizontal") < 0.5f && (Input.GetAxisRaw ("Horizontal") > -0.5f)) {
				myRigidBody.velocity = new Vector2 (0f, myRigidBody.velocity.y);
			}

			if (Input.GetAxisRaw ("Vertical") < 0.5f && (Input.GetAxisRaw ("Vertical") > -0.5f)) {
				myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, 0f);
			}

		}

		/*   MOUSE TORCH CONTROLS
		if (Input.GetMouseButtonDown (0)) {
			myLight.isTorch = true;
		} else if (Input.GetMouseButtonDown (1)) {
			myLight.isTorch = false;
		}*/

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (myLight.isTorch) {
				myLight.isTorch = false;
			} else {
				myLight.isTorch = true;
			}
		}



		//Tells animoator we are moving on X axis/Y axis
		anim.SetFloat ("MoveX", Input.GetAxisRaw ("Horizontal"));
		anim.SetFloat ("MoveY", Input.GetAxisRaw ("Vertical"));
		//Tells the animator we are moving
		anim.SetBool ("PlayerMoving", playerMoving);
		//Tells the Animator the last Moved direction in X/Y
		anim.SetFloat ("LastMoveX", lastMove.x);
		anim.SetFloat ("LastMoveY", lastMove.y);


	}


	/*
	public void Warp(Vector2 warpCoords){

		this.transform.position = transform.position;
		this.transform.position = new Vector3 (warpCoords.x, warpCoords.y, this.transform.position.z);

	}
	*/

	public void ControlsUnlocked(bool lockOrNot){
		Input.ResetInputAxes();
		controlsUnlocked = lockOrNot;

	}
}
	