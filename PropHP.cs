//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class PropHP : MonoBehaviour {
	public int hitPoints;
	public GameObject junk;
	// Use this for initialization
	void Start () {
		hitPoints = Gamestats.enemyHP;
	}
	
	// Update is called once per frame
	void Update () {
		if (hitPoints <= 0) {
			Instantiate (junk, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (junk, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (junk, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Destroy(gameObject);		
		}
	}
}
