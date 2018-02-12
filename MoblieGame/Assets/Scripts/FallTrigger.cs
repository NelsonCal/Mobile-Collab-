using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 20)
        {
            transform.parent.GetComponent<FallingObjects>().Gravityy();
        }
    }
}