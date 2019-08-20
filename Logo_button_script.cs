using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Logo_button_script : MonoBehaviour {

	public GameObject[] Objs;  // HERE IS WHERE I UP THE LOGO BUTTONS
	public Sprite[] SM_Logos_F;   // THESE ARE THE LOGOS THAT MATCH 1:1 WITH THE TEXTURES ON THE 3D OBJECT - I THINK I CAN ASSIGN THEM TO FRONT OBJ AND THEY GET ACCESED BY ALL OTHERS
	public Sprite[] SM_Logos_B;
	public Sprite[] SM_Logos_L;
	public Sprite[] SM_Logos_R;

	public Sprite[] CM_Logos_F; //use for L/R aswell
	public Sprite[] CM_Logos_B;


	public Sprite[] OK_Logos;  //USE FOR ALL SIDES
	public Sprite[] EL_Logos;  //USE FOR ALL SIDES
	public Sprite[] TA_Logos;   //USE FOR ALL SIDES
	public Sprite[] NE_Logos;   //USE FOR ALL SIDES
	public Sprite[] TY_Logos;   //USE FOR ALL SIDES

	public Texture[] SM_tex_F;
	public Texture[] SM_tex_B;
	public Texture[] SM_tex_L;
	public Texture[] SM_tex_R;

	public Texture[] CM_tex_F;
	public Texture[] CM_tex_B;
	public Texture[] CM_tex_L;
	public Texture[] CM_tex_R;

	public Texture[] OK_tex_F;
	public Texture[] OK_tex_B;
	public Texture[] OK_tex_L;
	public Texture[] OK_tex_R;

	public Texture[] EL_tex_F;
	public Texture[] EL_tex_B;
	public Texture[] EL_tex_L;
	public Texture[] EL_tex_R;

	public Texture[] TA_tex_F;
	public Texture[] TA_tex_B;
	public Texture[] TA_tex_L;
	public Texture[] TA_tex_R;

	public Texture[] NE_tex_F;
	public Texture[] NE_tex_B;
	public Texture[] NE_tex_L;
	public Texture[] NE_tex_R;

	public Texture[] TY_tex_F;
	public Texture[] TY_tex_B;
	public Texture[] TY_tex_L;
	public Texture[] TY_tex_R;


	int i = 0;

	int Loop_lenghtF;
	int Loop_lenghtB;
	int Loop_lenghtL;
	int Loop_lenghtR;

	/*
	private GameObject Obj_to_change =GameObject.Find ("M_Front"); //set front to default
	public string array_name;
	public int array_pos;
	private Texture Obj_texture;
*/
	// Use this for initialization
	void Start () {


		i = 0;   // this sets up the default logos whcih will always be SM front!
		Loop_lenghtF = SM_Logos_F.Length;
		for (int j = 0; j < Loop_lenghtF; j++) {		
			Objs[i].GetComponent<Button> ().image.sprite = SM_Logos_F [j];
			Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
			Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
			//Debug.Log (i);
			//Debug.Log (j);
			i++;

		}

		/*

		switch (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected) {  // THIS IS A GLOBAL VARIBLE TO BE PUT ON THE 1ST FRACTION BUTTON

		case "SM":  //prob only need this front SM one... if that will be the deafult setting anyway.. only one is needed!!
			
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				i = 0;
				Loop_lenghtF = SM_Logos_F.Length;
				for (int j = 0; j < Loop_lenghtF; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = SM_Logos_F [j];
					//Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					//Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					Debug.Log (i);
					Debug.Log (j);
					i++;
			
				}
			}  //end front

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				i = 0;
				Loop_lenghtB = SM_Logos_B.Length;
				for (int j = 0; j < Loop_lenghtB; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = SM_Logos_B [j];
					//Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					//Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					//i++;

				}
			}  //end back


			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				i = 0;
				Loop_lenghtL = SM_Logos_L.Length;
				for (int j = 0; j < Loop_lenghtL; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = SM_Logos_L [j];
					//Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					//Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					i++;

				}
			}  //end left

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				i = 0;
				Loop_lenghtR = SM_Logos_R.Length;
				for (int j = 0; j < Loop_lenghtR; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = SM_Logos_R [j];
					//Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					//Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					i++;

				}
			}  //end back
				
			break;

		
		case "CM" :
			Loop_lenght = CM_Logos.Length;
			for( int j =0; j < Loop_lenght; j++){		
				Objs[i].GetComponent<Button> ().image.sprite = CM_Logos[j];
				Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
				Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
				i++;
			}
			break;

		case "OK" :
			Loop_lenght = OK_Logos.Length;
			for( int j =0; j < Loop_lenght; j++){		
				Objs[i].GetComponent<Button> ().image.sprite = OK_Logos[j];
				Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
				Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
				i++;
			}
			break;

		case "EL" :
			Loop_lenght = EL_Logos.Length;
			for( int j =0; j < Loop_lenght; j++){		
				Objs[i].GetComponent<Button> ().image.sprite = EL_Logos[j];
				Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
				Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
				i++;
			}
			break;

		case "TA" :
			Loop_lenght = TA_Logos.Length;
			for( int j =0; j < Loop_lenght; j++){		
				Objs[i].GetComponent<Button> ().image.sprite = TA_Logos[j];
				Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
				Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
				i++;
			}
			break;

		case "NE" :
			Loop_lenght = NE_Logos.Length;
			for( int j =0; j < Loop_lenght; j++){		
				Objs[i].GetComponent<Button> ().image.sprite = NE_Logos[j];
				Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
				Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
				i++;
			}
			break;

		case "TY" :
			Loop_lenght = TY_Logos.Length;
			for( int j =0; j < Loop_lenght; j++){		
				Objs[i].GetComponent<Button> ().image.sprite = TY_Logos[j];
				Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
				Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
				i++;
			}
			break;
  
		default:
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				i = 0;
				Loop_lenghtF = SM_Logos_F.Length;
				for (int j = 0; j < Loop_lenghtF; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = SM_Logos_F [j];
					//Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					//Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					Debug.Log (i);
					Debug.Log (j);
					i++;
				}
			}
			break;
		} // switch end

  */  // here i removed the check and set up for all possible fractions since only SM front is needed!
		/*
	}


	public void Logo_clicked()
	{
		switch (array_name)
		{
		case "SM":
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				Obj_texture = SM_tex_F[array_pos];
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				Obj_texture = SM_tex_B[array_pos];
			}


			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				Obj_texture = SM_tex_L[array_pos];
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				Obj_texture = SM_tex_R[array_pos];
			}
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;

			/*
		case "CM" :
			Obj_texture = CM_Logos[array_pos];
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;

		case "OK" :
			Obj_texture = OK_Logos[array_pos];
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;

		case "EL" :
			Obj_texture = EL_Logos[array_pos];
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;


		case "TA" :
			Obj_texture = TA_Logos[array_pos];
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;

		case "NE" :
			Obj_texture = NE_Logos[array_pos];
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;

		case "TY" :
			Obj_texture = TY_Logos[array_pos];
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;
              

		default:
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				Obj_texture = SM_tex_F[array_pos];
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				Obj_texture = SM_tex_B[array_pos];
			}


			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				Obj_texture = SM_tex_L[array_pos];
			}

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				Obj_texture = SM_tex_R[array_pos];
			}
			Obj_to_change.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture;
			break;

		}

		*/

	}


	
	// Update is called once per frame
	void Update ()  
	{
	 /*
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
	*/
		//if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed == true){

		switch (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected) {  // THIS IS A GLOBAL VARIBLE TO BE PUT ON THE 1ST FRACTION BUTTON

		case "SM":  // here i would do all front,back.left.right for each fraction

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				i = 0;
				Loop_lenghtF = SM_Logos_F.Length;
				for (int j = 0; j < Loop_lenghtF; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = SM_Logos_F [j];
					Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					//Debug.Log (i);
					//Debug.Log (j);
					i++;

				}
			}  //end front

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
				i = 0;
				Loop_lenghtB = SM_Logos_B.Length;
				for (int j = 0; j < Loop_lenghtB; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = SM_Logos_B [j];
					Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					i++;

				}
			}  //end back


			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left") {
				i = 0;
				Loop_lenghtL = SM_Logos_L.Length;
				for (int j = 0; j < Loop_lenghtL; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = SM_Logos_L [j];  // GOT AN INDEX OUT OF RANGE ERROR
					Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					i++;

				}
			}  //end left

			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
				i = 0;
				Loop_lenghtR = SM_Logos_R.Length;
				for (int j = 0; j < Loop_lenghtR; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = SM_Logos_R [j];
					Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					i++;

				}
			}  //end back

			break;

			
		case "CM" :
				
				if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front" || GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "left" || GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "right") {
					i = 0;
					Loop_lenghtF = CM_Logos_F.Length;
					for (int j = 0; j < Loop_lenghtF; j++) {		
						Objs [i].GetComponent<Button> ().image.sprite = CM_Logos_F [j];
						Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
						Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
						//Debug.Log (i);
						//Debug.Log (j);
						i++;

					}
				}  //end front or left or right

				if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "back") {
					i = 0;
					Loop_lenghtB = CM_Logos_B.Length;
					for (int j = 0; j < Loop_lenghtB; j++) {		
						Objs [i].GetComponent<Button> ().image.sprite = CM_Logos_B [j];
						Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
						Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;

						i++;

					}
				}  //end back


			break;

			case "OK":
				
				i = 0;
				Loop_lenghtF = OK_Logos.Length;
				for (int j = 0; j < Loop_lenghtF; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = OK_Logos [j];
					Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					//Debug.Log (i);
					//Debug.Log (j);
					i++;
				}
			break;

		case "EL" :
				i = 0;
				Loop_lenghtF = EL_Logos.Length;
				for (int j = 0; j < Loop_lenghtF; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = EL_Logos [j];
					Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					//Debug.Log (i);
					//Debug.Log (j);
					i++;
				}
			break;

		case "TA" :
				i = 0;
				Loop_lenghtF = TA_Logos.Length;
				for (int j = 0; j < Loop_lenghtF; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = TA_Logos [j];
					Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					//Debug.Log (i);
					//Debug.Log (j);
					i++;
				}
			break;

		case "NE" :
				i = 0;
				Loop_lenghtF = NE_Logos.Length;
				for (int j = 0; j < Loop_lenghtF; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = NE_Logos [j];
					Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					//Debug.Log (i);
					//Debug.Log (j);
					i++;
				}
			break;

		case "TY" :
				i = 0;
				Loop_lenghtF = TY_Logos.Length;
				for (int j = 0; j < Loop_lenghtF; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = TY_Logos [j];
					Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					//Debug.Log (i);
					//Debug.Log (j);
					i++;
				}
			break;
   
		default:
			if (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().Selected_view == "front") {
				i = 0;
				Loop_lenghtF = SM_Logos_F.Length;
				for (int j = 0; j < Loop_lenghtF; j++) {		
					Objs [i].GetComponent<Button> ().image.sprite = SM_Logos_F [j];
					Objs[i].GetComponent<Logo_button_no_init> ().array_name = GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().fraction_selected;
					Objs[i].GetComponent<Logo_button_no_init> ().array_pos = j;
					//Debug.Log (i);
					//Debug.Log (j);
					i++;
				}
			}
			break;
		} // switch end

			//Debug.Log ("faction change complete!");
			GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed = false; // used for both fractions and view changes
		//	Debug.Log (GameObject.Find ("3d_shirt_updated4").GetComponent<Globals_set_up> ().faction_changed);
	//} // check for fraction change end


	}
}

