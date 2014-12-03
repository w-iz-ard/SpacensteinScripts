//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class BloodScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (Destroy ());
	}

	IEnumerator Destroy(){
		yield return new WaitForSeconds(0.5f);
		Destroy(gameObject);
	}
}
