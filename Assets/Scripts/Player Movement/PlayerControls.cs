using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public Animator animator;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Get left button, move left
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            rb.velocity = new Vector2(-playerSpeed, rb.velocity.y);
        }
        //Get right button, move right
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

            rb.velocity = new Vector2(playerSpeed, rb.velocity.y);
        }
        //Get Jump button, jump
        if (Input.GetKey(KeyCode.Space) && false)
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

    
            //Get Escpae, Go to main menu
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        //Get Gravity button, change gravity
        if (Input.GetKey(KeyCode.E) && gravitySwitchTimer <0.0f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipY = !gameObject.GetComponent<SpriteRenderer>().flipY;

            rb.gravityScale = rb.gravityScale * -1;
            gravitySwitch = gravitySwitch * -1;
            isJumping = true;
            gravitySwitchTimer = gravitySwitchTimerPublic;
        }
        gravitySwitchTimer -= Time.deltaTime;
        if (rb.velocity.y > 20.0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, 10.0f);
        }
        if (rb.velocity.x < 0.1f && rb.velocity.x > -0.1f)
        {
            animator.SetFloat("Speed", -1);
        }
        else
        {
            animator.SetFloat("Speed", 1);

        }

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
