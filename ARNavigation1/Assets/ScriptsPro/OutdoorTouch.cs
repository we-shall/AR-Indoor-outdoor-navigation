using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutdoorTouch : MonoBehaviour {

	public GameObject o1,o2,o3,o4,o5,o6,o7;
	public GameObject[] arr;

	string btnName;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 81; i ++){
			arr[i] = GameObject.Find("arrow1 ("+(i+1).ToString()+")");
			arr[i].SetActive(false);
		}
 
		o1 = GameObject.Find("MBA");
		o2 = GameObject.Find("principal");
		o3 = GameObject.Find("Civil");
		o4 = GameObject.Find("iT complex");
		o5 = GameObject.Find("BHostel1");
		o6 = GameObject.Find("first year1");
		o7 = GameObject.Find("reset");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit Hit;
			if (Physics.Raycast(ray,out Hit)){

				btnName = Hit.transform.name;

				switch (btnName){ 
					case "MBA":
						for (int i = 0; i < 24; i ++){
								arr[i].SetActive(true);
							}
						break;

					case "reset":
						for (int i = 0; i < 82; i ++){
								arr[i].SetActive(false);
							}
						break;
					case "principal":
						for (int i = 0; i < 20; i ++)
							{
								arr[i].SetActive(true);
							}
						for (int i = 24; i <= 29; i ++)
								arr[i].SetActive(true);
					break;

					case "Civil":
						for (int i = 0; i < 20; i ++)
							{
								arr[i].SetActive(true);
							}
						for (int i = 30; i < 51; i ++)
								arr[i].SetActive(true);
						for (int i = 78; i < 81; i ++ )
								arr[i].SetActive(true);
					break;

					case "iT complex":
					for (int i = 0; i < 20; i ++)
							{
								arr[i].SetActive(true);
							}
						for (int i = 30; i < 78; i ++)
								arr[i].SetActive(true);
					break;


				}
			}
		}
	}
}
