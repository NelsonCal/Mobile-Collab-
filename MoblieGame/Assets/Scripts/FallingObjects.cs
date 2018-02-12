using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
    public void Reload() {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update () {
        if (Fall == true) {
                  Gravity1 = 1;
                  GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -10 * Gravity1));


        }
    }
}
