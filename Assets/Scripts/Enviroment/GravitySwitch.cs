using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwitch : MonoBehaviour
{
    private Rigidbody2D rb;

    public float gravitySwitchTimerPublic;
    private float gravitySwitchTimer;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //Get Gravity button, change gravity
        if (Input.GetKey(KeyCode.E) && gravitySwitchTimer < 0.0f)
        {
            rb.gravityScale = rb.gravityScale * -1;
            gravitySwitchTimer = gravitySwitchTimerPublic;
        }
        gravitySwitchTimer -= Time.deltaTime;
    }
}
