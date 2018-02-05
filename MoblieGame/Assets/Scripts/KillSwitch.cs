using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "wallTest")
            {
            SceneManager.LoadScene("Test1");
        }
        if (collision.gameObject.name == "wall1e")
        {
            SceneManager.LoadScene("Easy1");
        }
        if (collision.gameObject.name == "wall2e")
        {
            SceneManager.LoadScene("Easy2");
        }
        if (collision.gameObject.name == "wall3e")
        {
            SceneManager.LoadScene("Easy3");
        }


        if (collision.gameObject.name == "wall1m")
        {
            SceneManager.LoadScene("Med1");
        }
        if (collision.gameObject.name == "wall2m")
        {
            SceneManager.LoadScene("Med2");
        }
        if (collision.gameObject.name == "wall3m")
        {
            SceneManager.LoadScene("Med3");
        }


        if (collision.gameObject.name == "wall1h")
        {
            SceneManager.LoadScene("Hard1");
        }
        if (collision.gameObject.name == "wall2h")
        {
            SceneManager.LoadScene("Hard2");
        }
        if (collision.gameObject.name == "wall3h")
        {
            SceneManager.LoadScene("Hard3");
        }

    }
}
