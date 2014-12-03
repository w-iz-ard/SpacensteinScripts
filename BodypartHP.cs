//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class BodypartHP : MonoBehaviour {
	public int hitPoints;
	public GameObject gib;

	// Use this for initialization
	void Start () {
		hitPoints = 5;

	}
	
	// Update is called once per frame
	void Update () {
		if (hitPoints <= 0) {
			Instantiate (gib, new Vector3 (transform.position.x, 2, transform.position.z), Quaternion.identity);
			Instantiate (gib, new Vector3 (transform.position.x, 2, transform.position.z), Quaternion.identity);
			Destroy (gameObject);
				}
	}
}
