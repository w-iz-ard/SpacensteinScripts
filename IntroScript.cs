//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class IntroScript : MonoBehaviour {

	public SpriteRenderer sR;
	public Sprite s0;
	public Sprite s1;
	public Sprite s2;
	public Sprite s3;

	// Use this for initialization
	void Start () {
		sR = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Gamestats.nation == 0 && Gamestats.boss ==0) {
			sR.sprite = s0;		
			PowerText.textDisplay = 9;
		}
		if (Gamestats.nation == 1 && Gamestats.boss ==0) {
			sR.sprite = s1;
			PowerText.textDisplay = 10;
		}
		if (Gamestats.nation == 0 && Gamestats.boss ==1) {
			sR.sprite = s2;		
			PowerText.textDisplay = 9;
		}
		if (Gamestats.nation == 1 && Gamestats.boss ==1) {
			sR.sprite = s3;
			PowerText.textDisplay = 10;
		}

		if (Gamestats.worldGenFinished == 1) {
			Destroy(gameObject);		
		}
	
	}
}
