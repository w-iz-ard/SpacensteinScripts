//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class EndingText : MonoBehaviour {
	int display;
	// Use this for initialization
	void Start () {
		display = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
						display += 1;	
				}
			switch (display) {
			case 0:
			(GetComponent<TextMesh> ()).text = ("Calvin Coolidge and Vladimir Lenin were dead. \n The Apollo/Soyuz mission returned to Earth \n " +
			                                    "triumphant. The Space Diamonds made the USA  \n and USSR the world's most powerful countries." );
				break;

		case 1:
			(GetComponent<TextMesh> ()).text = ("Coolidge and Lenin were trying to steal all the Space \n  Diamonds. The world never discovered the awful \n " +
		                                    "truth. Though USA and USSR were always at odds  \n The Apollo/Soyuz crew knew that cooperation. \n " +
		                                    "between the rival nations was possible"  );
		break;
		case 2:
			(GetComponent<TextMesh> ()).text = ("No astronaut or cosmonaut would ever return \n to the horrible planet Spacenstein. \n " +
			                                    "The Apollo/Soyuz mission confirmed life  \n on other planets. However, the USA and USSR \n " +
			                                    "hid the secret from the world."  );
			break;
		case 3:
			(GetComponent<TextMesh> ()).text = ("USA and USSR, BFFs 4EVz!");
			break;
		case 4:
			(GetComponent<TextMesh> ()).text = ("USA and USSR, BFFs 4EVz!");
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
			Application.LoadLevel("Title");
			break;
		}	
	}
}
