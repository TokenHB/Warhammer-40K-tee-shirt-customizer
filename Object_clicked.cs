using UnityEngine;
using System.Collections;

public class Object_clicked : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{

	
	}



	

	
	// Update is called once per frame
	void Update ()
	{

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
	   
		if (Physics.Raycast (ray, out hit)) {
			Debug.Log (hit.transform.name);
			if (hit.transform.tag == "3d_shirt") {
				Debug.Log ("It's working!");
			} else {
				Debug.Log ("It's not working!");
			}
		}


		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Mouse is down");

		}



		/*
		if (Input.GetMouseButtonDown(0))
		{
			     Debug.Log("Mouse is down");

			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),100);  //bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			Debug.Log(hit);
			Debug.Log(hitInfo);
			if (hit) 
			    {
				

				Debug.Log("Hit " + hitInfo.transform.gameObject.name);
				if (hitInfo.transform.gameObject.name == "front")  //if (hitInfo.transform.gameObject.tag == "front")
				{
					Debug.Log ("It's working!");
				            } else {
					Debug.Log ("nopz");
				}
			} else {
				Debug.Log("No hit");
			        }
			//Debug.Log("Mouse is down");
		} 
	}
	*/

	}
}
