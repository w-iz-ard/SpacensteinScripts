//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Lazer2 : MonoBehaviour {
	public AudioClip sfx;
	public GameObject blood;
	public GameObject explosion;
	// Use this for initialization
	void Start () {
		transform.rotation = GameObject.FindGameObjectWithTag ("Player").transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddRelativeForce (new Vector3 (0,0,Gamestats.weaponSpeed));

		StartCoroutine (Disappear ());
	}
	IEnumerator Disappear(){
		yield return new WaitForSeconds(3);
		Instantiate (explosion, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		Destroy(gameObject);
	}
	void OnCollisionEnter(Collision col)
	{
		AudioSource.PlayClipAtPoint (sfx, transform.position, 0.1f);
		if (col.gameObject.tag == "Enemy") {
			col.gameObject.GetComponent<Monster>().hitPoints -=Gamestats.weaponSTR;
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		if (col.gameObject.tag == "Prop") {
			col.gameObject.GetComponent<PropHP>().hitPoints -=Gamestats.weaponSTR;
		}
		if (col.gameObject.tag == "BodyPart") {
			col.gameObject.GetComponent<BodypartHP>().hitPoints -=Gamestats.weaponSTR;
			Instantiate (blood, new Vector3 (transform.position.x, 2, transform.position.y), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
	}
}