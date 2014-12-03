//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class ExplosionFire : MonoBehaviour {
	public GameObject blood;
	// Use this for initialization
	void Start () {
		StartCoroutine (Disappear ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col)
	{
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
	IEnumerator Disappear(){
		yield return new WaitForSeconds(0.95f);
		Destroy(gameObject);
	}
}
