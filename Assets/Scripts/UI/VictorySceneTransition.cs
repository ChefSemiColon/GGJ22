using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VictorySceneTransition : MonoBehaviour
{
    private float timer = 0.5f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AkSoundEngine.PostEvent("Trigger_Chorus_1", gameObject);
            while (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            SceneManager.LoadScene(3);
        }
    }

}
