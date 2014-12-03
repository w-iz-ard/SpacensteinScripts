//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class FlagSprite : MonoBehaviour {
	private SpriteRenderer sR;

	public Sprite flagUS;
	public Sprite flagUSSR;
	// Use this for initialization
	void Start () {
		sR = gameObject.GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
	if (Gamestats.startWorldGen == 1) {
						if (Gamestats.nation == 0) {
								sR.sprite = flagUS;		
						}
						if (Gamestats.nation == 1) {
								sR.sprite = flagUSSR;		
						}
			Destroy (this);
				}

	}

}
