using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour {
    public float MoveSpeed = 1;
    public float Timer = 0;
    public float Timer2 = 0;


    // Use this for initialization
    void Start () {
        PlayerPrefs.SetFloat("CameraMove", MoveSpeed);
    }
 
	// Update is called once per frame
	void Update () {
        
        if (Time.timeScale > 0 && MoveSpeed == 0)
        {
            MoveSpeed = PlayerPrefs.GetFloat("CameraMove");
        }
        if (Time.timeScale == 0 && MoveSpeed > 0)
        {
            MoveSpeed = 0;
        }
        
        Timer2 += Time.deltaTime;
        Timer += Time.deltaTime;
        transform.Translate(MoveSpeed, 0, 0);
        /*PlayerPrefs.SetFloat("CameraMove", MoveSpeed);
        if (Timer >= 5)
        {
            MoveSpeed *= 1.01f;
            PlayerPrefs.SetFloat("CameraMove", MoveSpeed);
            Timer = 0;
        }
        if (Input.GetButtonDown("Fire3"))
        {
            MoveSpeed *= 2f;
        }
        if (Timer2 >= 126)
        {
            MoveSpeed = 0;
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            
        }
        */
    }

}
