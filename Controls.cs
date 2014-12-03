//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	public float maxSpeed;
	public int turnSpeed;
	public Vector3 V;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		maxSpeed = Gamestats.maxSpeed;
		turnSpeed = Gamestats.turnSpeed;
		if (Gamestats.worldGenFinished == 1) {
						if (Input.GetKey (KeyCode.W)) {
								rigidbody.AddRelativeForce (new Vector3 (0, 0, 20));	
						}

						if (Input.GetKey (KeyCode.S)) {
								rigidbody.AddRelativeForce (new Vector3 (0, 0, (-20)));	

						}

						if ((Input.GetKey (KeyCode.D) && (Input.GetKey (KeyCode.RightAlt)))) {
								rigidbody.AddRelativeForce (new Vector3 (20, 0, 0));
						}
						if ((Input.GetKey (KeyCode.A) && (Input.GetKey (KeyCode.RightAlt)))) {
								rigidbody.AddRelativeForce (new Vector3 (-20, 0, 0));
						}

						if (Input.GetKey (KeyCode.D) && !(Input.GetKey (KeyCode.RightAlt))) {
								transform.Rotate (new Vector3 (0, turnSpeed, 0) * Time.deltaTime);
						}
						if (Input.GetKey (KeyCode.A) && !(Input.GetKey (KeyCode.RightAlt))) {
								transform.Rotate (new Vector3 (0, -turnSpeed, 0) * Time.deltaTime);
						}
						if (Input.GetKey (KeyCode.UpArrow)) {
								rigidbody.AddRelativeForce (new Vector3 (0, 0, 20));	
						}
		
						if (Input.GetKey (KeyCode.DownArrow)) {
								rigidbody.AddRelativeForce (new Vector3 (0, 0, (-20)));	
			
						}
		
						if ((Input.GetKey (KeyCode.RightArrow) && (Input.GetKey (KeyCode.RightAlt)))) {
								rigidbody.AddRelativeForce (new Vector3 (20, 0, 0));
						}
						if ((Input.GetKey (KeyCode.LeftArrow) && (Input.GetKey (KeyCode.RightAlt)))) {
								rigidbody.AddRelativeForce (new Vector3 (-20, 0, 0));
						}
		
						if (Input.GetKey (KeyCode.RightArrow) && !(Input.GetKey (KeyCode.RightAlt))) {
								transform.Rotate (new Vector3 (0, turnSpeed, 0) * Time.deltaTime);
						}
						if (Input.GetKey (KeyCode.LeftArrow) && !(Input.GetKey (KeyCode.RightAlt))) {
								transform.Rotate (new Vector3 (0, -turnSpeed, 0) * Time.deltaTime);
						}
				}
		if (Mathf.Abs(rigidbody.velocity.z) > maxSpeed)
		{
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, Mathf.Sign(rigidbody.velocity.z) * maxSpeed);
		}

		if (Mathf.Abs(rigidbody.velocity.x) > maxSpeed)
		{
			rigidbody.velocity = new Vector3(Mathf.Sign(rigidbody.velocity.x) * maxSpeed, rigidbody.velocity.y, rigidbody.velocity.z);
		}
			V = rigidbody.velocity;
	
	}
	void OnCollisionEnter(Collision col)
	{

		if ((Gamestats.worldGenFinished == 0) && (col.gameObject.tag == "Prop"))
						Destroy (col.gameObject);
			Debug.Log("hit");
			}
	}



