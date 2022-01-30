using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verse2 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {

        AkSoundEngine.PostEvent("Trigger_Verse_2", gameObject);
        Destroy(gameObject);
    }
}
