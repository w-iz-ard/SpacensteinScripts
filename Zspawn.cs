//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Zspawn : MonoBehaviour {

	public int toSpawn;
	public GameObject cube;
	// Use this for initialization
	void Start () {
		toSpawn = 50;
	}
	
	// Update is called once per frame
	void Update () {
		if (toSpawn>-1){
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 2);
		Instantiate (cube, new Vector3 (transform.position.x, (transform.position.y), transform.position.z), Quaternion.identity);
			toSpawn -=1;
			Gamestats.wallsSpawned +=1;
		}
		if (toSpawn <= -1) {
			Destroy(gameObject);		
		}
	}
}
