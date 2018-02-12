using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingActivate : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Fly")
        {
            gameObject.GetComponent<Flying>().enabled = true;
            gameObject.GetComponent<PlatformerMovementWithFeet>().enabled = false;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            Debug.Log("Triggered");

            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (other.gameObject.name == "StopFly")
        {
            gameObject.GetComponent<Flying>().enabled = false;
            gameObject.GetComponent<PlatformerMovementWithFeet>().enabled = true;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            Debug.Log("Nope");
        }
    }
}
