//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class DeathText : MonoBehaviour {
	public int deaths;
	// Use this for initialization
	void Start () {
		deaths = PlayerPrefs.GetInt ("Deaths");
	}
	
	// Update is called once per frame
	void Update () {
		(GetComponent<TextMesh> ()).text = ("Deaths: " + deaths);
	}
}
