using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingAudio : MonoBehaviour {

	public AudioClip aClips;
	public AudioSource myAudioSource;
	public GameObject o1,o2,o3,o4,o5,o6;

	string btnName;
	// Use this for initialization
	void Start () {
		myAudioSource = GetComponent<AudioSource>();
		o1 = GameObject.Find("itcomplex");
		o2 = GameObject.Find("mba");
		o3 = GameObject.Find("principal");
		o4 = GameObject.Find("mca");
		o5 = GameObject.Find("civil");
		o6 = GameObject.Find("firstYear");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){

			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit Hit;
			if (Physics.Raycast(ray,out Hit)){

				btnName = Hit.transform.name;

				switch (btnName){
					case "itcomplex":
						myAudioSource.clip = aClips;
						myAudioSource.Play();
						o2.SetActive(false);
						o3.SetActive(false);
						o4.SetActive(false);

						break;

					case "mba":
						myAudioSource.clip = aClips;
						myAudioSource.Play();
						// o1.SetActive(true);
						// o2.SetActive(false);
						// o1.SetActive(false);
						o5.SetActive(false);
						o6.SetActive(false);
						o4.SetActive(false);
						break;

					case "principal":
						myAudioSource.clip = aClips;
						myAudioSource.Play();
						// o1.SetActive(true);
						// o2.SetActive(false);
						// o1.SetActive(false);
						break;

					case "mca":
						myAudioSource.clip = aClips;
						myAudioSource.Play();
						// o1.SetActive(true);
						// o2.SetActive(false);
						// o1.SetActive(false);
						break;
					case "civil":
						myAudioSource.clip = aClips;
						myAudioSource.Play();
						// o1.SetActive(true);
						// o2.SetActive(false);
						// o1.SetActive(false);
						break;
					case "firstYear":
						myAudioSource.clip = aClips;
						myAudioSource.Play();
						break;

				}
			}
		}
	}
}
