using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Change_color : MonoBehaviour {
	public GameObject c1;
	public GameObject c2;
	public GameObject c3;
	public GameObject c4;
	public GameObject RawImage1;
	//public RawImage img;

	/*
	  Shader shader1;
	  Shader shader2;
	*/
	//public Button Co0;


	void Start () {

		//GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "A";

		/*
		shader1 = Shader.Find( "Standard" );
		shader2 = Shader.Find( "Sprites/SpritesInvertColor" );
		*/

		/*  // sets it back to stanrad  when goign between screens - removed
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 


        */

	//RawImage1.GetComponent<RawImage> ().material.color   = new Color(1f,1f,1f,1f);

	}



	public void White_Clicked()
	{
		/*
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 
		*/


		c1.GetComponent<Renderer> ().material.color = new Color(1f,1f,1f,1f);
		c2.GetComponent<Renderer> ().material.color = new Color(1f,1f,1f,1f);
		c3.GetComponent<Renderer> ().material.color = new Color(1f,1f,1f,1f);
		c4.GetComponent<Renderer> ().material.color = new Color(1f,1f,1f,1f);

		RawImage1.GetComponent<RawImage> ().material.color   = new Color(1f,1f,1f,1f);

		//  not needed when using the standard shader
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
       


		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "A";

	}

	public void Pink_Clicked()
	{
		/*
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 
		*/




		c1.GetComponent<Renderer> ().material.color = new Color(1f,0.8f,0.8f,1f); //pink
		c2.GetComponent<Renderer> ().material.color = new Color(1f,0.8f,0.8f,1f); //pink
		c3.GetComponent<Renderer> ().material.color = new Color(1f,0.8f,0.8f,1f); //pink
		c4.GetComponent<Renderer> ().material.color = new Color(1f,0.8f,0.8f,1f); //pink

		RawImage1.GetComponent<RawImage> ().material.color = new Color(1f,0.8f,0.8f,1f); //pink

		//  not needed when using the standard shader
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
    

		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "B";
	}


	public void light_blue_Clicked()
	{
		/*
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 
		*/



		c1.GetComponent<Renderer> ().material.color = new Color(0f,0.9f,1f,1f);  //light blue
		c2.GetComponent<Renderer> ().material.color = new Color(0f,0.9f,1f,1f);  //light blue
		c3.GetComponent<Renderer> ().material.color = new Color(0f,0.9f,1f,1f);  //light blue
		c4.GetComponent<Renderer> ().material.color = new Color(0f,0.9f,1f,1f);  //light blue
		RawImage1.GetComponent<RawImage> ().material.color =  new Color(0f,0.9f,1f,1f);  //light blue

		//GameObject.Find("Logo1").GetComponent<Button> ().image.color = new Color(0f,0.9f,1f,1f);  //light blue

		// not needed when using the standard shader
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
       

		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "C";
	}

	public void blue_Clicked()
	{
		/*
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 
		*/



		c1.GetComponent<Renderer> ().material.color = new Color(0.12f,0.12f,1f,1f); // blue
		c2.GetComponent<Renderer> ().material.color = new Color(0.12f,0.12f,1f,1f); // blue
		c3.GetComponent<Renderer> ().material.color = new Color(0.12f,0.12f,1f,1f); // blue
		c4.GetComponent<Renderer> ().material.color = new Color(0.12f,0.12f,1f,1f); // blue

		RawImage1.GetComponent<RawImage> ().material.color = new Color(0.12f,0.12f,1f,1f); // blue

		//GameObject.Find("Logo1").GetComponent<Button> ().image.color = new Color(0.12f,0.12f,1f,1f); // blue

		//  not needed when using the standard shader
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
     

		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "D";
			
	}

	public void yellow_Clicked()
	{
		/*
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 
		*/



		c1.GetComponent<Renderer> ().material.color = new Color(0.9f,1f,0f,1f); // yellow
		c2.GetComponent<Renderer> ().material.color = new Color(0.9f,1f,0f,1f); // yellow
		c3.GetComponent<Renderer> ().material.color = new Color(0.9f,1f,0f,1f); // yellow
		c4.GetComponent<Renderer> ().material.color = new Color(0.9f,1f,0f,1f); // yellow

		RawImage1.GetComponent<RawImage> ().material.color  = new Color(0.9f,1f,0f,1f); // yellow

		//GameObject.Find("Logo1").GetComponent<Button> ().image.color =new Color(0.9f,1f,0f,1f); // yellow

		// not needed when using the standard shader
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
        

		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "E";
	}



	public void orange_Clicked()
	{
		/*
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 
		*/




		c1.GetComponent<Renderer> ().material.color = new Color(0.9f,0.5f,0f,1f);// orange
		c2.GetComponent<Renderer> ().material.color = new Color(0.9f,0.5f,0f,1f);// orange
		c3.GetComponent<Renderer> ().material.color = new Color(0.9f,0.5f,0f,1f);// orange
		c4.GetComponent<Renderer> ().material.color = new Color(0.9f,0.5f,0f,1f);// orange

		RawImage1.GetComponent<RawImage> ().material.color  = new Color(0.9f,0.5f,0f,1f);// orange

		//GameObject.Find("Logo1").GetComponent<Button> ().image.color = new Color(0.9f,0.5f,0f,1f);// orange

		// not needed when using the standard shader
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
       

		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "F";
	}

	public void light_green_Clicked()
	{
		/*
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 
		*/




		c1.GetComponent<Renderer> ().material.color = new Color(0.5f,1f,0f,1f); // light green
		c2.GetComponent<Renderer> ().material.color = new Color(0.5f,1f,0f,1f); // light green
		c3.GetComponent<Renderer> ().material.color = new Color(0.5f,1f,0f,1f); // light green
		c4.GetComponent<Renderer> ().material.color = new Color(0.5f,1f,0f,1f); // light green

		RawImage1.GetComponent<RawImage> ().material.color  = new Color(0.5f,1f,0f,1f); // light green

		//GameObject.Find("Logo1").GetComponent<Button> ().image.color = new Color(0.5f,1f,0f,1f); // light green

		// not needed when using the standard shader
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
        

		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "G";
	}

	public void dark_green_Clicked()
	{
		/*
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 
		*/




		c1.GetComponent<Renderer> ().material.color = new Color(0f,0.7f,0.3f,1f); //dark green
		c2.GetComponent<Renderer> ().material.color = new Color(0f,0.7f,0.3f,1f); //dark green
		c3.GetComponent<Renderer> ().material.color = new Color(0f,0.7f,0.3f,1f); //dark green
		c4.GetComponent<Renderer> ().material.color = new Color(0f,0.7f,0.3f,1f); //dark green

		RawImage1.GetComponent<RawImage> ().material.color  = new Color(0f,0.7f,0.3f,1f); //dark green

		//GameObject.Find("Logo1").GetComponent<Button> ().image.color = new Color(0f,0.7f,0.3f,1f); //dark green

		// not needed when using the standard shader
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
      

		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "H";
	}

	public void purple_Clicked()
	{
		/*
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 
		*/




		c1.GetComponent<Renderer> ().material.color = new Color (0.8f, 0.18f, 0.8f, 1f);  //purple
		c2.GetComponent<Renderer> ().material.color = new Color (0.8f, 0.18f, 0.8f, 1f);  //purple
		c3.GetComponent<Renderer> ().material.color = new Color (0.8f, 0.18f, 0.8f, 1f);  //purple
		c4.GetComponent<Renderer> ().material.color = new Color (0.8f, 0.18f, 0.8f, 1f);  //purple

		RawImage1.GetComponent<RawImage> ().material.color = new Color (0.8f, 0.18f, 0.8f, 1f);  //purple

		//GameObject.Find("Logo1").GetComponent<Button> ().image.color = new Color (0.8f, 0.18f, 0.8f, 1f);  //purple

		// not needed when using the standard shader
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
      

		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "I";
	}

	public void red_Clicked()
	{
		/*
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 
		*/




		c1.GetComponent<Renderer> ().material.color = new Color(1f,0f,0f,1f);  //red
		c2.GetComponent<Renderer> ().material.color = new Color(1f,0f,0f,1f);  //red
		c3.GetComponent<Renderer> ().material.color = new Color(1f,0f,0f,1f);  //red
		c4.GetComponent<Renderer> ().material.color = new Color(1f,0f,0f,1f);  //red

		RawImage1.GetComponent<RawImage> ().material.color =  new Color(1f,0f,0f,1f);  //red

		//GameObject.Find("Logo1").GetComponent<Button> ().image.color = new Color(1f,0f,0f,1f);  //red

		//  not needed when using the standard shader
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
        
		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "J";
	}



	public void grey_Clicked()
	{
		/*
		c1.GetComponent<Renderer> () .material.shader = shader1;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader1;
		c3.GetComponent<Renderer> () .material.shader = shader1;
		c4.GetComponent<Renderer> () .material.shader = shader1;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader1;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader1;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader1; 
		*/




		c1.GetComponent<Renderer> ().material.color = new Color(0.5f,0.5f,0.5f,1f);  //grey
		c2.GetComponent<Renderer> ().material.color = new Color(0.5f,0.5f,0.5f,1f);  //grey
		c3.GetComponent<Renderer> ().material.color = new Color(0.5f,0.5f,0.5f,1f);  //grey
		c4.GetComponent<Renderer> ().material.color = new Color(0.5f,0.5f,0.5f,1f);  //grey

		RawImage1.GetComponent<RawImage> ().material.color =  new Color(0.5f,0.5f,0.5f,1f);  //grey

		//GameObject.Find("Logo1").GetComponent<Button> ().image.color = new Color(0.4f,0.4f,0.4f,1f);  //greye
		//  not needed when using the standard shader
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 0);
        

		GameObject.Find ("All_background").GetComponent<RawImage>().color = new Color(0.2f,0.2f,0.2f,1f);  //grey

		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "K";
	}

	public void black_Clicked()   // this will need to change!
	{

		/*
		c1.GetComponent<Renderer> ().material.color = new Color(0f,0f,0f,1f);   //black
		c2.GetComponent<Renderer> ().material.color = new Color(0f,0f,0f,1f);   //black
		c3.GetComponent<Renderer> ().material.color = new Color(0f,0f,0f,1f);   //black
		c4.GetComponent<Renderer> ().material.color = new Color(0f,0f,0f,1f);   //black
        */

		// set everythign back to white 1st
		c1.GetComponent<Renderer> ().material.color = new Color(0.9f,0.9f,0.9f,1f);
		c2.GetComponent<Renderer> ().material.color = new Color(0.9f,0.9f,0.9f,1f);
		c3.GetComponent<Renderer> ().material.color = new Color(0.9f,0.9f,0.9f,1f);
		c4.GetComponent<Renderer> ().material.color = new Color(0.9f,0.9f,0.9f,1f);


		RawImage1.GetComponent<RawImage> ().material.color =  new Color(0.1f,0.1f,0.1f,1f);   //black
	

		/*
		c1.GetComponent<Renderer> () .material.shader = shader2;  // set the shader back to standard
		c2.GetComponent<Renderer> () .material.shader = shader2;
		c3.GetComponent<Renderer> () .material.shader = shader2;
		c4.GetComponent<Renderer> () .material.shader = shader2;

		GameObject.Find ("M_Front_t").GetComponent<Renderer> ().material.shader = shader2;  // set the shader back to standard
		GameObject.Find ("M_Back_t").GetComponent<Renderer> ().material.shader = shader2;
		GameObject.Find ("M_Left_t").GetComponent<Renderer> ().material.shader = shader2;
		GameObject.Find ("M_Right_t").GetComponent<Renderer> ().material.shader = shader2; 
		*/

       
		c1.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);
		c2.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);
		c3.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);
		c4.GetComponent<Renderer> ().sharedMaterial.SetFloat ("_InvertColors", 1);

		//GameObject.Find("Logo1").GetComponent<Button> ().image.color = new Color(0f,0f,0f,1f);   //black

		//GameObject.Find ("All_background").GetComponent<RawImage>().color = new Color(0.5f,0.5f,0.5f,1f);  //grey

		GameObject.Find ("All_background").GetComponent<RawImage>().color = new Color(0.2f,0.2f,0.2f,1f);  //grey


		GameObject.Find ("3d_shirt_transfer").GetComponent<KeepBetweenSceens> ().Selected_Shirt_color = "L";




	}

}
