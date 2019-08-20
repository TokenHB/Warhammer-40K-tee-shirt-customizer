using UnityEngine;
using System.Collections;

public class SwapTextures : MonoBehaviour {
	public Texture[] textures;
	public int currentTexture;
	public Texture Front_short;

	//public GameObject[] Objs;

	GameObject c1;

	//mine
	public Texture[] SM_textures;
	public int SM_currentTexture;


	public void Clicked() {

		currentTexture++;
		currentTexture %= textures.Length;
		GetComponent<Renderer>().material.mainTexture = textures[currentTexture];

	}

	// Use this for initialization
	void Start () {
	
	}

	public void SM_Clicked() {


		GetComponent<Renderer>().material.mainTexture = SM_textures[0];

	}



	public void Front_Short_Clicked() {
		c1= GameObject.Find ("front");  // this find an an object if the script is not attached

		c1.transform.GetComponent<Renderer>().material.mainTexture = Front_short; //must assign the file name as a texture above
	
		//GetComponent<Renderer>().material.mainTexture = Front_short;
	
	
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			currentTexture++;
			currentTexture %= textures.Length;
			GetComponent<Renderer>().material.mainTexture = textures[currentTexture];
		}




	}
}
