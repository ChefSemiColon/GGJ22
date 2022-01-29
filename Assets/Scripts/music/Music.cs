using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    private AkAmbient[] yup;
    void OnCollisionEnter2D(Collision2D collision)
    {
        //yup = GameObject.Find("Initalise").GetComponents<AkAmbient>();
        //yup[1].Stop(0);
        AkSoundEngine.PostEvent("Trigger_Chorus_1", gameObject);
        Destroy(gameObject);
    }
}
