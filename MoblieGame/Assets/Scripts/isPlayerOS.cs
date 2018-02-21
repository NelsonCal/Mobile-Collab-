using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isPlayerOS : MonoBehaviour {
    public bool Android = false;
    public GameObject mobileStick;
	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {

        if (Android == true)
        {
            gameObject.GetComponent<MobileMovement>().enabled = true;
            gameObject.GetComponent<PlatformerMovementWithFeet>().enabled = false;
            mobileStick.SetActive(true);
        }

        if (Android == false)
        {
            gameObject.GetComponent<MobileMovement>().enabled = false;
            gameObject.GetComponent<PlatformerMovementWithFeet>().enabled = true;
            mobileStick.SetActive(false);

        }


    }
}
