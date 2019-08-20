using UnityEngine;
using System.Collections;

public class OpenURL : MonoBehaviour {

	public string UrlToOpen = "http://unity3d.com/";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UrlButtonClikced () {

		Application.OpenURL(UrlToOpen);
	}

}
