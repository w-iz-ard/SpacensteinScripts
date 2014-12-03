//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class StartCube : MonoBehaviour {
	public GameObject carver;
	// Use this for initialization
	void Start () {
		Instantiate (carver, new Vector3 (transform.position.x, transform.position.y - 2, transform.position.z), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0,100,0) * Time.deltaTime);
		if (Gamestats.startWorldGen == 1) {
			StartCoroutine (Kill());	
		}
	}
	void OnCollisionEnter(Collision col)
	{
				if (col.gameObject.tag == "Wall") {
						Destroy (col.gameObject);
						if (col.gameObject.tag == "Prop") {
								Destroy (col.gameObject);
						}
				}
		}
		
	IEnumerator Kill(){
			
			yield return new WaitForSeconds(10f);

			Destroy(gameObject);	
		}
	}

