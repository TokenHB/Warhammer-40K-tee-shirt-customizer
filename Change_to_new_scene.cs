using UnityEngine;
using System.Collections;

public class Change_to_new_scene : MonoBehaviour {

	public int numberOfTheLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Change_scene_pressed() {

		if (GameObject.Find ("Laoding_animation_image") != null) {
		GameObject.Find ("Laoding_animation_image").GetComponent<Loading_animation> ().Start_loading_animation = true;



		}

		Application.LoadLevel(numberOfTheLevel);


	}


}
