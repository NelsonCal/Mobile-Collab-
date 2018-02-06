using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour {
    public float MoveSpeed = 1.0f;
    public float FlySpeed = 1.0f;

    // Use this for initialization
    void Start () {

    }
	
// Update is called once per frame
void Update () {
        transform.Translate(MoveSpeed, 0, 0);
        MoveSpeed = PlayerPrefs.GetFloat("CameraMove");

        if (Input.GetButton("Vertical"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * FlySpeed * Input.GetAxis("Vertical")));
        }
    }
}
