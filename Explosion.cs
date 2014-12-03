//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public int fire;
	public GameObject fireOb;
	// Use this for initialization
	void Start () {
		fire = 0;
	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine (Disappear ());
		if (fire == 0) {
			fire=1;
			StartCoroutine(Fire());
		}
	}
	IEnumerator Disappear(){
		yield return new WaitForSeconds(0.1f * Gamestats.weaponTime);
		Destroy(gameObject);
	}
	IEnumerator Fire(){
		yield return new WaitForSeconds(0.1f);
		Instantiate (fireOb, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		fire = 0;
	}

}