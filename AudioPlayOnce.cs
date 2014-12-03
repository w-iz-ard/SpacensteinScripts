//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class AudioPlayOnce : MonoBehaviour {
	public AudioClip sfx;

	// Use this for initialization
	void Start () {

		AudioSource.PlayClipAtPoint(sfx,transform.position, 0.1f);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
