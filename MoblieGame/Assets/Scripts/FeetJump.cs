using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class FeetJump : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 13) {
            transform.parent.GetComponent<PlatformerMovementWithFeet>().Grounded();
            transform.parent.GetComponent<MobileMovement>().Grounded();

        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 13) {
            transform.parent.GetComponent<PlatformerMovementWithFeet>().NotGrounded();
            transform.parent.GetComponent<MobileMovement>().NotGrounded();

        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 13)
        {
            transform.parent.GetComponent<PlatformerMovementWithFeet>().Grounded();
            transform.parent.GetComponent<MobileMovement>().Grounded();

        }
    }
}
