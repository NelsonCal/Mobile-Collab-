using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayerShroom : MonoBehaviour {
    public bool Shroom = false;
    public GameObject Player;
    public GameObject PlayerShroom;
    public float timer = 0.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer = +Time.deltaTime;

        if (Shroom == true)
        {
            PlayerShroom.SetActive(true);
            Player.SetActive(false);

        }
        
        if (Shroom == false )
        {
            PlayerShroom.SetActive(false);
            Player.SetActive(true);


        }

        if (timer >= 10.0f)
        {
            PlayerShroom.SetActive(false);
            Player.SetActive(true);


        }



    }
    public void ShroomPerson()
    {
        Shroom = true;
    }


}
