using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //variable set up
    private Rigidbody2D rb;
    private int gravitySwitch = 1;
    bool isJumping;
    public float gravitySwitchTimer = 2.0f;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        //Get left button, move left
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-2.0f, rb.velocity.y);
        }
        //Get right button, move right
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(2.0f, rb.velocity.y);
        }
        //Get Jump button, jump
        if (Input.GetKey(KeyCode.Space))
        {
            //if gravity is downwards
            if (gravitySwitch == 1 && !isJumping)
            {
                rb.velocity = new Vector2(rb.velocity.x, 20.0f);
                isJumping = true;
            }
            //if gravity is reversed
            if(gravitySwitch == -1 && !isJumping)
            {
                rb.velocity = new Vector2(rb.velocity.x, -20.0f);
                isJumping = true;

            }
        }
        //Get Gravity button, change gravity
        //cooldown needed
        if (Input.GetKey(KeyCode.E) && gravitySwitchTimer <0.0f)
        {
            rb.gravityScale = rb.gravityScale * -1;
            gravitySwitch = gravitySwitch * -1;
            isJumping = true;
        }
        gravitySwitchTimer -= Time.deltaTime;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isJumping = false;
        }
    }
}
