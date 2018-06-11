using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indoortouch : MonoBehaviour {

	
	public GameObject o1,o2,o3,o4;
	public GameObject[] arr;

	string btnName;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 23; i ++){
			arr[i] = GameObject.Find("a ("+(i+1).ToString()+")");
			arr[i].SetActive(true);
		}
 
		o1 = GameObject.Find("Lab2");
		o2 = GameObject.Find("Box001");
		o3 = GameObject.Find("staff1");
		o4 = GameObject.Find("Cube11");

	}
	// activate a1 to a11 for staff roomm
	// activate a12 to a15
	// activate a16 to a23
	
	// Update is called once per frame 
	void Update () {
		if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit Hit;
			if (Physics.Raycast(ray,out Hit)){

				btnName = Hit.transform.name;

				switch (btnName){ 
					case "Lab2":
						for (int i = 0; i < 11; i ++){
								arr[i].SetActive(true);
							}
						break;

					case "Cube11":
						for (int i = 0; i < 23; i ++){
								arr[i].SetActive(false);
							}
						break;

					case "Box001":
						for (int i = 11; i < 15; i ++)
							{
								arr[i].SetActive(true);
							}
					break;

					case "staff1":
						for (int i = 11; i < 23; i ++)
							{
								if (i != 14)
								 arr[i].SetActive(true);
							}
					break;


				}
			}
		}
	}
}
