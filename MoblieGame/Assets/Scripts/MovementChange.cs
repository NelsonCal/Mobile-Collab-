using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChange : MonoBehaviour {

	// Use this for initialization
	//public newJim normMove;
    //public newBob sliderMove;
	public int GravityS = 2;

	void Start () {
		//newJim = GameObject.GetComponent<NewMovement> ();
		//newBob = GameObject.GetComponent<ForceMove> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "slider") {
			gameObject.GetComponent<NewMovement> ().enabled = false;
			gameObject.GetComponent<ForceMove> ().enabled = true;
			gameObject.GetComponent<Rigidbody2D> ().gravityScale = GravityS;
			Debug.Log ("Triggered");
		}
	
		if  (other.gameObject.tag == "sliderOff") {
			gameObject.GetComponent<NewMovement> ().enabled = true;
			gameObject.GetComponent<ForceMove> ().enabled = false;
			gameObject.GetComponent<Rigidbody2D> ().gravityScale = 1;
			Debug.Log ("Nope");
		}
	} */
}
