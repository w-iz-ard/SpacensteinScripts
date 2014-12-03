
//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class Gamestats : MonoBehaviour {
	public static int floorType;
	public static int ceilingType;
	public static int wallType;
	public static int wallsSpawned;

	public static int maxHP;
	public static int currentHP;
	public static int nation;
	public static float maxSpeed;
	public static int turnSpeed;
	public static int weaponSpeed;
	public static int weaponTime;
	public static int weaponType;
	public static string weaponName;
	public static int weaponSTR;
	public static int ammo;
	public static int kills;
	public int deaths;
	public static int diamonds;
	public static int boss;
	public static int uSSRBossKilled;
	public static int uSBossKilled;
	public int bad;

	public static int enemies;

	public static float enemySpeed;
	public static int enemySTR;
	public static int enemyHP;
	public static int enemyWeapon;


	public static int dungeonFloor;


	public static int startWorldGen;
	public static int worldGenFinished;
	public static int succeed;

	public static int prop1;
	public static int prop2;

	public static int bipedArmType;
	public static int bipedLegType;
	public static int bipedBodyType;
	public static int bipedHeadType;


	public int walls;
	public int ct;
	public int wt;
	public int ft;
	// Use this for initialization
	void Start () {
		worldGenFinished = 0;
		boss = 0;
		uSSRBossKilled = PlayerPrefs.GetInt ("USSRBossKilled");
		uSBossKilled = PlayerPrefs.GetInt ("USBossKilled");
		if (uSSRBossKilled == 1 && uSBossKilled == 1) {
			Application.LoadLevel("FinalVictory");		
		}
		deaths = PlayerPrefs.GetInt ("Deaths");
		if (uSSRBossKilled ==0 && uSBossKilled ==0){
		nation = Random.Range (0, 2);
		if (nation == 0) {
			weaponType 	= Random.Range(0,2);
		}
		if (nation == 1) {
			weaponType 	= Random.Range(2,4);	
			}
		}
		
		if (uSSRBossKilled == 1 && uSBossKilled ==0){
			
				nation = 0;
					weaponType 	= Random.Range(0,2);
				}
		if (uSSRBossKilled == 0 && uSBossKilled ==1){
				
				nation = 1;
				weaponType 	= Random.Range(0,2);
			}

		switch (weaponType) {
		case 0:
			weaponName = "Freedom Blaster";
			ammo = 200;
			break;
		case 1:
			weaponName = "Democracy Fire";
			ammo = 300;
			break;
		case 2:
			weaponName = "Tsar Bomba";
			ammo = 200;
			break;
		case 3:
			weaponName = "Kalishnikov";
			ammo = 300;
			break;
		}
		StartCoroutine (Wait ());
		floorType = Random.Range (0, 12);
		ceilingType = Random.Range (0, 12);
		wallType = Random.Range (0, 12);
		prop1 = Random.Range (0, 7);
		prop2 = Random.Range (0, 7);

		bipedArmType = Random.Range (0, 7);
		bipedLegType = Random.Range (0, 7);
		bipedBodyType = Random.Range (0, 7);
		bipedHeadType = Random.Range (0, 7);

		kills = PlayerPrefs.GetInt (("Kills"));

		dungeonFloor = PlayerPrefs.GetInt("DungeonFloor");
		enemySpeed = PlayerPrefs.GetFloat("EnemySpeed");
		enemyHP = PlayerPrefs.GetInt("EnemyHP");
		enemySTR = PlayerPrefs.GetInt("EnemySTR");
		enemyWeapon = 1;



		if (nation == 0) {
		diamonds =	PlayerPrefs.GetInt (("USDiamonds"));
		maxHP =	PlayerPrefs.GetInt (("USMaxHP"));
		maxSpeed = PlayerPrefs.GetFloat (("USMaxSpeed"));
		turnSpeed = PlayerPrefs.GetInt (("USTurnSpeed"));
		weaponSpeed = PlayerPrefs.GetInt (("USWeaponSpeed"));
		weaponSTR =	PlayerPrefs.GetInt (("USWeaponSTR"));
		weaponTime = PlayerPrefs.GetInt (("USWeaponTime"));
		weaponSTR = PlayerPrefs.GetInt (("USWeaponSTR"));
		}
		if (nation == 1) {
		diamonds =	PlayerPrefs.GetInt (("USSRDiamonds"));
		maxHP =	PlayerPrefs.GetInt  (("USSRMaxHP"));
		maxSpeed = PlayerPrefs.GetFloat  (("USSRMaxSpeed"));
		turnSpeed =	PlayerPrefs.GetInt  (("USSRTurnSpeed"));
		weaponSpeed = PlayerPrefs.GetInt  (("USSRWeaponSpeed"));
		weaponSTR =	PlayerPrefs.GetInt  (("USSRWeaponSTR"));
		weaponTime = PlayerPrefs.GetInt  (("USSRWeaponTime"));
		weaponSTR =	PlayerPrefs.GetInt  (("USSRWeaponSTR"));
		}
		if (diamonds >= 10) {
			boss = 1;		
		}


		currentHP = maxHP;


	}



	// Update is called once per frame
	void Update () {
		if (currentHP >= maxHP +1) {
			currentHP = maxHP;		
		}

		if (ammo < 0) {
			ammo=0;
		}
		if (maxHP < 100){
			maxHP = 100;
		}
		if (turnSpeed < 100) {
			turnSpeed = 100;		
		}
		if (maxSpeed < 1) {
			maxSpeed = 1;		
		}
		

		
		if (weaponSTR < 1) {
			weaponSTR = 1;		
		}
		if (weaponSpeed < 5) {
			weaponSpeed = 5;		
		}
		if (weaponTime < 10) {
			weaponTime = 10;		
		}

		if (ammo > 999) {
			ammo=999;
		}
		if (maxHP > 999){
			maxHP = 999;
		}
		if (turnSpeed > 200) {
			turnSpeed = 200;		
		}
		if (maxSpeed > 500) {
			maxSpeed = 500;		
		}
		
		
		
		if (weaponSTR > 100) {
			weaponSTR = 100;		
		}
		if (weaponSpeed > 100) {
			weaponSpeed = 100;		
		}
		if (weaponTime > 100) {
			weaponTime = 100;		
		}

		
		if (enemyHP > 100) {
			enemyHP = 100;		
		}
		if (enemySpeed > 10) {
			enemySpeed = 10;		
		}
		if (enemySTR > 10) {
			enemySTR = 10;		
		}



		if (nation == 0) {
			PlayerPrefs.SetInt (("USMaxHP"), maxHP);
			PlayerPrefs.SetFloat (("USMaxSpeed"), maxSpeed);
			PlayerPrefs.SetInt (("USTurnSpeed"), turnSpeed);
			PlayerPrefs.SetInt (("USWeaponSpeed"), weaponSpeed);
			PlayerPrefs.SetInt (("USWeaponSTR"), weaponSTR);
			PlayerPrefs.SetInt (("USWeaponTime"), weaponTime);

		}
		if (nation == 1) {
			PlayerPrefs.SetInt (("USSRMaxHP"), maxHP);
			PlayerPrefs.SetFloat (("USSRMaxSpeed"), maxSpeed);
			PlayerPrefs.SetInt (("USSRTurnSpeed"), turnSpeed);
			PlayerPrefs.SetInt (("USSRWeaponSpeed"), weaponSpeed);
			PlayerPrefs.SetInt (("USSRWeaponSTR"), weaponSTR);
			PlayerPrefs.SetInt (("USSRWeaponTime"), weaponTime);

		}
		PlayerPrefs.SetInt (("EnemyHP"), enemyHP);
		PlayerPrefs.SetFloat (("EnemySpeed"), enemySpeed);
		PlayerPrefs.SetInt (("EnemySTR"), enemySTR);
		if (currentHP <= 0) {
			if (boss==1){
				diamonds -=1;
			}
			Gamestats.maxSpeed -= 0.1f;
			Gamestats.maxHP -= 1;
			Gamestats.turnSpeed -= 1;
			Gamestats.weaponSpeed -= 1;
			Gamestats.weaponTime -= 1;
			Gamestats.weaponSTR -=1;
			
			if (nation == 0) {
				PlayerPrefs.SetInt (("USMaxHP"), maxHP);
				PlayerPrefs.SetFloat (("USMaxSpeed"), maxSpeed);
				PlayerPrefs.SetInt (("USTurnSpeed"), turnSpeed);
				PlayerPrefs.SetInt (("USWeaponSpeed"), weaponSpeed);
				PlayerPrefs.SetInt (("USWeaponSTR"), weaponSTR);
				PlayerPrefs.SetInt (("USWeaponTime"), weaponTime);
				PlayerPrefs.SetInt (("USWeaponSTR"), weaponSTR);
				PlayerPrefs.SetInt (("USDiamonds"), diamonds);
			}
			if (nation == 1) {
				PlayerPrefs.SetInt (("USSRMaxHP"), maxHP);
				PlayerPrefs.SetFloat (("USSRMaxSpeed"), maxSpeed);
				PlayerPrefs.SetInt (("USSRTurnSpeed"), turnSpeed);
				PlayerPrefs.SetInt (("USSRWeaponSpeed"), weaponSpeed);
				PlayerPrefs.SetInt (("USSRWeaponSTR"), weaponSTR);
				PlayerPrefs.SetInt (("USSRWeaponTime"), weaponTime);
				PlayerPrefs.SetInt (("USSRDiamonds"), diamonds);

			}

			wallsSpawned = 0;
			enemies = 0;
			worldGenFinished =0;
			startWorldGen = 0;
			deaths +=1; 
			PlayerPrefs.SetInt (("Deaths"), deaths);
			Application.LoadLevel("Died");		
		}
		if (succeed == 1) {
			Gamestats.maxSpeed += 0.2f;
			Gamestats.maxHP += 10;
			Gamestats.turnSpeed += 2;
			Gamestats.weaponSpeed += 2;
			Gamestats.weaponTime += 2;
			Gamestats.weaponSTR +=2;

			bad = Random.Range(0,3);
			switch (bad) {
			case 0:
				Gamestats.enemyHP +=5;

				break;
			case 1:
				Gamestats.enemySpeed +=0.1f;

				break;
			case 2:
				Gamestats.enemySTR +=1;

				break;
			}
			PlayerPrefs.SetInt (("EnemyHP"), enemyHP);
			PlayerPrefs.SetFloat (("EnemySpeed"), enemySTR);
			PlayerPrefs.SetInt (("EnemySTR"), enemySTR);
	
			diamonds +=1;
			if (nation == 0) {
				PlayerPrefs.SetInt (("USMaxHP"), maxHP);
				PlayerPrefs.SetFloat (("USMaxSpeed"), maxSpeed);
				PlayerPrefs.SetInt (("USTurnSpeed"), turnSpeed);
				PlayerPrefs.SetInt (("USWeaponSpeed"), weaponSpeed);
				PlayerPrefs.SetInt (("USWeaponSTR"), weaponSTR);
				PlayerPrefs.SetInt (("USWeaponTime"), weaponTime);


				PlayerPrefs.SetInt (("USDiamonds"), diamonds);
			}
			if (nation == 1) {
				PlayerPrefs.SetInt (("USSRMaxHP"), maxHP);
				PlayerPrefs.SetFloat (("USSRMaxSpeed"), maxSpeed);
				PlayerPrefs.SetInt (("USSRTurnSpeed"), turnSpeed);
				PlayerPrefs.SetInt (("USSRWeaponSpeed"), weaponSpeed);
				PlayerPrefs.SetInt (("USSRWeaponSTR"), weaponSTR);
				PlayerPrefs.SetInt (("USSRWeaponTime"), weaponTime);
				PlayerPrefs.SetInt (("USSRDiamonds"), diamonds);

			}
			PlayerPrefs.SetInt (("Kills"), kills);
			wallsSpawned = 0;
			enemies = 0;
			worldGenFinished =0;
			startWorldGen = 0;
			dungeonFloor +=1;
			PlayerPrefs.SetInt (("DungeonFloor"), dungeonFloor);
			succeed = 0;
			if (nation == 0 && uSBossKilled ==0){
			Application.LoadLevel("Victory");	
			}
			if (nation == 1 && uSSRBossKilled ==0){
				Application.LoadLevel("Victory");	
			}
			if (( nation == 0 && uSBossKilled == 1) | (nation == 1 && uSSRBossKilled ==1)){
				StartCoroutine (Wait2());
			}
		}

	}



IEnumerator Wait(){
	
	
	yield return new WaitForSeconds(1f);
		startWorldGen = 1;
	
}
				IEnumerator Wait2(){
					
					
					yield return new WaitForSeconds(2f);
					if (nation == 0 && uSBossKilled ==1){
						PlayerPrefs.SetInt (("USBossKilled"), uSBossKilled);
						Application.LoadLevel("USVictory");	
					}
					if (nation == 1 && uSSRBossKilled ==1){
						PlayerPrefs.SetInt (("USSRBossKilled"), uSSRBossKilled);
						Application.LoadLevel("USSRVictory");	
					}

					
				}
			

}