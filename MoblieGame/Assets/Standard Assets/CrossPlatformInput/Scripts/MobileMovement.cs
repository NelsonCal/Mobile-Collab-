using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class MobileMovement : MonoBehaviour {

    public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    public float FlySpeed = 1.0f;
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
        Vector2 move = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical"));
        GetComponent<Rigidbody2D>().velocity = move * 5.0f;
        anim.SetFloat("X", CrossPlatformInputManager.GetAxis("Horizontal"));
        
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
    }
    public void Grounded()
    {
        grounded = true;
    }

    public void NotGrounded()
    {
        grounded = false;
    }

}
