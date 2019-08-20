using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class View_button_script : MonoBehaviour {

	public Sprite VF;
	public Sprite VF_clicked;

	public Sprite VB;
	public Sprite VB_clicked;


	public Sprite VL;
	public Sprite VL_clicked;

	public Sprite VR;
	public Sprite VR_clicked;


	// Use this for initialization
	void Start () {

		//GameObject.Find("Button_VF").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);

		GameObject.Find("Button_VF").GetComponent<Button> ().image.sprite =VF_clicked;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Front_view_clicked ()
	{
		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view = "front";  


		GameObject.Find("Button_VF").GetComponent<Button> ().image.sprite =VF_clicked;
		GameObject.Find("Button_VB").GetComponent<Button> ().image.sprite =VB;
		GameObject.Find("Button_VL").GetComponent<Button> ().image.sprite = VL;
		GameObject.Find("Button_VR").GetComponent<Button> ().image.sprite =VR;


		/*
		GameObject.Find("Button_VF").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
		GameObject.Find("Button_VB").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VL").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VR").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		*/

		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = true; // using it as a view change also to refesh the logo buttons

	}

	public void Back_view_clicked ()
	{
		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view = "back";


		GameObject.Find("Button_VF").GetComponent<Button> ().image.sprite =VF;
		GameObject.Find("Button_VB").GetComponent<Button> ().image.sprite =VB_clicked;
		GameObject.Find("Button_VL").GetComponent<Button> ().image.sprite = VL;
		GameObject.Find("Button_VR").GetComponent<Button> ().image.sprite =VR;



		/*
		GameObject.Find("Button_VF").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VB").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
		GameObject.Find("Button_VL").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VR").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		*/



		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = true;

	}


	public void Left_view_clicked ()
	{
		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view = "left";


		GameObject.Find("Button_VF").GetComponent<Button> ().image.sprite =VF;
		GameObject.Find("Button_VB").GetComponent<Button> ().image.sprite =VB;
		GameObject.Find("Button_VL").GetComponent<Button> ().image.sprite = VL_clicked;
		GameObject.Find("Button_VR").GetComponent<Button> ().image.sprite =VR;

		/*
		GameObject.Find("Button_VF").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VB").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VL").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
		GameObject.Find("Button_VR").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		*/


		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = true;

	}

	public void Right_view_clicked ()
	{
		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view = "right";


		GameObject.Find("Button_VF").GetComponent<Button> ().image.sprite =VF;
		GameObject.Find("Button_VB").GetComponent<Button> ().image.sprite =VB;
		GameObject.Find("Button_VL").GetComponent<Button> ().image.sprite = VL;
		GameObject.Find("Button_VR").GetComponent<Button> ().image.sprite =VR_clicked;


		/*
		GameObject.Find("Button_VF").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VB").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VL").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_VR").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
		*/


		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = true;

	}


}
