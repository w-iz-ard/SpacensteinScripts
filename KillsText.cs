//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class KillsText : MonoBehaviour {

	public int kills;
	// Use this for initialization
	void Start () {
		kills = PlayerPrefs.GetInt ("Kills");
	}
	
	// Update is called once per frame
	void Update () {
		(GetComponent<TextMesh> ()).text = ("Total Kills: " + kills);
	}
}