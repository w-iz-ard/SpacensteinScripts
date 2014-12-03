//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Xspawn : MonoBehaviour {

	public int toSpawn;
	public GameObject Zcube;
	// Use this for initialization
	void Start () {
		toSpawn = 50;
	}
	
	// Update is called once per frame
	void Update () {
		if (Gamestats.startWorldGen == 1) {
						if (toSpawn > -1) {
								transform.position = new Vector3 (transform.position.x + 2, transform.position.y, transform.position.z);
								Instantiate (Zcube, new Vector3 (transform.position.x, (transform.position.y), transform.position.z), Quaternion.identity);
								toSpawn -= 1;
								Gamestats.wallsSpawned += 1;
						}
						if (toSpawn <= -1) {
								Destroy (gameObject);		
						}
				}
	}
}