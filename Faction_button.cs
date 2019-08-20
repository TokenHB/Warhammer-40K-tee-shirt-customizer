using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Faction_button : MonoBehaviour {

	public Texture[] fraction_background; 
	 

	public void SM_pressed ()
	{
		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = true;

		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected = "SM";  
		GameObject.Find("Button_SM").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
		GameObject.Find("Button_CM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_OK").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_EL").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TA").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_NE").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TY").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);

		GameObject.Find ("selected_fraction").GetComponent<RawImage>().texture = fraction_background[0];

		Debug.Log (fraction_background.Length);
		Debug.Log (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed);
	}

	public void CM_pressed ()
	{

		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = true;

		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected = "CM";  
		GameObject.Find("Button_SM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_CM").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
		GameObject.Find("Button_OK").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_EL").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TA").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_NE").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TY").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);

		GameObject.Find ("selected_fraction").GetComponent<RawImage>().texture = fraction_background[1];
		Debug.Log (fraction_background.Length);
		Debug.Log (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed);

	}


	public void OK_pressed ()
	{
		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = true;

		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected = "OK";  
		GameObject.Find("Button_SM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_CM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_OK").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
		GameObject.Find("Button_EL").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TA").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_NE").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TY").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);

		GameObject.Find ("selected_fraction").GetComponent<RawImage>().texture = fraction_background[2];

	}


	public void EL_pressed ()
	{
		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = true;

		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected = "EL";  
		GameObject.Find("Button_SM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_CM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_OK").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_EL").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
		GameObject.Find("Button_TA").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_NE").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TY").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);

		GameObject.Find ("selected_fraction").GetComponent<RawImage>().texture = fraction_background[3];

	}


	public void TA_pressed ()
	{
		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = true;

		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected = "TA";  
		GameObject.Find("Button_SM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_CM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_OK").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_EL").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TA").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
		GameObject.Find("Button_NE").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TY").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);

		GameObject.Find ("selected_fraction").GetComponent<RawImage>().texture = fraction_background[4];

	}


	public void NE_pressed ()
	{
		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = true;

		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected = "NE";  
		GameObject.Find("Button_SM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_CM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_OK").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_EL").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TA").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_NE").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
		GameObject.Find("Button_TY").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);

		GameObject.Find ("selected_fraction").GetComponent<RawImage>().texture = fraction_background[5];

	}

	public void TY_pressed ()
	{
		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = true;

		GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected = "TY";  
		GameObject.Find("Button_SM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_CM").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_OK").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_EL").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TA").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_NE").GetComponent<Button> ().image.color = new Color(1f,1f,1f,1f);
		GameObject.Find("Button_TY").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);

		GameObject.Find ("selected_fraction").GetComponent<RawImage>().texture = fraction_background[6];

	}


	// Use this for initialization
	void Start () {

		GameObject.Find("Button_SM").GetComponent<Button> ().image.color = new Color(0.5f,0.5f,0.5f,1f);
	}

	// Update is called once per frame
	void Update () {

	}


}

