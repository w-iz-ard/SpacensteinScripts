
//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class GameText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		(GetComponent<TextMesh> ()).text = ("HP: " + Gamestats.currentHP+"/"+Gamestats.maxHP + ", Weapon: " + Gamestats.weaponName + "\n Ammo: " + Gamestats.ammo+ 
		                                    ", Weapon Strength: " + Gamestats.weaponSTR + "\n Weapon Force: " + Gamestats.weaponSpeed + ", Shot Length: " + Gamestats.weaponTime+"\n"+
		                                    "Max Speed: " + Gamestats.maxSpeed + ", Turning Speed: " + Gamestats.turnSpeed  + "\n Dungeon Floor: " + Gamestats.dungeonFloor + ", Enemies: "+ Gamestats.enemies);
	}
}
