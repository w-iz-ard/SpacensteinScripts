//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class EvilLazer1 : MonoBehaviour {
	public GameObject blood;
	// Use this for initialization
	void Start () {
		//transform.rotation = GameObject.FindGameObjectWithTag ("Player").transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddRelativeForce (new Vector3 (0,0,10));
		StartCoroutine (Disappear ());
	}
	IEnumerator Disappear(){
		yield return new WaitForSeconds(1f);
		Destroy(gameObject);
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player") {

			Gamestats.currentHP -= Gamestats.enemySTR;
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Destroy(gameObject);
		}

	}
}
