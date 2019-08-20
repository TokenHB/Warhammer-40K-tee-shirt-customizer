using UnityEngine;
using System.Collections;
using System; //needed for the search of the index

public class RandomNumberTest : MonoBehaviour {

	int number;

	public string[] strings = { "Sthe", "quick", "brown", "fox", "jumps",
		"over", "the", "lazy", "dog", "in", "the",
		"barn" };

	// Use this for initialization
	void Start () {
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254  //need to put yhe "UnityEngine."  after puting the  using system at top for the search
		Debug.Log ( "The number that was generated: " + number);
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254
		Debug.Log ( "The number that was generated: " + number);
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254
		Debug.Log ( "The number that was generated: " + number);
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254
		Debug.Log ( "The number that was generated: " + number);
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254
		Debug.Log ( "The number that was generated: " + number);
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254
		Debug.Log ( "The number that was generated: " + number);
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254
		Debug.Log ( "The number that was generated: " + number);
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254
		Debug.Log ( "The number that was generated: " + number);
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254
		Debug.Log ( "The number that was generated: " + number);
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254
		Debug.Log ( "The number that was generated: " + number);
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254
		Debug.Log ( "The number that was generated: " + number);
		number = UnityEngine.Random.Range(1,999999); // number fom 1 to 254
		Debug.Log ( "The number that was generated: " + number);

		string searchString = "the";
		int index = Array.IndexOf(strings, searchString);
		Debug.Log ("index is = "+index);

	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
