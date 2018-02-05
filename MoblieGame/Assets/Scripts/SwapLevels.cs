using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapLevels : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "next1e")
        {
            SceneManager.LoadScene("Easy2");
        }
        if (collision.gameObject.name == "next2e")
        {
            SceneManager.LoadScene("Easy3");
        }
        if (collision.gameObject.name == "Home")
        {
            SceneManager.LoadScene("Start");
        }
        if (collision.gameObject.name == "next1m")
        {
            SceneManager.LoadScene("Med2");
        }
        if (collision.gameObject.name == "next2m")
        {
            SceneManager.LoadScene("Med3");
        }
        if (collision.gameObject.name == "next1h")
        {
            SceneManager.LoadScene("Hard2");
        }
        if (collision.gameObject.name == "next2h")
        {
            SceneManager.LoadScene("Hard3");
        }
    }
}
