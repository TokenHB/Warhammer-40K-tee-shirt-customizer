using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Logo_button_no_init : MonoBehaviour {

	private GameObject Obj_to_change =GameObject.Find ("M_Front"); //set front to default
	public string array_name;
	public int array_pos;
	private Texture Obj_texture;


	/*
	// would be the same on the other buttons
	public Texture[] SM_tex_F;
	public Texture[] SM_tex_B;
	public Texture[] SM_tex_L;
	public Texture[] SM_tex_R;

	//SAME FOR CH AND THE REST
	*/

	public void Logo_clicked()
	{

		switch (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view) {   // SET THIS AS A GLOBAL IN THE 1ST VIEW BUTTON
		case "front":
			Obj_to_change = GameObject.Find ("M_Front");
			break;

		case "back":
			Obj_to_change = GameObject.Find ("M_Back");
			break;

		case "left":
			Obj_to_change = GameObject.Find ("M_Left");   //these are the real gameobject tags in the editor can be different then the view
			break;

		case "right":
			Obj_to_change = GameObject.Find ("M_Right");
			break;


		default:
			Obj_to_change = GameObject.Find ("M_Front");
			break;
		}

		switch (array_name)
		{

		case "SM":
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().SM_tex_F[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				Obj_texture = GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().SM_tex_B[array_pos];
			}


			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				Obj_texture = GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().SM_tex_L[array_pos];
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				Obj_texture = GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().SM_tex_R[array_pos];
			}
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;


		case "CM" :
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().CM_tex_F[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
		    }

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().CM_tex_B[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().CM_tex_L[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().CM_tex_R[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;


		case "OK" :
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().OK_tex_F[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
		    }

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().OK_tex_B[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().OK_tex_L[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().OK_tex_R[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}
			
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;

		case "EL" :
		
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().EL_tex_F[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
		    }

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().EL_tex_B[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().EL_tex_L[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().EL_tex_R[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}


			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;


		case "TA" :
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().TA_tex_F[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
		    }

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().TA_tex_B[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().TA_tex_L[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().TA_tex_R[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}


			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;

		case "NE" :

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().NE_tex_F[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
		    }

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().NE_tex_B[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().NE_tex_L[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().NE_tex_R[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}


			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;

		case "TY" :
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().TY_tex_F[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
		    }

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().TY_tex_B[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().TY_tex_L[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				Obj_texture =  GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().TY_tex_R[array_pos];   //Obj_texture = SM_tex_F[array_pos];  //the original
			}
			
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;
              

		default:
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				Obj_texture = GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().SM_tex_F[array_pos];
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				Obj_texture = GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().SM_tex_B[array_pos];
			}


			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				Obj_texture = GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().SM_tex_L[array_pos];
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				Obj_texture = GameObject.Find ("Logo1").GetComponent<Logo_button_script> ().SM_tex_R[array_pos];
			}
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;

		}



	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed == true) { //faction or view change
			
			switch (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view) {   // SET THIS AS A GLOBAL IN THE 1ST VIEW BUTTON
			case "front":
				Obj_to_change = GameObject.Find ("M_Front");
				break;

			case "back":
				Obj_to_change = GameObject.Find ("M_Back");
				break;

			case "left":
				Obj_to_change = GameObject.Find ("M_Left");   //these are the real gameobject tags in the editor can be different then the view
				break;

			case "right":
				Obj_to_change = GameObject.Find ("M_Right");
				break;


			default:
				Obj_to_change = GameObject.Find ("M_Front");
				break;
			}


			GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = false; // used for both fractions and view changes
		//}

	}
}
