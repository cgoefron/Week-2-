using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (gameObject.transform.position);

	}
	
	// Update is called once per frame
	void Update () {
		//gameObject.transform.position = new Vector3( 2.3f, 0, 19);
		gameObject.transform.position = gameObject.transform.position +  new Vector3( .03f, .01f, 0);
	}
}
