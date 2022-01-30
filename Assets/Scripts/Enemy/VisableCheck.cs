using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisableCheck : MonoBehaviour
{
    private void OnBecameVisible()
    {
        AkSoundEngine.PostEvent("Play_Enemy_Vocals", gameObject);
    }
}
