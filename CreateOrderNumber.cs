using UnityEngine;
using System.Collections;
using System;

public class CreateOrderNumber : MonoBehaviour {
	
	public Texture[] textures_Front;
	public Texture[] textures_Back;
	public Texture[] textures_Left;
	public Texture[] textures_Right;

	int Order_number;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Cart_button_pressed () {

		Order_number = UnityEngine.Random.Range(1,999999); // number fom 1 to 999999 //need to put yhe "UnityEngine."  after puting the  using system at top for the search
		Debug.Log ( "The order number is: " + Order_number);

		//GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.mainTexture 

		int index_Front = Array.IndexOf(textures_Front, GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.mainTexture );
		Debug.Log ("index front is = "+index_Front);

		int index_Back = Array.IndexOf(textures_Back, GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.mainTexture );
		Debug.Log ("index back is = "+index_Back);

		int index_Left = Array.IndexOf(textures_Left, GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.mainTexture );
		Debug.Log ("index left  is = "+index_Left);

		int index_Right = Array.IndexOf(textures_Right, GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.mainTexture );
		Debug.Log ("index right is = "+index_Right);





		// here is where i put in the filters for the websites... dont think a siwtch would work


		//all
		if (index_Front == 0 && index_Back == 0 && index_Left == 0 && index_Right == 0) {

			Application.OpenURL("http://www.nwanime.com/");
		}



		//front only
		if (index_Front != 0 && index_Back == 0 && index_Left == 0 && index_Right == 0) {

			Application.OpenURL("http://www.starwars.com/");
		}

		//back only
		if (index_Front == 0 && index_Back != 0 && index_Left == 0 && index_Right == 0) {

			Application.OpenURL("https://www.teslamotors.com/modelx/design");
		}

		//front & back only
		if (index_Front != 0 && index_Back != 0 && index_Left == 0 && index_Right == 0) {

			Application.OpenURL("https://www.teslamotors.com/models");
		}


		//left only
		if (index_Front == 0 && index_Back == 0 && index_Left != 0 && index_Right == 0) {

			Application.OpenURL("https://www.teslamotors.com/supercharger");
		}

		//front & left only
		if (index_Front != 0 && index_Back == 0 && index_Left != 0 && index_Right == 0) {

			Application.OpenURL("https://www.teslamotors.com/energy");
		}


		//left & back only
		if (index_Front == 0 && index_Back != 0 && index_Left != 0 && index_Right == 0) {

			Application.OpenURL("http://shop.teslamotors.com/?_ga=1.222781851.1846363777.1361192373");
		}

		//front & back & left only
		if (index_Front != 0 && index_Back != 0 && index_Left != 0 && index_Right == 0) {

			Application.OpenURL("https://www.teslamotors.com/model3");
		}


		//right only
		if (index_Front == 0 && index_Back == 0 && index_Left == 0 && index_Right != 0) {

			Application.OpenURL("https://teslamotorsclub.com/tmc/forums/model-x.84/");
		}


		//front & right only
		if (index_Front != 0 && index_Back == 0 && index_Left == 0 && index_Right != 0) {

			Application.OpenURL("http://disneyparks.disney.go.com/blog/");
		}

		//back & right only
		if (index_Front == 0 && index_Back != 0 && index_Left == 0 && index_Right != 0) {

			Application.OpenURL("http://starfleetacademytour.com/");
		}

		//front & back & right only
		if (index_Front != 0 && index_Back != 0 && index_Left == 0 && index_Right != 0) {

			Application.OpenURL("http://stonehearth.net/");
		}

		//left & right only
		if (index_Front == 0 && index_Back == 0 && index_Left != 0 && index_Right != 0) {

			Application.OpenURL("http://www.secretsofgrindea.com/index.php/dev-blog");
		}


		//front & left & right only
		if (index_Front != 0 && index_Back == 0 && index_Left != 0 && index_Right != 0) {

			Application.OpenURL("http://www.stexcalibur.com/");
		}



		//back & left & right only
		if (index_Front == 0 && index_Back != 0 && index_Left != 0 && index_Right != 0) {

			Application.OpenURL("http://hiddenfolks.com/");
		}


		//front & back & left & right - all
		if (index_Front != 0 && index_Back != 0 && index_Left != 0 && index_Right != 0) {

			Application.OpenURL("http://www.krosmaster.com/en/online-game/media");
		}







		// moved this down just in case


		string Total_Order_number = Order_number.ToString () + "-" + index_Front.ToString () + "-" + index_Back.ToString () + "-" + index_Left.ToString () + "-" + index_Right.ToString () + "-" + GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color    ;

		Debug.Log (" The Total order number is: " + Total_Order_number);


    }



}
