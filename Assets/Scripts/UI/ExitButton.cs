using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExitButton : MonoBehaviour
{
    public Button exitButton;
    void Start()
    {
        //listen to see if the button will be clicked
        exitButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Quit the game
        Application.Quit();
    }
}
