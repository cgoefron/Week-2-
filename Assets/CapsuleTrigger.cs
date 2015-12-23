using UnityEngine;
using System.Collections;

public class CapsuleTrigger : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
		GameObject.Find ("WaterText").GetComponent<TextMesh> ().text = null;
	}
	
	// Update is called once per frame
	void Update () {
	}

	// When the player walks into a trigger on the capsule
	void OnTriggerEnter (Collider other) {
		Debug.Log ("The Trigger is working!");
		// The particle component on this game object, turn it off
		gameObject.GetComponent<ParticleSystem>().enableEmission = false;
	    GameObject.Find("Capsule").SetActive(false);
		GameObject.Find ("WaterText").GetComponent<TextMesh> ().text = "ZZZzzz....";
	}
}
