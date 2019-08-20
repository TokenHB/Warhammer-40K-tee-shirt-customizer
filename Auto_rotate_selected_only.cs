using UnityEngine;
using System.Collections;

public class Auto_rotate_seleected_only : MonoBehaviour {
	
	GameObject c1;

		public float turnSpeed = 10f;
	    bool Auto_rotate= true;

	public void View_Clicked(){
		Auto_rotate = !Auto_rotate;
	}


		// Update is called once per frame
		void Update () {

		if (Auto_rotate) {
			if (toggle_shirts.Selected_Shirt == 0) {
				c1 = GameObject.Find ("front");
			} else if (toggle_shirts.Selected_Shirt == 1) {
				c1 = GameObject.Find ("front2");
			}

			c1.transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);
		}
	}
	}

