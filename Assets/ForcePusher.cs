using UnityEngine;
using System.Collections;

public class ForcePusher : MonoBehaviour {

	private float xForce; 
	//private int zTorque;
	//private GameObject redCube;
	//private GameObject otherThing;
	//private vs public var; public can be accessed from elsewhere
	//put variables before start

	// Use this for initialization
	void Start () {
		xForce = 150;
		//zTorque = 230;
		//redCube = GameObject.Find ("redCube");
		gameObject.GetComponent<ParticleSystem>().enableEmission = false;
		//one = translates a property, two == asks if equal value
		//print (otherThing);
	}
	
	// Update is called once per frame
	void Update () {
	//when I hit the key space, move the object
		// if I hit the space key
		if (Input.GetKey (KeyCode.Space) == true) { 
			//can use "_" instead of Keycode.Space
			// if ((10<11) || (120<=10)) {
			// double bars || mean or, double ands && mean both true
			//gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (xForce, 0, 0));
			//gameObject.GetComponent<Rigidbody> ().AddTorque (new Vector3 (0, 0, 150));
			Rigidbody rb = gameObject.GetComponent<Rigidbody> ();
			//rb.AddForce (new Vector3 (xForce, 0, 0));
			//rb.AddTorque (new Vector3 (0, 0, 150));
			//rb can only be used here between parentheses, "within scope"
			//redCube.transform.localScale = new Vector3 (2, 3, 1);
			//Debug.Log (Input.GetAxis ("Horizontal"));
			rb.AddForce (new Vector3 (20, 0, 0) * Input.GetAxis("Horizontal"));

		}

		if ( Input.GetKey(KeyCode.A) == true ) {
			gameObject.GetComponent<ParticleSystem>().enableEmission = true;
			Debug.Log ( "A was pressed");
		}


		 
	}
}