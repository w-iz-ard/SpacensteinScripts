//All code for Spacenstein is (c) 2014 W_iz_ard
using UnityEngine;
using System.Collections;

public class WallTexture : MonoBehaviour {
	
	private int currType;
	private int currTex;
	private int decal;
	
	
	public Texture m1a;
	public Texture m1b;
	public Texture m1c;
	public Texture m2a;
	public Texture m2b;
	public Texture m2c;
	public Texture m3a;
	public Texture m3b;
	public Texture m3c;
	public Texture m4a;
	public Texture m4b;
	public Texture m4c;
	public Texture m5a;
	public Texture m5b;
	public Texture m5c;
	public Texture m6a;
	public Texture m6b;
	public Texture m6c;
	public Texture m7a;
	public Texture m7b;
	public Texture m7c;
	public Texture m8a;
	public Texture m8b;
	public Texture m8c;
	public Texture m9a;
	public Texture m9b;
	public Texture m9c;
	public Texture m10a;
	public Texture m10b;
	public Texture m10c;
	public Texture m11a;
	public Texture m11b;
	public Texture m11c;
	public Texture m12a;
	public Texture m12b;
	public Texture m12c;

	public Texture d1;
	public Texture d2;
	public Texture d3;
	public Texture d4;
	public Texture d5;
	public Texture d6;
	public Texture d7;
	public Texture d8;
	public Texture d9;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		// Update is called once per frame
		if (Gamestats.startWorldGen == 1) {
			if (Gamestats.startWorldGen == 1) {
				currType = Gamestats.wallType;
				currTex = Random.Range (0, 3);
				decal = Random.Range(0,30);
				if (currType == 0) {
					
					switch (currTex) {
						
					case 0:
						renderer.material.SetTexture ("_MainTex", m1a);
						
						break;
					case 1:
						renderer.material.SetTexture ("_MainTex", m1b);
						
						break;
					case 2:
						renderer.material.SetTexture ("_MainTex", m1c);
						
						break;
					}
				}
				
				if (currType == 1) {
					
					switch (currTex) {
						
					case 0:
						renderer.material.SetTexture ("_MainTex", m2a);
						
						break;
					case 1:
						renderer.material.SetTexture ("_MainTex", m2b);
						
						break;
					case 2:
						renderer.material.SetTexture ("_MainTex", m2c);
						
						break;
					}
				}
				if (currType == 2) {
					
					switch (currTex) {
						
					case 0:
						renderer.material.SetTexture ("_MainTex", m3a);
						
						break;
					case 1:
						renderer.material.SetTexture ("_MainTex", m3b);
						
						break;
					case 2:
						renderer.material.SetTexture ("_MainTex", m3c);
						
						break;
					}
				}
				if (currType == 3) {
					
					switch (currTex) {
						
					case 0:
						renderer.material.SetTexture ("_MainTex", m4a);
						
						break;
					case 1:
						renderer.material.SetTexture ("_MainTex", m4b);
						
						break;
					case 2:
						renderer.material.SetTexture ("_MainTex", m4c);
						
						break;
					}
				}
				if (currType == 4) {
					
					switch (currTex) {
						
					case 0:
						renderer.material.SetTexture ("_MainTex", m5a);
						
						break;
					case 1:
						renderer.material.SetTexture ("_MainTex", m5b);
						
						break;
					case 2:
						renderer.material.SetTexture ("_MainTex", m5c);
						
						break;
					}
				}
				if (currType == 5) {
					
					switch (currTex) {
						
					case 0:
						renderer.material.SetTexture ("_MainTex", m6a);
						
						break;
					case 1:
						renderer.material.SetTexture ("_MainTex", m6b);
						
						break;
					case 2:
						renderer.material.SetTexture ("_MainTex", m6c);
						
						break;
					}
				}
				if (currType == 6) {
					
					switch (currTex) {
						
					case 0:
						renderer.material.SetTexture ("_MainTex", m7a);
						
						break;
					case 1:
						renderer.material.SetTexture ("_MainTex", m7b);
						
						break;
					case 2:
						renderer.material.SetTexture ("_MainTex", m7c);
						
						break;
					}
				}
				if (currType == 7) {
					
					switch (currTex) {
						
					case 0:
						renderer.material.SetTexture ("_MainTex", m8a);
						
						break;
					case 1:
						renderer.material.SetTexture ("_MainTex", m8b);
						
						break;
					case 2:
						renderer.material.SetTexture ("_MainTex", m8c);
						
						
						break;
					}
				}
					if (currType == 8) {
						
						switch (currTex) {
							
						case 0:
							renderer.material.SetTexture ("_MainTex", m9a);
							
							break;
						case 1:
							renderer.material.SetTexture ("_MainTex", m9b);
							
							break;
						case 2:
							renderer.material.SetTexture ("_MainTex", m9c);
							
							break;
						}
					}
					if (currType == 9) {
						
						switch (currTex) {
							
						case 0:
							renderer.material.SetTexture ("_MainTex", m10a);
							
							break;
						case 1:
							renderer.material.SetTexture ("_MainTex", m10b);
							
							break;
						case 2:
							renderer.material.SetTexture ("_MainTex", m10c);
							
							break;
						}
					}
					if (currType == 10) {
						
						switch (currTex) {
							
						case 0:
							renderer.material.SetTexture ("_MainTex", m11a);
							
							break;
						case 1:
							renderer.material.SetTexture ("_MainTex", m11b);
							
							break;
						case 2:
							renderer.material.SetTexture ("_MainTex", m11c);
							
							break;
						}
					}
					if (currType == 11) {
						
						switch (currTex) {
							
						case 0:
							renderer.material.SetTexture ("_MainTex", m12a);
							
							break;
						case 1:
							renderer.material.SetTexture ("_MainTex", m12b);
							
							break;
						case 2:
							renderer.material.SetTexture ("_MainTex", m12c);
							
							break;
						}
					}

				switch(decal){
					case 0:
					renderer.material.SetTexture ("_DecalTex", d1);
					break;
					case 1:
					renderer.material.SetTexture ("_DecalTex", d2);
					break;
					case 2:
					renderer.material.SetTexture ("_DecalTex", d3);
					break;
					case 3:
					renderer.material.SetTexture ("_DecalTex", d4);
					break;
					case 4:
					renderer.material.SetTexture ("_DecalTex", d5);
					break;
					case 5:
					renderer.material.SetTexture ("_DecalTex", d6);
					break;
					case 6:
					renderer.material.SetTexture ("_DecalTex", d7);
					break;
					case 7:
					renderer.material.SetTexture ("_DecalTex", d8);
					break;
					case 8:
					renderer.material.SetTexture ("_DecalTex", d9);
					break;
				}
				}
			Destroy(this);
		}
	}
}
