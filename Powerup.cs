//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Powerup : MonoBehaviour {

	public Sprite s1;
	public Sprite s2;
	public Sprite s3;
	public Sprite s4;
	public Sprite s5;
	public Sprite s6;
	public Sprite s7;
	public Sprite s8;
	public Sprite s9;
	public Sprite s10;

	public AudioClip sfx;

	int effect;
	int badEffect;
	int random2;

	SpriteRenderer sR;

	// Use this for initialization
	void Start () {
		sR = gameObject.GetComponent<SpriteRenderer> ();
		effect = Random.Range (0, 10);
		switch (effect) {
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
		case 8:
			sR.sprite = s9;
			break;
		case 9:
			sR.sprite = s10;
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col)
	{

				if (col.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint(sfx,transform.position, 0.1f);

						switch (effect) {

						case 0:
								Gamestats.maxSpeed += 0.1f;
				PowerText.textDisplay =1;
				Destroy (gameObject);
								break;
						case 1:
								Gamestats.maxHP += 1;
				PowerText.textDisplay =2;
				Destroy (gameObject);
								break;
						case 2:
								Gamestats.turnSpeed += 1;
				PowerText.textDisplay =3;
				Destroy (gameObject);
								break;
						case 3:
								Gamestats.ammo += 10;
				PowerText.textDisplay =4;
				Destroy (gameObject);
								break;
						case 4:
								Gamestats.currentHP += 10;
				PowerText.textDisplay =5;
				Destroy (gameObject);
								break;
						case 5:
				StartCoroutine(BadEffect());
								break;
						case 6:
								effect= Random.Range(0,10);
				Destroy (gameObject);
								break;
						case 7:
								Gamestats.weaponSTR += 1;
				Destroy (gameObject);
				PowerText.textDisplay =6;
								break;
						case 8:
								Gamestats.weaponSpeed += 1;
				Destroy (gameObject);
				PowerText.textDisplay =7;
								break;
						case 9:
								Gamestats.weaponTime += 1;
				Destroy (gameObject);
				PowerText.textDisplay =8;
								break;
						}
				}
		}

		IEnumerator BadEffect (){
			badEffect = Random.Range(0,3);
		switch (badEffect) {
		case 0:
			Gamestats.enemyHP +=5;
			PowerText.textDisplay =11;
			break;
		case 1:
			Gamestats.enemySpeed +=0.1f;
			PowerText.textDisplay =12;
			break;
		case 2:
			Gamestats.enemySTR +=1;
			PowerText.textDisplay =13;
			break;

		}
		yield return new WaitForSeconds (0.01f);
		Destroy (gameObject);

		}

}
