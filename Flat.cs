//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Flat : MonoBehaviour {
	public GameObject looker;
	// Use this for initialization
	void Start () {
		looker = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (transform.position + looker.transform.rotation * Vector3.back , looker.transform.rotation * Vector3.up);
	}
}
