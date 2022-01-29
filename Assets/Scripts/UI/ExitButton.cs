using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExitButton : MonoBehaviour
{
    public Button exitButton;
    private float timer = 0.5f;
    void Start()
    {
        //listen to see if the button will be clicked
        exitButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Quit the game
        AkSoundEngine.PostEvent("Play_UI_Stop", gameObject);
        while (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        Application.Quit();
    }
}
