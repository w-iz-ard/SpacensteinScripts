using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	public AudioClip s01;
	public AudioClip s02;
	public AudioClip s03;
	public AudioClip s04;
	public AudioClip s05;
	public AudioClip s06;
	public AudioClip s07;
	public AudioClip s08;
	public AudioClip s09;
	public AudioClip s10;
	public AudioClip s11;
	public AudioClip s12;
	public AudioClip s13;

	
	public int sound;
	
	
	
	// Use this for initialization
	void Start () {
		sound = Random.Range (0, 20);
		audio.volume = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (!audio.isPlaying){
			sound =Random.Range(0,20);
			StartCoroutine(Audio());
			
		}
		if (audio.isPlaying) {
			sound = -3;		
		}
		
	}
	
	public	IEnumerator Audio(){
		if (!audio.isPlaying){
			switch(sound){
			case 0:
				audio.clip = s01;
				audio.Play();
				break;
			case 1:
				audio.clip = s02;
				audio.Play();
				break;
			case 2:
				audio.clip = s03;
				audio.Play();
				break;
			case 3:
				audio.clip = s04;
				audio.Play();
				break;
			case 4:
				audio.clip = s05;
				audio.Play();
				break;
			case 5:
				audio.clip = s06;
				audio.Play();
				break;
			case 6:
				audio.clip = s07;
				audio.Play();
				break;
			case 7:
				audio.clip = s08;
				audio.Play();
				break;
			case 8:
				audio.clip = s09;
				audio.Play();
				break;
			case 9:
				audio.clip = s10;
				audio.Play();
				break;
			case 10:
				audio.clip = s11;
				audio.Play();
				break;
			case 11:
				audio.clip = s12;
				audio.Play();
				break;
			case 12:
				audio.clip = s13;
				audio.Play();
				break;
	
			}
			yield return new WaitForSeconds (0f);
		}
		
	}
}
