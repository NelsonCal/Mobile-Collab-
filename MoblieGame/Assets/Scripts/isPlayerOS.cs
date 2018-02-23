using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isPlayerOS : MonoBehaviour {
    public bool Android = false;
    public GameObject mobileStick;
    public float OSnumber = 0.0f;
	// Use this for initialization
	void Start () {
        OSnumber = PlayerPrefs.GetFloat("isOS");
        if (OSnumber == 1)
        {
            Android = true;
        }
        if (OSnumber == 2)
        {
            Android = false;
        }

        PlayerPrefs.GetFloat("isOS");
        if (Android == true || OSnumber == 1)
        {
            gameObject.GetComponent<MobileMovement>().enabled = true;
            gameObject.GetComponent<PlatformerMovementWithFeet>().enabled = false;
            mobileStick.SetActive(true);
        }

        if (Android == false || OSnumber == 2)
        {
            gameObject.GetComponent<MobileMovement>().enabled = false;
            gameObject.GetComponent<PlatformerMovementWithFeet>().enabled = true;
            mobileStick.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update () {

    }
    public void Android1()
    {
        Android = true;
        OSnumber = 1;
        PlayerPrefs.SetFloat("isOS", OSnumber);
    }
    public void Pc1()
    {
        Android = false;
        OSnumber = 2;
        PlayerPrefs.SetFloat("isOS", OSnumber);

    }


}
