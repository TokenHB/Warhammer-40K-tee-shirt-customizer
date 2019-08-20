using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.EventSystems;

public class myButtonImage : MonoBehaviour {

	public Sprite myButtonImage1; // Assign /Initilize from Editor or code
	private Button level2;
	public Sprite[] SM_images;
	public Texture Front_short;

	void Start ()
	{
		GameObject.Find("Button_SM").GetComponent<Button> ().image.sprite = SM_images[0];
		GameObject.Find("Button_OK").GetComponent<Button> ().image.sprite = SM_images[1];



		//level2.
		//character = GameObject.FindWithTag ("3d_shirt");
		//myButton.image.color = new Color(255f,0f,0f,.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeTex(){

		GameObject.Find ("front2").GetComponent<Renderer>().material.mainTexture = GameObject.Find ("front2").GetComponent<SwapTextures>().textures[2];
		//GameObject.Find("front_Projector").GetComponent<Projector> ().material.mainTexture = Front_short;
		//GameObject.Find("front_Projector").GetComponent<Projector> ().material.SetTexture("_MainTex", Front_short);
	}





}
