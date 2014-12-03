
//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class BossLazer : MonoBehaviour {
	public GameObject blood;
	// Use this for initialization
	void Start () {
		//transform.rotation = GameObject.FindGameObjectWithTag ("Player").transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddRelativeForce (new Vector3 (0,0,50));
		StartCoroutine (Disappear ());
	}
	IEnumerator Disappear(){
		yield return new WaitForSeconds(5);
		Destroy(gameObject);
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player") {
			
			Gamestats.currentHP -= 5;
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Destroy(gameObject);
		}
		
	}
}
