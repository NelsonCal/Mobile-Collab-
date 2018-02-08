using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour {
    public int Gravity1 = 0;
    public bool Fall = false;

    // Use this for initialization
    void Start () {
        gameObject.GetComponent<Rigidbody2D>().gravityScale = Gravity1;
    }

    public void Gravityy() {
        Fall = true;
    }

    // Update is called once per frame
    void Update () {
        if (Fall == true) {
                  Gravity1 = 1;
                  GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -100 * Gravity1));


        }
    }
}
