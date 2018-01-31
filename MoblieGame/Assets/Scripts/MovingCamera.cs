using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingCamera : MonoBehaviour {
    public float MoveSpeed = 1;
    public float Timer = 0;
    public GameObject TimerText;

    // Use this for initialization
    void Start () {
		
	}
 
	// Update is called once per frame
	void Update () {
        TimerText.GetComponent<Text>().text = "Time: " + Timer;

        Timer += Time.deltaTime;
        transform.Translate(MoveSpeed, 0, 0);
        if (Timer >= 5)
        {
            MoveSpeed *= 1.01f;
            Timer = 0;
        }
    }
}
