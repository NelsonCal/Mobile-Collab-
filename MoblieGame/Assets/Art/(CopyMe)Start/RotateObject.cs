using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

	// Use this for initialization
	public float xRotate = 0.0f;
	public float yRotate = 0.0f;
	public float zRotate = 0.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (xRotate, yRotate, zRotate);
	}
}
