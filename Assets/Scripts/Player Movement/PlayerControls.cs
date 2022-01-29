using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //variable set up
    private Rigidbody2D rb;
    private int gravitySwitch = 1;
    bool isJumping;
    public float gravitySwitchTimerPublic;
    private float gravitySwitchTimer;
    public float playerSpeed;
    public float playerJumpHeight;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //gravitySwitchTimer = gravitySwitchTimerPublic;
    }

    void Update()
    {
        //Get left button, move left
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-playerSpeed, rb.velocity.y);
        }
        //Get right button, move right
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(playerSpeed, rb.velocity.y);
        }
        //Get Jump button, jump
        if (Input.GetKey(KeyCode.Space))
        {
            //if gravity is downwards
            if (gravitySwitch == 1 && !isJumping)
            {
                rb.velocity = new Vector2(rb.velocity.x, playerJumpHeight);
                isJumping = true;
            }
            //if gravity is reversed
            if(gravitySwitch == -1 && !isJumping)
            {
                rb.velocity = new Vector2(rb.velocity.x, -playerJumpHeight);
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
            gravitySwitchTimer = gravitySwitchTimerPublic;
        }
        gravitySwitchTimer -= Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Collision Dection with floor
        if (collision.gameObject.tag == "Floor")
        {
            isJumping = false;
        }
    }
}
