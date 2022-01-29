using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasicMovement : MonoBehaviour
{
    public float time;
    private Rigidbody2D rb;
    public float enemySpeed;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        time += Time.deltaTime;
        //move between 2 points
        //sine wave

        rb.velocity = new Vector3 (enemySpeed * Mathf.Sin(time), rb.velocity.y, 0.0f); 
    }
}
