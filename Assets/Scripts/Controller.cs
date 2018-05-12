using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	public static int counter = 0;
	GameObject startFort;
	public static GameObject desFort;
	public GameObject gabby;
	public GameObject clone;
	public GameObject badgabby;
	public GameObject flyGabby;
	public string stored_tag;
	public static int number;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Click ();
	}


	void Click ()
	{
		
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				
				if (hit.collider.tag != "you" && hit.collider.tag != "me" && hit.collider.tag != "him" ) {
					counter = 0;
//					Debug.Log ("not here");
				} 
				//if (counter == 1){
				//	Debug.Log ("now " + stored_tag);
				//	stored_tag = hit.collider.tag;
				//}
				else if (counter == 0 && hit.collider.tag == "him"){
					counter = 0;
				}

				else{
					//stored_tag = hit.collider.tag;
//					Debug.Log("here");
					counter += 1;

					if (counter == 1) {
						startFort = hit.collider.gameObject;
						stored_tag = hit.collider.tag;
						FortController fort = hit.collider.gameObject.GetComponent<FortController> ();
						Debug.Log (fort.numberOfSoldiers);
					}
					if (counter >= 2 && hit.collider.gameObject != startFort) {
						FortController fort = startFort.GetComponent<FortController> ();
						if (fort.Flyable) {
							//Debug.Log ("hello");
							desFort = hit.collider.gameObject;
							Vector3 direction = (desFort.transform.position - fort.transform.position).normalized;
							clone = Instantiate (flyGabby, fort.spawnpoint1.transform.position, Quaternion.identity);
							clone.SetActive (true);
							number = fort.numberOfSoldiers / 3;
							fort.numberOfSoldiers -= number;
							counter = 0;

						} else {
							desFort = hit.collider.gameObject;
							spawn (startFort, desFort);
							number = fort.numberOfSoldiers / 3;
							fort.numberOfSoldiers -= number;
							counter = 0;
						}
					}
				}
			}
		}
	}

	void spawn(GameObject from,  GameObject to){
		FortController start = from.GetComponent<FortController> ();
		FortController end = to.GetComponent<FortController> ();


		if (end.reportDes () == start.spawnpoint1.name) {
			if (stored_tag == "me") {
				clone = Instantiate (gabby, start.spawnpoint1.transform.position, start.spawnpoint1.transform.rotation);
				clone.SetActive (true);
			} else {
				clone = Instantiate (badgabby, start.spawnpoint1.transform.position, start.spawnpoint1.transform.rotation);
				clone.SetActive (true);
			}
		} else if (end.reportDes () == start.spawnpoint2.name) {
			if (stored_tag == "me") {
				clone = Instantiate (gabby, start.spawnpoint2.transform.position, start.spawnpoint2.transform.rotation);
				clone.SetActive (true);
			} else {
				clone = Instantiate (badgabby, start.spawnpoint2.transform.position, start.spawnpoint2.transform.rotation);
				clone.SetActive (true);
			}
		} else if (end.reportDes () == start.spawnpoint3.name) {
			if (stored_tag == "me") {
				clone = Instantiate (gabby, start.spawnpoint3.transform.position, start.spawnpoint3.transform.rotation);
				clone.SetActive (true);
			} else {
				clone = Instantiate (badgabby, start.spawnpoint3.transform.position, start.spawnpoint3.transform.rotation);
				clone.SetActive (true);
			}

		} else if (end.reportDes () == start.spawnpoint4.name) {
			if (stored_tag == "me") {
				clone = Instantiate (gabby, start.spawnpoint4.transform.position, start.spawnpoint4.transform.rotation);
				clone.SetActive (true);
			} else {
				clone = Instantiate (badgabby, start.spawnpoint4.transform.position, start.spawnpoint4.transform.rotation);
				clone.SetActive (true);
			}

		} else if (end.reportDes () == start.spawnpoint4.name) {
			if (stored_tag == "me") {
				clone = Instantiate (gabby, start.spawnpoint4.transform.position, start.spawnpoint4.transform.rotation);
				clone.SetActive (true);
			} else {
				clone = Instantiate (badgabby, start.spawnpoint4.transform.position, start.spawnpoint4.transform.rotation);
				clone.SetActive (true);
			}
		}

	}
}








