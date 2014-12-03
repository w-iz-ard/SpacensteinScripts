//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Carver : MonoBehaviour {
	public int toCarve;
	public int dir;
	public int changeDir;
	public int randomProp;
	public int randomLamp;
	public int randomDrop;
	public GameObject prop;
	public GameObject powerUp;
	public GameObject lampR;
	public GameObject lampB;
	public GameObject lampG;
	public GameObject monster;
	public GameObject boss;

	public int rSpawned;
	public int bSpawned;
	public int gSpawned;
	// Use this for initialization
	void Start () {
		toCarve = 600;
		changeDir = 0;
		rSpawned = 0;
		gSpawned = 0;
		bSpawned = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (Gamestats.wallsSpawned > 2500) {
						if (toCarve > -1) {
								if (changeDir == 0) {
										changeDir = 1;
										StartCoroutine (Wait ());
								}
								switch (dir) {
								case 0:
										transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 2);
										break;
								case 1:
										transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 2);
										break;
								case 2:
										transform.position = new Vector3 (transform.position.x + 2, transform.position.y, transform.position.z);
										break;
								case 3:
										transform.position = new Vector3 (transform.position.x - 2, transform.position.y, transform.position.z);
										break;
								case 4:
										transform.position = new Vector3 (transform.position.x + 1, transform.position.y, transform.position.z + 1);
										break;
								case 5:
										transform.position = new Vector3 (transform.position.x - 1, transform.position.y, transform.position.z - 1);
										break;
								case 6:
										transform.position = new Vector3 (transform.position.x + 1, transform.position.y, transform.position.z - 1);
										break;
								case 7:
										transform.position = new Vector3 (transform.position.x - 1, transform.position.y, transform.position.z + 1);
										break;


								}

								if (transform.position.x > 100f) {
										transform.position = new Vector3 (100, transform.position.y, transform.position.z);
								}
								if (transform.position.x < 0f) {
										transform.position = new Vector3 (0, transform.position.y, transform.position.z);
								}
								if (transform.position.z < 0f) {
										transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
								}
								if (transform.position.z > 100f) {
										transform.position = new Vector3 (transform.position.x, transform.position.y, 100);
								}
				randomProp = Random.Range (0, 30);
				randomDrop = Random.Range (0,100);
				if (randomProp >= 1 && randomProp <= 3) {
					Instantiate (prop, new Vector3 (transform.position.x, 2, transform.position.z), Quaternion.identity);
				}
				if (randomProp >=5 && randomProp <= 6 ) {
					Instantiate (monster, new Vector3 (transform.position.x, 2, transform.position.z), Quaternion.identity);
					Gamestats.enemies +=1;
				}
				
				if (randomDrop == 0) {
					Instantiate (powerUp, new Vector3 (transform.position.x, 2, transform.position.z), Quaternion.identity);
					Gamestats.enemies +=1;
				}	

				
			}
			
			if (toCarve <= -1) {
				if (Gamestats.boss ==0){
			randomLamp = Random.Range (0, 3);
				
				
				if (randomLamp == 0 && bSpawned == 0) {
										Instantiate (lampB, new Vector3 (transform.position.x, 2, transform.position.z), Quaternion.identity);
										bSpawned = 1;
										rSpawned = 1;
										gSpawned = 1;
								}
				if (randomLamp == 1 && rSpawned == 0) {
										Instantiate (lampR, new Vector3 (transform.position.x, 2, transform.position.z), Quaternion.identity);
										bSpawned = 1;
										rSpawned = 1;
										gSpawned = 1;
								}
				if (randomLamp == 2 && gSpawned == 0) {
										Instantiate (lampG, new Vector3 (transform.position.x, 2, transform.position.z), Quaternion.identity);
										bSpawned = 1;
										rSpawned = 1;
										gSpawned = 1;
								}
						}
				if (Gamestats.boss ==1){

					

						Instantiate (boss, new Vector3 (transform.position.x, 2, transform.position.z), Quaternion.identity);
						bSpawned = 1;
						rSpawned = 1;
						gSpawned = 1;
				
				}
						if (bSpawned == 1 && rSpawned == 1 && gSpawned == 1) {
				Gamestats.worldGenFinished =1;
				transform.position = new Vector3(51,2,51);
								Destroy (gameObject);		
						}
			}
		}
	

	}
	void OnCollisionEnter(Collision col)
	{
				if (col.gameObject.tag == "Wall") {
			Destroy (col.gameObject);
			toCarve -= 1;
			Debug.Log("carve");
				}
		
				
		}
	IEnumerator Wait(){
		
		
		yield return new WaitForSeconds(0.1f);
		dir = Random.Range(0,7);
		changeDir = 0;
		
	}
}
