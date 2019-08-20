using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeepBetweenSceens : MonoBehaviour {

	//private bool created = false;
	private   GameObject[] gos;
	public string Selected_Shirt_color = "A";  // this is causing the glitch!


	/*
	Shader shader1;
	Shader shader2;
    */

	void Awake() {
		
		/*
		shader1 = Shader.Find( "Standard" );
		shader2 = Shader.Find( "Sprites/SpritesInvertColor" );
		*/

		gos = GameObject.FindGameObjectsWithTag("Shirt");
		Debug.Log (gos);

		if(gos.Length > 1)
		{
			if (GameObject.Find ("M_Front") != null) {
				GameObject.Find ("M_Front").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.mainTexture;
				GameObject.Find ("M_Back").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.mainTexture;
				GameObject.Find ("M_Left").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.mainTexture;
				GameObject.Find ("M_Right").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.mainTexture;

				GameObject.Find ("M_Front").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.color; 
				GameObject.Find ("M_Back").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.color; 
				GameObject.Find ("M_Left").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.color; 
				GameObject.Find ("M_Right").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.color; 

				GameObject.Find ("Shirt_top_view").GetComponent<RawImage> ().material.color   = GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.color; 

				//Selected_Shirt_color = Selected_Shirt_color;
			


				if (GameObject.Find ("M_Front_t").GetComponent<Renderer> ().sharedMaterial.GetFloat( "_InvertColors")   == 1 ) {

					GameObject.Find ("Shirt_top_view").GetComponent<RawImage> ().material.color =  new Color(0.1f,0.1f,0.1f,1f);

					/*
					GameObject.Find ("M_Front").GetComponent<Renderer> ().material.shader = shader2;  // set the shader  to the invert colors shader
					GameObject.Find ("M_Back").GetComponent<Renderer> ().material.shader = shader2;
					GameObject.Find ("M_Left").GetComponent<Renderer> ().material.shader = shader2;
					GameObject.Find ("M_Right").GetComponent<Renderer> ().material.shader = shader2; 
					*/
					GameObject.Find ("M_Front").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);
					GameObject.Find ("M_Back").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);
					GameObject.Find ("M_Left").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);
					GameObject.Find ("M_Right").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);



				} else {

					/*
					GameObject.Find ("M_Front").GetComponent<Renderer> ().material.shader = shader1;  // set the shader  to the invert colors shader
					GameObject.Find ("M_Back").GetComponent<Renderer> ().material.shader = shader1;
					GameObject.Find ("M_Left").GetComponent<Renderer> ().material.shader = shader1;
					GameObject.Find ("M_Right").GetComponent<Renderer> ().material.shader = shader1; 
					*/

					GameObject.Find ("M_Front").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
					GameObject.Find ("M_Back").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
					GameObject.Find ("M_Left").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
					GameObject.Find ("M_Right").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);

					
				}


			//	GameObject.Find ("Shirt_top_view")..GetComponent<RawImage> ().material.color = GameObject.Find ("M_Front").GetComponent<Renderer> ().material.color;

				Debug.Log (GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.color);
			}


			Destroy(this.gameObject);
		}

	}




	// Use this for initializatio

	void Start () {

	if (GameObject.Find ("M_Front") != null) { 
		// this is the first instance - make it persist
		DontDestroyOnLoad(this.gameObject);
		//created = true;

		Debug.Log ("its not there");
	} else {
		// this must be a duplicate from a scene reload - DESTROY!
		Destroy(this.gameObject);

		}


	
	}
	
	// Update is called once per frame
	void Update () {

		//DontDestroyOnLoad (this);

		if (GameObject.Find ("shirt-back-marker") != null) {
			
			GameObject.Find ("shirt-back-marker").GetComponent<RawImage> ().color  = GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.color; 
			GameObject.Find ("shirt-front-marker").GetComponent<RawImage> ().color  = GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.color;
			GameObject.Find ("shirt-left-marker").GetComponent<RawImage> ().color  = GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.color;
			GameObject.Find ("shirt-right-marker").GetComponent<RawImage> ().color  = GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.color;


			if (GameObject.Find ("M_Front_t").GetComponent<Renderer> ().sharedMaterial.GetFloat ("_InvertColors") == 1) {

			    GameObject.Find ("shirt-back-marker").GetComponent<RawImage> ().color  =  new Color (0.1f, 0.1f, 0.1f, 1f);
				GameObject.Find ("shirt-front-marker").GetComponent<RawImage> ().color  =  new Color (0.1f, 0.1f, 0.1f, 1f);
				GameObject.Find ("shirt-left-marker").GetComponent<RawImage> ().color  =  new Color (0.1f, 0.1f, 0.1f, 1f);
				GameObject.Find ("shirt-right-marker").GetComponent<RawImage> ().color  =  new Color (0.1f, 0.1f, 0.1f, 1f);


			}
		}




}
}
