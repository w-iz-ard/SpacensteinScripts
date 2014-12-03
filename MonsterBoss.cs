
//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class MonsterBoss : MonoBehaviour {
	
	public GameObject monsterStats;


	public int headType;
	public int gen;
	public int init;
	public int hitPoints;
	public float maxSpeed;
	public int drop;

	public GameObject laz1;
	public int fire1;

	public GameObject powerUp;

	public GameObject body;
	public GameObject head;
	public GameObject leftArm;
	public GameObject rightArm;
	public GameObject leftLeg;
	public GameObject rightLeg;
	
	

	
	public Sprite headSprite01; 
	public Sprite headSprite02; 

	

	private SpriteRenderer headSpriteRenderer; 

	
	void Start ()
	{
		init = 0;
		fire1 = 0;
		hitPoints = 300;


		body = transform.FindChild("Body").gameObject;
		head = transform.FindChild("Head").gameObject;
		leftArm = transform.FindChild("LeftArm").gameObject;
		rightArm = transform.FindChild("RightArm").gameObject;
		leftLeg = transform.FindChild("LeftLeg").gameObject;
		rightLeg = transform.FindChild("RightLeg").gameObject;
		
		
		
	
		headSpriteRenderer = head.GetComponent<SpriteRenderer>();
		
		
		
		
		// we are accessing the SpriteRenderer that is attached to the Gameobject
		
	}
	
	void Update ()
		
	{

		maxSpeed = 20;

	
		if (Gamestats.worldGenFinished == 1) {
						rigidbody.AddRelativeForce (0, 0, 10);
						if (Mathf.Abs (rigidbody.velocity.z) > maxSpeed) {
								rigidbody.velocity = new Vector3 (rigidbody.velocity.x, rigidbody.velocity.y, Mathf.Sign (rigidbody.velocity.z) * maxSpeed);
						}
						if (Mathf.Abs (rigidbody.velocity.x) > maxSpeed) {
								rigidbody.velocity = new Vector3 (Mathf.Sign (rigidbody.velocity.x) * maxSpeed, rigidbody.velocity.y, rigidbody.velocity.z);
						}
				
			if (Gamestats.enemyWeapon ==1 && fire1 ==0){
				fire1 = 1;
				StartCoroutine(Weapon1());

			}
		}
		if (init == 0) 
		{
			
			ChangeSprites (); // call method to change sprite
			init =1; 

		
			
		}

		if (hitPoints <=0){
			Gamestats.kills +=1;
			if (Gamestats.nation == 0){
				Gamestats.uSBossKilled =1;
				Gamestats.succeed =1;
			}
			if (Gamestats.nation == 1){
				Gamestats.uSSRBossKilled =1;
				Gamestats.succeed =1;
			}
			drop = Random.Range(0,2);
			if(drop==0){
				Instantiate (powerUp, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);}
			foreach(Transform child in transform)
			{
				
				(child.gameObject).AddComponent<BoxCollider>().size = new Vector3 (child.gameObject.transform.lossyScale.x, child.gameObject.transform.lossyScale.y, 0.1f);
				(child.gameObject).AddComponent<Rigidbody>().mass = 0.1f; 
			}

			Destroy(gameObject.GetComponent<BoxCollider>());
		Destroy(gameObject.GetComponent<PolygonCollider2D>());
		
		gameObject.AddComponent<Rigidbody>();
		transform.DetachChildren();
		rightArm.transform.DetachChildren();
		leftArm.transform.DetachChildren();
		rightLeg.transform.DetachChildren();
		leftLeg.transform.DetachChildren();
		
	
		body.AddComponent<Rigidbody>();
		leftLeg.AddComponent<Rigidbody>();
		rightLeg.AddComponent<Rigidbody>();
		head.AddComponent<Rigidbody>();
		leftArm.AddComponent<Rigidbody>();
		rightArm.AddComponent<Rigidbody>();
	
	
		
		leftLeg.AddComponent<HingeJoint>();
		leftLeg.GetComponent<HingeJoint>().connectedBody = body.rigidbody;
		leftLeg.GetComponent<HingeJoint>().connectedAnchor = new Vector3 (-0.25f,0f, 0f);
		
		
		
		rightLeg.AddComponent<HingeJoint>();
		rightLeg.GetComponent<HingeJoint>().connectedBody = body.rigidbody;
			rightLeg.GetComponent<HingeJoint>().connectedAnchor = new Vector3 (0.25f,0f, 0f);
		
		
		
		head.AddComponent<HingeJoint>();
			head.GetComponent<HingeJoint>().connectedBody = body.rigidbody;
			head.GetComponent<HingeJoint>().connectedAnchor = new Vector3 (0f,1.25f, 0f);
		leftArm.AddComponent<HingeJoint>();
			leftArm.GetComponent<HingeJoint>().connectedBody = body.rigidbody;
			leftArm.GetComponent<HingeJoint>().connectedAnchor = new Vector3 (-0.5f,1f, 0f);
		
		rightArm.AddComponent<HingeJoint>();
			rightArm.GetComponent<HingeJoint>().connectedBody = body.rigidbody;
			rightArm.GetComponent<HingeJoint>().connectedAnchor = new Vector3 (0.5f,1f, 0f);
			Gamestats.enemies -=1;
			Destroy(gameObject);
		}


	}
	
	void ChangeSprites ()
	{
	
		headType = Gamestats.nation;

		switch (headType) {
		case 0:
			headSpriteRenderer.sprite = headSprite01;
			break;	
		case 1:
			headSpriteRenderer.sprite = headSprite02;
			break;

		}

		}
		
		
		
		
		// otherwise change it back to sprite1
		

	IEnumerator Weapon1(){

			yield return new WaitForSeconds(1f);
			Instantiate (laz1, new Vector3 (transform.position.x, transform.position.y+0.5f, transform.position.z), Quaternion.identity);
			fire1 = 0;
		}
	void OnCollisionEnter(Collision col)
	{
		
		if (col.gameObject.tag == "Player") {
			Gamestats.currentHP -= 10;
			Debug.Log ("hit");
		}
		if (col.gameObject.tag == "Lazer") {
			hitPoints -= Gamestats.weaponSTR;
			Debug.Log ("hit");
		}
	}
}
