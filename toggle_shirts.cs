using UnityEngine;
using System.Collections;



public class toggle_shirts : MonoBehaviour {

	public static int Selected_Shirt = 0;   // this is global varible

	public void Clicked() {

		Selected_Shirt++;
		Selected_Shirt %= 2; // should be 2 - two shirt objects created
	}


}
