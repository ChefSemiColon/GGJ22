using UnityEngine;

public class EnemyBasicVerticalMovement : MonoBehaviour
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

        rb.velocity = new Vector3(rb.velocity.x, enemySpeed * Mathf.Sin(time), 0.0f);
    }
}