using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loading_animation : MonoBehaviour {

	//public Texture[] Animation_textures;
	//public int currentTexture;
	public bool Start_loading_animation = false;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		if (Start_loading_animation) {
			
			transform.position = new Vector3 (480, 300, 0);

			}

		}



}
