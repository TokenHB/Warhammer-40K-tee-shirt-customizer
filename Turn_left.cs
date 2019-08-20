using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Turn_left : MonoBehaviour, IEventSystemHandler {

	//public GameObject character;
	public float turnSpeed = 20f;
	bool buttonHeld = false;

	public void pressed (BaseEventData eventData)
	{
		buttonHeld = true;

		GameObject.Find("Button_VF").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VB").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VL").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VR").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
	}
	public void notpressed(BaseEventData eventData)
	{
		buttonHeld = false;
	}
	void Start () 
	{
		//character = GameObject.FindWithTag ("3d_shirt");
	}
	public void Update ()
	{
		if (buttonHeld) {
			// Do stuff
			Debug.Log ("click");
			// Move Character
			GameObject.Find ("3d_shirt_updated4").transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime); //character.transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);
		} else {
			//Debug.Log ("not click");
		}
	}
}