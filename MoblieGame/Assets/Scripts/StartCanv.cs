using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class StartCanv : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OS()
    {
        gameObject.GetComponent<Canvas>().enabled = false;
    }
    public void Start1()
    {
        gameObject.GetComponent<Canvas>().enabled = true;
    }
    public void Difficulties() {
        gameObject.GetComponent<Canvas>().enabled = true;
    }
    public void Change()
    {
        gameObject.GetComponent<Canvas>().enabled = false;
    }

    public void PlayGame0()
    {
        SceneManager.LoadScene("Level1Easy");
    }
    public void PlayGame1()
    {
        SceneManager.LoadScene("Level1Medium");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("Level1Hard");
    }
    public void PlayGameTest()
    {
        SceneManager.LoadScene("Test1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}