
//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.N)) {
			PlayerPrefs.SetInt (("USMaxHP"), 100);
			PlayerPrefs.SetFloat (("USMaxSpeed"), 1);
			PlayerPrefs.SetInt (("USTurnSpeed"), 100);
			PlayerPrefs.SetInt (("USWeaponSpeed"), 5);
			PlayerPrefs.SetInt (("USWeaponSTR"), 1);
			PlayerPrefs.SetInt (("USWeaponTime"), 10);
			PlayerPrefs.SetInt (("USBossKilled"), 0);


		
			PlayerPrefs.SetInt (("USSRMaxHP"), 100);
			PlayerPrefs.SetFloat (("USSRMaxSpeed"), 1);
			PlayerPrefs.SetInt (("USSRTurnSpeed"), 100);
			PlayerPrefs.SetInt (("USSRWeaponSpeed"), 5);
			PlayerPrefs.SetInt (("USSRWeaponSTR"), 1);
			PlayerPrefs.SetInt (("USSRBossKilled"), 0);
				

			PlayerPrefs.SetInt (("EnemyHP"), 5);
			PlayerPrefs.SetFloat (("EnemySpeed"), 1);
			PlayerPrefs.SetInt (("EnemySTR"), 1);
			PlayerPrefs.SetInt (("DungeonFloor"), 1);

			PlayerPrefs.SetInt (("USSRDiamonds"), 0);
			PlayerPrefs.SetInt (("USDiamonds"), 0);

			PlayerPrefs.SetInt (("Deaths"), 0);
			PlayerPrefs.SetInt (("Kills"), 0);
			Application.LoadLevel("Scene");
		}

		if (Input.GetKeyDown(KeyCode.Space)){
			Application.LoadLevel("Scene");
		}
		if (Input.GetKeyDown(KeyCode.H)){
			Application.LoadLevel("Help");
		}
	}

}
