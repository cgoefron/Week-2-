using UnityEngine;
using System.Collections;

public class BombTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	//add time.time
		gameObject.GetComponent<ParticleSystem>().enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		//add if time > starttime, destroy object 
	}

	void OnTriggerEnter (Collider other) {
		Debug.Log ("The Trigger is working!");
		//gameObject.GetComponent<ParticleSystem>().enableEmission = false;
		gameObject.GetComponent<ParticleSystem>().enableEmission = true;
		gameObject.GetComponent<MeshRenderer>().enabled = false;
		//gameObject.GetComponent<"Horse"> 
		GameObject.Find ("Horse").GetComponent<Rigidbody> ().AddForce ( 
		                         new Vector3( Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)) * 3000 );
		//change to positive #, etc., to control range /direction
		//above same as Random.insideUnitSphere * 300
	}
}
