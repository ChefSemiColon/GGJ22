using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    private float timer = 1.5f;
    private GameObject player;
    private GameObject camera;

    private void Start()
    {
        player = GameObject.Find("Player");
        camera = GameObject.Find("Main Camera");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Collision Dection with floor
        if (collision.gameObject.tag == "Player")
        {
            //Play audio
            AkSoundEngine.PostEvent("Play_PC_Death", gameObject);
            //stop camera
            camera.GetComponent<CameraFollow>().enabled = false;
            //stop player collisions, set gravity downwards, give downward velocity
            player.GetComponent<BoxCollider2D>().enabled = false;
            var temp = player.GetComponent<Rigidbody2D>();
            temp.gravityScale = 2.0f;
            temp.velocity = new Vector2(-3.0f,-3.0f);
            StartCoroutine(waitfor());
        }

    }
    IEnumerator waitfor()
    {
        while (timer > 0)
        {

            timer -= Time.deltaTime;
         yield return null;
        }
        SceneManager.LoadScene(2);

    }
}
