//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class MeleeScript : MonoBehaviour {
	public GameObject blood;
	// Use this for initialization
	void Start () {
		transform.rotation = GameObject.FindGameObjectWithTag ("Player").transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddRelativeForce (new Vector3 (0,0,10));
		StartCoroutine (Disappear ());
	}
	IEnumerator Disappear(){
		yield return new WaitForSeconds(0.4f);
		Destroy(gameObject);
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Enemy") {
			col.gameObject.GetComponent<Monster>().hitPoints -=1;
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		if (col.gameObject.tag == "Prop") {
			col.gameObject.GetComponent<PropHP>().hitPoints -=1;
		}
		if (col.gameObject.tag == "BodyPart") {
			col.gameObject.GetComponent<BodypartHP>().hitPoints -=1;
			Instantiate (blood, new Vector3 (transform.position.x, 2, transform.position.y), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Instantiate (blood, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
	}
}