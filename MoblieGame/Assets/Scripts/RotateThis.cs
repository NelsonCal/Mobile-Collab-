using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateThis : MonoBehaviour {

    // Use this for initialization
    public int RotationSpeed = 0;
    public int xRotate = 0;
	public int yRotate = 0;
    public int zRotate = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int RotationSpeed = Random.Range(5, 500);
        zRotate = RotationSpeed;
        transform.Translate(0.001f * RotationSpeed, 0, 0);
        transform.Translate(0, 0.001f * RotationSpeed, 0);

        transform.Rotate (xRotate, yRotate, zRotate * Time.deltaTime);
    }
}
