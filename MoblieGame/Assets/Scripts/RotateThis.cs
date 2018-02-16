using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateThis : MonoBehaviour {

    // Use this for initialization
    public int RotationSpeed = 0;
    public int xRotate = 0;
	public int yRotate = 0;
    public int zRotate = 0;
    public bool xMove = false;
    public bool yMove = false;
    public bool zMove = false;
    public bool MonsterIsChasing = true;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int RotationSpeed = Random.Range(5, 500);
        if (zMove == true)
        {
            zRotate = RotationSpeed;
        }
        if (xMove == true)
        {
            transform.Translate(0.001f * RotationSpeed, 0, 0);
        }
        if (yMove == true)
        {
            transform.Translate(0, 0.001f * RotationSpeed, 0);
        }
        transform.Rotate (xRotate, yRotate, zRotate * Time.deltaTime);
        if (MonsterIsChasing == true)
        {
            int MonsterChase = Random.Range(5, 15);
            transform.Rotate(0, 0, MonsterChase);
        }
    }
}
