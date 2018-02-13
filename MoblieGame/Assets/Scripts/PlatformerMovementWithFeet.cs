using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerMovementWithFeet : MonoBehaviour {
    public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    public float FlySpeed = 1.0f;
    public float Timer = 0;

    private bool grounded = false;
	// Use this for initialization
	void Start () {
 
	}

    public void Reload()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 21)
        {
            Reload();
        }
        if (collision.gameObject.layer == 22)
        {
            Reload();
        }


    }

    // Update is called once per frame
    void Update () {
        Timer += Time.deltaTime;
        if (Timer >= 5)
        {
            moveSpeed *= 1.01f;
            Timer = 0;
            FlySpeed *= 1.01f;
            Timer = 0;
        }

        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;
        if (Input.GetButtonDown("Jump") && grounded) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
            grounded = false;
        }

        if (Input.GetButton("Jump"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * FlySpeed));
        }

        if (Input.GetButtonDown("Fire3")) {
            moveSpeed *= 2f;
        }

    }

    public void Grounded() {
        grounded = true;
       // anim.SetBool("isJumping", false);
    }

    public void NotGrounded() {
        grounded = false;
    }

}
