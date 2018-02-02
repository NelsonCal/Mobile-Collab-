using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingCamera : MonoBehaviour {
    public float MoveSpeed = 1;
    public float Timer = 0;
    public float Timer2 = 0;

    public GameObject TimerText;

    // Use this for initialization
    void Start () {
		
	}
 
	// Update is called once per frame
	void Update () {
        TimerText.GetComponent<Text>().text = "Time: " + Timer;
        Timer2 += Time.deltaTime;
        Timer += Time.deltaTime;
        transform.Translate(MoveSpeed, 0, 0);
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
       /* if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            
        }
        */
    }

}
