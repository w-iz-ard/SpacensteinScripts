
//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
	
	public GameObject monsterStats;

	
	public int bodyType;
	public int armType;
	public int legType;
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
	
	
	public Sprite bodySprite01; 
	public Sprite bodySprite02; 
	public Sprite bodySprite03;
	public Sprite bodySprite04; 
	public Sprite bodySprite05; 
	public Sprite bodySprite06;
	
	
	public Sprite headSprite01; 
	public Sprite headSprite02; 
	public Sprite headSprite03;
	public Sprite headSprite04; 
	public Sprite headSprite05; 
	public Sprite headSprite06;
	
	
	public Sprite armSprite01; 
	public Sprite armSprite02; 
	public Sprite armSprite03;
	public Sprite armSprite04; 
	public Sprite armSprite05; 
	public Sprite armSprite06;
	
	
	public Sprite legSprite01; 
	public Sprite legSprite02; 
	public Sprite legSprite03;
	public Sprite legSprite04; 
	public Sprite legSprite05; 
	public Sprite legSprite06;
	
	
	private SpriteRenderer bodySpriteRenderer; 
	private SpriteRenderer headSpriteRenderer; 
	private SpriteRenderer armLeftSpriteRenderer;
	private SpriteRenderer armRightSpriteRenderer;
	private SpriteRenderer legLeftSpriteRenderer; 
	private SpriteRenderer legRightSpriteRenderer; 
	
	void Start ()
	{
		init = 0;
		fire1 = 0;
		hitPoints = Gamestats.enemyHP;


		body = transform.FindChild("Body").gameObject;
		head = transform.FindChild("Head").gameObject;
		leftArm = transform.FindChild("LeftArm").gameObject;
		rightArm = transform.FindChild("RightArm").gameObject;
		leftLeg = transform.FindChild("LeftLeg").gameObject;
		rightLeg = transform.FindChild("RightLeg").gameObject;
		
		
		
		bodySpriteRenderer = body.GetComponent<SpriteRenderer>();
		legLeftSpriteRenderer = leftLeg.GetComponent<SpriteRenderer>();
		legRightSpriteRenderer = rightLeg.GetComponent<SpriteRenderer>();
		armLeftSpriteRenderer = leftArm.GetComponent<SpriteRenderer>();
		armRightSpriteRenderer = rightArm.GetComponent<SpriteRenderer>();
		headSpriteRenderer = head.GetComponent<SpriteRenderer>();
		
		
		
		
		// we are accessing the SpriteRenderer that is attached to the Gameobject
		
	}
	
	void Update ()
		
	{

		maxSpeed = Gamestats.enemySpeed;

		legType = Gamestats.bipedLegType;
		armType = Gamestats.bipedArmType;
		headType = Gamestats.bipedHeadType;
		bodyType = Gamestats.bipedBodyType;
		if (Gamestats.worldGenFinished == 1) {
						rigidbody.AddRelativeForce (0, 0, 3);
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
		switch (bodyType) {
		case 1:
			bodySpriteRenderer.sprite = bodySprite01;
			break;	
		case 2:
			bodySpriteRenderer.sprite = bodySprite02;
			break;
		case 3:
			bodySpriteRenderer.sprite = bodySprite03;
			break;
		case 4:
			bodySpriteRenderer.sprite = bodySprite04;
			break;	
		case 5:
			bodySpriteRenderer.sprite = bodySprite05;
			break;
		case 6:
			bodySpriteRenderer.sprite = bodySprite06;
			break;
		}
		switch (headType) {
		case 1:
			headSpriteRenderer.sprite = headSprite01;
			break;	
		case 2:
			headSpriteRenderer.sprite = headSprite02;
			break;
		case 3:
			headSpriteRenderer.sprite = headSprite03;
			break;
		case 4:
			headSpriteRenderer.sprite = headSprite04;
			break;	
		case 5:
			headSpriteRenderer.sprite = headSprite05;
			break;
		case 6:
			headSpriteRenderer.sprite = headSprite06;
			break;
		}
		switch (armType) {
		case 1:
			armRightSpriteRenderer.sprite = armSprite01;
			armLeftSpriteRenderer.sprite = armSprite01;
			break;	
		case 2:
			armRightSpriteRenderer.sprite = armSprite02;
			armLeftSpriteRenderer.sprite = armSprite02;
			break;
		case 3:
			armRightSpriteRenderer.sprite = armSprite03;
			armLeftSpriteRenderer.sprite = armSprite03;
			break;
		case 4:
			armRightSpriteRenderer.sprite = armSprite04;
			armLeftSpriteRenderer.sprite = armSprite04;
			break;	
		case 5:
			armRightSpriteRenderer.sprite = armSprite05;
			armLeftSpriteRenderer.sprite = armSprite05;
			break;
		case 6:
			armRightSpriteRenderer.sprite = armSprite06;
			armLeftSpriteRenderer.sprite = armSprite06;
			break;
		}
		switch (legType) {
		case 1:
			legRightSpriteRenderer.sprite = legSprite01;
			legLeftSpriteRenderer.sprite = legSprite01;
			break;	
		case 2:
			legRightSpriteRenderer.sprite = legSprite02;
			legLeftSpriteRenderer.sprite = legSprite02;
			break;
		case 3:
			legRightSpriteRenderer.sprite = legSprite03;
			legLeftSpriteRenderer.sprite = legSprite03;
			break;
		case 4:
			legRightSpriteRenderer.sprite = legSprite04;
			legLeftSpriteRenderer.sprite = legSprite04;
			break;	
		case 5:
			legRightSpriteRenderer.sprite = legSprite05;
			legLeftSpriteRenderer.sprite = legSprite05;
			break;
		case 6:
			legRightSpriteRenderer.sprite = legSprite06;
			legLeftSpriteRenderer.sprite = legSprite06;
			break;
		}
		
		
		
		
		// otherwise change it back to sprite1
		
	}
	IEnumerator Weapon1(){

			yield return new WaitForSeconds(2.5f);
			Instantiate (laz1, new Vector3 (transform.position.x, transform.position.y+0.5f, transform.position.z), Quaternion.identity);
			fire1 = 0;
		}
	void OnCollisionEnter(Collision col)
	{
		
		if (col.gameObject.tag == "Player") {
			Gamestats.currentHP -= Gamestats.enemySTR;
			Debug.Log ("hit");
		}
	}
}
