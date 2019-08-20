using UnityEngine;
using System.Collections;

public class Copy_Texture_from_obj : MonoBehaviour {  // adding color too

	//public GameObject Tex_source_obj;

	//string colorString = "RGBA(0.9f, 0.9f, 0.9f, 1f)";


	// Use this for initialization
	void Start () {
		//GetComponent<Renderer> ().material.mainTexture = Tex_source_obj.GetComponent<Renderer> ().material.mainTexture;

		if (GameObject.Find ("M_Front") != null) {
			GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Front").GetComponent<Renderer> ().material.mainTexture;
			GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Back").GetComponent<Renderer> ().material.mainTexture;
			GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Left").GetComponent<Renderer> ().material.mainTexture;
			GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Right").GetComponent<Renderer> ().material.mainTexture;

			GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Front").GetComponent<Renderer> ().material.color; 
			GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Back").GetComponent<Renderer> ().material.color; 
			GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Left").GetComponent<Renderer> ().material.color; 
			GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Right").GetComponent<Renderer> ().material.color; 
			//Debug.Log ("got one");
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("M_Front") != null) {
			GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Front").GetComponent<Renderer> ().material.mainTexture;
			GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Back").GetComponent<Renderer> ().material.mainTexture;
			GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Left").GetComponent<Renderer> ().material.mainTexture;
			GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.mainTexture = GameObject.Find ("M_Right").GetComponent<Renderer> ().material.mainTexture;

			GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Front").GetComponent<Renderer> ().material.color; 
			GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Back").GetComponent<Renderer> ().material.color; 
			GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Left").GetComponent<Renderer> ().material.color; 
			GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.color = GameObject.Find ("M_Right").GetComponent<Renderer> ().material.color; 

			 //..removeing to see if i can find what is casuign the gray for while.. a darkenign of all the colors- not the cause
			if (GameObject.Find ("M_Front").GetComponent<Renderer> ().sharedMaterial.GetFloat( "_InvertColors")   == 1 ) {

				GameObject.Find ("M_Front_t").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);
				GameObject.Find ("M_Back_t").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);
				GameObject.Find ("M_Left_t").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);
				GameObject.Find ("M_Right_t").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);


			} else {


				GameObject.Find ("M_Front_t").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
				GameObject.Find ("M_Back_t").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
				GameObject.Find ("M_Left_t").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
				GameObject.Find ("M_Right_t").GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);


			}


		} else {
			//Debug.Log ("not there");
		}
	
	}




}
