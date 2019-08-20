using UnityEngine;
using System.Collections;

public class But_swap_texture : MonoBehaviour {

	public Texture Obj_texture;

	GameObject c1;

	public void Clicked() {

		if (toggle_shirts.Selected_Shirt == 0) {
			c1= GameObject.Find ("front");
		}
		else if (toggle_shirts.Selected_Shirt == 1) {
			c1= GameObject.Find ("front2");
		}
			
		//c1= GameObject.Find ("front");  // this find an an object if the script is not attached // removed to allow the above to work

		c1.transform.GetComponent<Renderer>().material.mainTexture = Obj_texture; //must assign the file name as a texture above

		//public static int mytest = 0;  // this is global varible


	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
