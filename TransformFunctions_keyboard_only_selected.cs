using UnityEngine;
using System.Collections;

public class TransformFunctions_keyboard_only_selected : MonoBehaviour {

	GameObject c1;

	public float moveSpeed = 10f;
	public float turnSpeed = 10f;


	void Update ()
	{
		if (toggle_shirts.Selected_Shirt == 0) {
			c1= GameObject.Find ("front");
		}
		else if (toggle_shirts.Selected_Shirt == 1) {
			c1= GameObject.Find ("front2");
		}

		/*
		if(Input.GetKey(KeyCode.UpArrow))
			c1.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.DownArrow))
			c1.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
       */
		if(Input.GetKey(KeyCode.LeftArrow))
			c1.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.RightArrow))
			c1.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
	}
}

