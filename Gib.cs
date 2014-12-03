//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Gib : MonoBehaviour {
	public Sprite g1;
	public Sprite g2;
	public Sprite g3;
	public Sprite g4;
	public Sprite g5;
	public Sprite g6;
	public Sprite g7;
	public Sprite g8;
	public SpriteRenderer sR;
	int R;
	// Use this for initialization
	void Start () {
		sR = gameObject.GetComponent<SpriteRenderer> ();
		R = Random.Range (0, 8);
		switch (R) {
		case 0:
			sR.sprite = g1;
			break;
		case 1:
			sR.sprite = g2;
			break;
		case 2:
			sR.sprite = g3;
			break;
		case 3:
			sR.sprite = g4;
			break;
		case 4:
			sR.sprite = g5;
			break;
		case 5:
			sR.sprite = g6;
			break;
		case 6:
			sR.sprite = g7;
			break;
		case 7:
			sR.sprite = g8;
			break;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
