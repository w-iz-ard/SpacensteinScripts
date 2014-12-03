//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class PowerText : MonoBehaviour {

	public static int textDisplay;
	// Use this for initialization
	void Start () {
		textDisplay = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (textDisplay == 0) {

			(GetComponent<TextMesh> ()).text = ("");
					
		}
		if (textDisplay > 0) {
			StartCoroutine(ShowText());
		}
	}

	IEnumerator ShowText(){
		switch (textDisplay) {
		case 1:
			(GetComponent<TextMesh> ()).text = ("GOTTA GO FAST");
			break;
		case 2:
			(GetComponent<TextMesh> ()).text = ("MAX HEALTH UP");
			break;
		case 3:
			(GetComponent<TextMesh> ()).text = ("TURN SPEED UP");
			break;
		case 4:
			(GetComponent<TextMesh> ()).text = ("+10 AMMO");
			break;
		case 5:
			(GetComponent<TextMesh> ()).text = ("+10 HEALTH");
			break;
		case 6:
			(GetComponent<TextMesh> ()).text = ("WEAPON STRENGTH UP");
			break;
		case 7:
			(GetComponent<TextMesh> ()).text = ("WEAPON FORCE UP");
			break;
		case 8:
			(GetComponent<TextMesh> ()).text = ("SHOT DURATION UP");
			break;
		case 9:
			(GetComponent<TextMesh> ()).text = ("ONE SMALL STEP");
			break;
		case 10:
			(GetComponent<TextMesh> ()).text = ("GOOD LUCK COMRADE");
			break;


		case 11:
			(GetComponent<TextMesh> ()).text = ("+5 ENEMY HP");
			break;
		case 12:
			(GetComponent<TextMesh> ()).text = ("FASTER ENEMIES");
			break;
		case 13:
			(GetComponent<TextMesh> ()).text = ("STRONGER ENEMIES");
			break;


		}
		yield return new WaitForSeconds(1f);
		textDisplay = 0;
	}
}
