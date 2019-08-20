using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Auto_rotate : MonoBehaviour {

	public float turnSpeed = 10f;
	bool Auto_rotate_toggle= false;
	public int Front_angle = 167;
	public int Back_angle = 344;
	public int Right_angle = 60;
	public int Left_angle = 257;
	//GameObject c1;
	public Button AutoButton;
	//public Sprite Rotate_ActiveSPR;
	//public Sprite Rotate_InactiveSPR;


	public void View_Clicked(){
		Auto_rotate_toggle = !Auto_rotate_toggle;  // toggle auto rotate on/off
	}



	public void Front_View_Clicked(){
		Auto_rotate_toggle = false;  // makes sure its not auto_roatating
	  
		transform.eulerAngles = new Vector3 (0,0,0);
		transform.eulerAngles = new Vector3 (0,Front_angle,0);

	}


	public void Back_View_Clicked(){
		Auto_rotate_toggle = false;  // makes sure its not auto_roatating

		transform.eulerAngles = new Vector3 (0,0,0);
		transform.eulerAngles = new Vector3 (0,Back_angle,0);

	}

	public void Left_View_Clicked(){
		Auto_rotate_toggle = false;   // makes sure its not auto_roatating

		transform.eulerAngles = new Vector3 (0,0,0);
		transform.eulerAngles = new Vector3 (0,Left_angle,0);

	}


	public void Right_View_Clicked(){
		Auto_rotate_toggle = false;  // makes sure its not auto_roatating

		transform.eulerAngles = new Vector3 (0,0,0);
		transform.eulerAngles = new Vector3 (0,Right_angle,0);
		Debug.Log(transform.eulerAngles);
	}




	// Update is called once per frame
	void Update () {
		if (Auto_rotate_toggle) {
			transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);
			//c1 = GameObject.Find ("Button_Auto-rotate");
			//c1.ColorBlock colorTint = gameObject.GetComponent<Button>().colors;
			//AutoButton.image.color = new Color(0.5f,0.5f,0.5f,1f);
			GameObject.Find("Button_Auto-rotate").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
			GameObject.Find("Button_VF").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
			GameObject.Find("Button_VB").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
			GameObject.Find("Button_VL").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
			GameObject.Find("Button_VR").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);

		}
		if (Auto_rotate_toggle== false) {
			//AutoButton.image.color = new Color(1f,1f,1f,1f);
			//GameObject.Find ("Button_Auto-rotate").GetComponent<Button> ().image.sprite = Rotate_InactiveSPR;
			GameObject.Find("Button_Auto-rotate").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		}

	}

}
