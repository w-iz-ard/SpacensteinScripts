//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {
	public GameObject looker;
	public int whichProp;
	public int rand;
	public SpriteRenderer sR;

	public Sprite s1;
	public Sprite s2;
	public Sprite s3;
	public Sprite s4;
	public Sprite s5;
	public Sprite s6;
	public Sprite s7;
	public Sprite s8;

	// Use this for initialization
	void Start () {
		looker = GameObject.FindGameObjectWithTag ("Player");
		sR = gameObject.GetComponent<SpriteRenderer>();
		rand = Random.Range (0, 2);
		if (rand==0){
			whichProp = Gamestats.prop1;
		}
		if (rand==1){
			whichProp = Gamestats.prop2;
		}
		switch (whichProp) {
		
		case 0:
			sR.sprite = s1;
			break;
		case 1:
			sR.sprite = s2;
			break;
		case 2:
			sR.sprite = s3;
			break;
		case 3:
			sR.sprite = s4;
			break;
		case 4:
			sR.sprite = s5;
			break;
		case 5:
			sR.sprite = s6;
			break;
		case 6:
			sR.sprite = s7;
			break;
		case 7:
			sR.sprite = s8;
			break;

		}


	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (transform.position + looker.transform.rotation * Vector3.back , looker.transform.rotation * Vector3.up);
	}
}
