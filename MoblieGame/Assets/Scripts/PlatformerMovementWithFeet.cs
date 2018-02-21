using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerMovementWithFeet : MonoBehaviour {
    public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    public float FlySpeed = 1.0f;
    public float Timer = 0;
    public int points = 0;
    Animator anim;
    public bool grounded = false;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

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
        PlayerPrefs.SetInt("Points", points);
        points = PlayerPrefs.GetInt("Points");
        float moveX = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("X", moveX);
        
        if (grounded == false)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isFlying", true);

        }
        else
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isFlying", false);

        }

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
        //GetComponent<SpriteRenderer>().sprite = Sprite.Flower;

    } 

    public void Grounded() {
        grounded = true;
    }

    public void NotGrounded() {
        grounded = false;
    }

}
