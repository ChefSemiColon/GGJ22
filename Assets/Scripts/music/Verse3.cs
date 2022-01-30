using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verse3 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {

        AkSoundEngine.PostEvent("Trigger_Verse_3", gameObject);
        Destroy(gameObject);
    }
}
