using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TryAgainButton : MonoBehaviour
{
    public Button restartButton;
    private float timer= 0.5f;
    void Start()
    {
        //listen to see if the button will be clicked
        restartButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Load the main scene
        AkSoundEngine.PostEvent("Play_UI_Start", gameObject);
        while (timer > 0)
        {
            timer -= Time.deltaTime;
        }
            SceneManager.LoadScene(1);
    }
}
