//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public GameObject laz1;
	public GameObject laz2;
	public GameObject laz3;
	public GameObject laz4;
	public GameObject melee;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.RightControl)) {
						if (Gamestats.weaponType == 0) {
								if (Gamestats.ammo > 0) {
										Gamestats.ammo -= 1;
										Instantiate (laz1, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
								}
						}
				
						if (Gamestats.weaponType == 2) {
								if (Gamestats.ammo > 0) {
										Gamestats.ammo -= 1;
										Instantiate (laz3, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
								}
						}
				}
		if (Input.GetKey (KeyCode.RightControl)) {
			if (Gamestats.weaponType == 3) {
				if (Gamestats.ammo > 0) {
					Gamestats.ammo -= 1;
					Instantiate (laz4, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
				}
			}
			
			if (Gamestats.weaponType == 1) {
				if (Gamestats.ammo > 0) {
					Gamestats.ammo -= 1;
					Instantiate (laz2, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
				}
			}
		}
	
		if (Input.GetKeyDown (KeyCode.Space))
		{
			
			Instantiate (melee, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
	}
}




