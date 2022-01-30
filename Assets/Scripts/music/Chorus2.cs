using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chorus2 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {

        AkSoundEngine.PostEvent("Trigger_Chorus_2", gameObject);
        Destroy(gameObject);
    }
}
